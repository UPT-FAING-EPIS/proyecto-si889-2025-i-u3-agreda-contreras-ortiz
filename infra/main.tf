resource "azurerm_resource_group" "rg" {
  name     = var.resource_group_name
  location = var.location
}

resource "azurerm_service_plan" "windows_asp" {
  name                = "windows-service-plan"
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name
  os_type             = "Windows"
  sku_name            = "F1"
}

resource "azurerm_windows_web_app" "dotnet48_app" {
  name                = "pianorise-patrones-test-net"
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name
  service_plan_id     = azurerm_service_plan.windows_asp.id

  site_config {
    always_on         = false
    use_32_bit_worker = true

    application_stack {
      current_stack  = "dotnet"
      dotnet_version = "v4.0"
    }
  }
}



resource "azurerm_service_plan" "linux_asp" {
  name                = "linux-service-plan"
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name
  os_type             = "Linux"
  sku_name            = "F1"
}

resource "azurerm_linux_web_app" "docker_app" {
  name                = "pianorise-patrones-test-python"
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name
  service_plan_id     = azurerm_service_plan.linux_asp.id

  site_config {
    always_on = false

    application_stack {
      docker_image_name = "ximenaortiz/backend-piano-rise:latest"
    }
  }
}
