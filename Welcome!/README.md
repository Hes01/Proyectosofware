# Proyectosofware

Proyecto del Curso de Sofware-Sistema de Proceso de Ventas Nortfarma S.A.C


## Descripción General
Este proyecto es un sistema de gestión de farmacia desarrollado en **C#** bajo el patrón de diseño **MVC (Modelo-Vista-Controlador)**, utilizando **SQL Server** como motor de base de datos y empleando tecnologías frontend como **Bootstrap** y **jQuery** para una interfaz interactiva y dinámica. Adicionalmente, cumple con las normativas **ISO 25010** y **ISO 25012** para asegurar la calidad en los datos y el software.

---

## Tecnologías Utilizadas
- **Lenguaje:** C#
- **Framework:** ASP.NET MVC
- **Base de Datos:** SQL Server
- **Frontend:** Bootstrap y jQuery
- **Complementos:** Plantillas adicionales para mejora de la interfaz de usuario

---

## Normas de Calidad
El proyecto se ha diseñado siguiendo los principios de las normas de calidad **ISO 25010** y **ISO 25012**:

- **ISO 25010:** Esta norma asegura la calidad del software, cubriendo atributos como:
  - **Funcionalidad:** El sistema permite gestionar inventarios, realizar ventas, y manejar categorías de productos y clientes.
  - **Usabilidad:** Interfaz clara y accesible gracias a Bootstrap.
  - **Mantenibilidad:** Código estructurado y siguiendo buenas prácticas de programación en C#.

- **ISO 25012:** Norma para la calidad de los datos. Esto implica:
  - **Precisión:** Los datos de ventas, productos, y clientes son precisos y actualizados.
  - **Consistencia:** Manejamos integridad referencial en SQL Server para asegurar la relación correcta entre tablas.
  - **Disponibilidad:** Los datos son accesibles y recuperables cuando se necesitan.

  ---

## Funcionalidades Principales
### 1. Gestión de Usuarios
Permite la creación, modificación y eliminación de usuarios en el sistema, con diferentes roles (Cajero, Administrador, Cliente, etc.).

### 2. Módulo de Ventas
Facilita el registro de ventas de productos farmacéuticos, generando un comprobante de pago y detalles de cada transacción.

### 3. Administración de Productos
Manejo de inventarios, incluyendo la actualización de stock y la clasificación de productos en distintas categorías.

### 4. Reportes
Generación de reportes que cumplen con los requerimientos de auditoría y trazabilidad.

---

## Estructura del Proyecto

### MVC
| Componente   | Descripción                                                                                   |
|--------------|-----------------------------------------------------------------------------------------------|
| **Modelo**   | Define las entidades del sistema, como Producto, Venta, Cliente, con sus respectivas reglas de negocio. |
| **Vista**    | Utiliza plantillas de Bootstrap para ofrecer una interfaz de usuario amigable y funcional.    |
| **Controlador** | Gestiona la interacción entre las vistas y los modelos, y maneja la lógica de negocio.      |

---

### Capas

| Capa   | Descripción                                                                                   |
|--------------|-----------------------------------------------------------------------------------------------|
| **3 capas de manejo de datos**   | Para la manipulación de datos. |
| **2 capas de presentación**    | Para el manejo e interacción de las vistas.    |


---



## Conclusión
Este sistema de gestión de farmacia se ha desarrollado siguiendo prácticas de programación de alta calidad, respetando normas internacionales como ISO 25010 y ISO 25012, y está diseñado para facilitar la administración de inventarios, ventas y usuarios de manera eficiente y confiable.