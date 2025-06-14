resource_group_name   = "pianorise-rg-test"
location              = "East US"
app_service_plan_name = "pianorise-appserviceplan-test"

webapps = [
  {
    name              = "pianorise-patrones-test-python"
    use_docker        = true
    image_name        = "ximenaortiz/backend-piano-rise"
    image_tag         = "latest"
    registry_url      = "https://index.docker.io"
    registry_username = "ximenaortiz"
    registry_password = "dckr_pat_GmDdreBeTkZk2NDA1OgEtnzWETM"
  },
  {
    name       = "pianorise-patrones-test-net"
    use_docker = false
  }
]
