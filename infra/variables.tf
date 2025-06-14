variable "resource_group_name" {
  description = "Nombre del Resource Group donde se crearán los recursos."
  type        = string
}

variable "location" {
  description = "Región de Azure donde se desplegarán los recursos."
  type        = string
  default     = "East US"
}

variable "app_service_plan_name" {
  description = "Nombre del App Service Plan que alojará las Web Apps."
  type        = string
}

variable "webapps" {
  description = "Lista de Web Apps a crear."
  type = list(object({
    name              = string
    use_docker        = bool
    image_name        = optional(string)
    image_tag         = optional(string)
    registry_url      = optional(string)
    registry_username = optional(string)
    registry_password = optional(string)
  }))
}
