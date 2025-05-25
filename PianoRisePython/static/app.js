const socket = io();
let audioContext, mediaStream, processor, selectedDeviceId;
const sendInterval = 300;
let lastSentTime = 0;
let songCompleted = false;

let song = ["C", "D", "E", "F", "G", "A", "B", "C"];
const pianoNotes = ["C", "D", "E", "F", "G", "A", "B", "C"];

function drawPiano() {
    const piano = document.getElementById("piano_keyboard");
    piano.innerHTML = "";

    pianoNotes.forEach(note => {
        const key = document.createElement("div");
        key.className = "piano-key w-12 h-32 flex items-end justify-center bg-white text-slate-800 border border-gray-300 rounded-md text-sm font-bold transition-all";
        key.innerText = note;
        key.setAttribute("id", `key_${note}`);
        piano.appendChild(key);
    });
}

async function getMicrophones() {
    const devices = await navigator.mediaDevices.enumerateDevices();
    const audioDevices = devices.filter(device => device.kind === "audioinput");

    const micSelect = document.getElementById("micSelect");
    micSelect.innerHTML = "";

    audioDevices.forEach(device => {
        const option = document.createElement("option");
        option.value = device.deviceId;
        option.textContent = device.label || `Micrófono ${micSelect.length + 1}`;
        micSelect.appendChild(option);
    });

    if (audioDevices.length > 0) {
        selectedDeviceId = audioDevices[0].deviceId;
    }

    micSelect.addEventListener("change", (event) => {
        selectedDeviceId = event.target.value;
    });
}

async function startRecording() {
    try {
        let stream = await navigator.mediaDevices.getUserMedia({
            audio: { deviceId: selectedDeviceId ? { exact: selectedDeviceId } : undefined }
        });

        audioContext = new (window.AudioContext || window.webkitAudioContext)();
        mediaStream = audioContext.createMediaStreamSource(stream);
        processor = audioContext.createScriptProcessor(512, 1, 1);

        processor.onaudioprocess = event => {
            let now = Date.now();
            if (now - lastSentTime >= sendInterval) {
                const audioData = event.inputBuffer.getChannelData(0);
                socket.emit("audio_stream", audioData.buffer);
                lastSentTime = now;
            }
        };

        mediaStream.connect(processor);
        processor.connect(audioContext.destination);

        document.getElementById("start").innerText = "🎙 Grabando...";
        document.getElementById("start").disabled = true;
        document.getElementById("stop").disabled = false;
    } catch (error) {
        console.error("❌ Error al acceder al micrófono:", error);
    }
}

function stopRecording() {
    if (mediaStream) mediaStream.disconnect();
    if (processor) processor.disconnect();
    if (audioContext) audioContext.close();

    document.getElementById("start").innerText = "▶️ Iniciar";
    document.getElementById("start").disabled = false;
    document.getElementById("stop").disabled = true;
}

socket.on("nota_detectada", data => {
    if (songCompleted) return;

    const { nota, feedback, nota_esperada } = data;

    document.getElementById("nota_actual").innerText = nota || "🎹 Esperando...";
    document.getElementById("nota_esperada").innerText = nota_esperada || "🎯";


    const progressBar = document.getElementById("progress_bar");
    const progressText = document.getElementById("progress_text");

    if (feedback) {
        if (feedback.includes("¡Canción completa!")) {
            progressBar.value = 100;
            progressText.innerText = "¡Completado!";
            songCompleted = true;
        } else {
            let parts = feedback.match(/\((\d+)\/(\d+)\)/);
            if (parts) {
                let current = parseInt(parts[1]);
                let total = parseInt(parts[2]);
                let progressPercent = (current / total) * 100;
                progressBar.value = progressPercent;
                progressText.innerText = `${Math.round(progressPercent)}% completado`;
            }
        }
    }

    const noteHistoryDiv = document.getElementById("note_history");
    const noteElement = document.createElement("div");
    noteElement.className = "px-3 py-2 bg-pink-100 text-pink-800 rounded-md text-sm font-medium";
    noteElement.innerText = nota;
    noteHistoryDiv.appendChild(noteElement);

    if (noteHistoryDiv.children.length > 10) {
        noteHistoryDiv.removeChild(noteHistoryDiv.children[0]);
    }

    pianoNotes.forEach(noteItem => {
        const key = document.getElementById(`key_${noteItem}`);
        if (key) {
            key.classList.remove("bg-purple-500", "text-white");
            key.classList.add("bg-white", "text-slate-800");
        }
    });

    if (nota) {
        const activeKey = document.getElementById(`key_${nota}`);
        if (activeKey) {
            activeKey.classList.remove("bg-white", "text-slate-800");
            activeKey.classList.add("bg-purple-500", "text-white");

            activeKey.classList.add("scale-110");
            setTimeout(() => activeKey.classList.remove("scale-110"), 200);
        }
    }
    if (feedback.includes("¡Canción completa!")) {
        progressBar.value = 100;
        progressText.innerText = "¡Completado!";
        songCompleted = true;
    
        confetti({
            particleCount: 150,
            spread: 70,
            origin: { y: 0.6 }
        });
    }    
});

document.addEventListener("DOMContentLoaded", () => {
    const songText = document.getElementById("song_text");
    songText.innerText = song.join(" - ");

    const songDisplay = document.getElementById("song_display");
    song.forEach(note => {
        const noteElement = document.createElement("div");
        noteElement.className = "px-4 py-2 bg-slate-200 text-slate-700 rounded-md text-lg font-semibold";
        noteElement.innerText = note;
        songDisplay.appendChild(noteElement);
    });

    drawPiano();
    getMicrophones();
});
