output "webapp_urls" {
  value = {
    docker_app  = "https://${azurerm_linux_web_app.docker_app.default_hostname}"
    net48_app   = "https://${azurerm_windows_web_app.dotnet48_app.default_hostname}"
  }
}
