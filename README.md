# TPWinForm_Equipo8A

Aplicación de escritorio desarrollada en **C# con Windows Forms** para la gestión de un catálogo de artículos, marcas, categorías e imágenes asociadas.

El proyecto trabaja con una base de datos en **SQL Server** y está organizado en capas para separar la interfaz gráfica, la lógica de negocio y las entidades del dominio.

---

## Descripción

Esta aplicación permite administrar un catálogo de productos desde una interfaz de escritorio simple.

Desde el menú principal se accede a los módulos de:

- Artículos
- Marcas
- Categorías

Cada artículo puede estar asociado a una marca, una categoría y una o más imágenes por URL.

---

## Funcionalidades principales

### Artículos

- Listado de artículos en grilla.
- Alta de artículos.
- Modificación de artículos.
- Eliminación de artículos.
- Visualización de imágenes del artículo seleccionado.
- Navegación entre múltiples imágenes del mismo artículo.
- ABM de imagenes relacionadas.

### Marcas

- Listado de marcas.
- Alta de marcas.
- Modificación de marcas.
- Eliminación con validación de referencias en artículos.

### Categorías

- Listado de categorías.
- Alta de categorías.
- Modificación de categorías.
- Eliminacion con validación de referencias en artículos.

---

## Tecnologías utilizadas

- C#
- Windows Forms
- .NET Framework 4.8
- SQL Server / LocalDB
- Git

### Arquitectura en capas

El proyecto se encuentra dividido en las siguientes capas:

- **TPWinForm_equipo-8A**: interfaz gráfica.
- **negocio**: lógica de negocio y acceso a datos.
- **dominio**: entidades del sistema.

---

## Estructura del proyecto

TPWinForm_Equipo8A/

├── TPWinForm_equipo-8A/   # Proyecto principal WinForms

├── negocio/               # Lógica de negocio y acceso a datos

├── dominio/               # Clases del dominio

└── CATALOGO_DB_v3.sql     # Script de base de datos

---

## Requisitos

Antes de ejecutar el proyecto necesitás tener instalado:

- Visual Studio con soporte para .NET Framework 4.8.
- SQL Server LocalDB o SQL Server Express.
- Git.

---

## Configuración de la base de datos

Crear la base de datos ejecutando el script:

**CATALOGO_DB_v3.sql**

Verificar la cadena de conexión en el archivo:

**negocio/AccesoDatos.cs**

Actualmente el proyecto está configurado para usar:

**server=(localdb)\MSSQLLocalDB; database=CATALOGO_P3_DB; integrated security=true**

Si usás **SQLEXPRESS**, en ese mismo archivo hay una alternativa comentada que podés habilitar.

---

## Cómo ejecutar el proyecto

Clonar el repositorio:

**git clone https://github.com/SebasYa/TPWinForm_Equipo8A.git**

Abrir la solución en Visual Studio.

Restaurar y compilar el proyecto.

Ejecutar la aplicación.

---

## Pantallas principales

- Menú principal con acceso a Artículos, Marcas y Categorías.
- Gestión de artículos con grilla, imagen previa y navegación entre imágenes.
- Gestión de marcas con ABM completo.
- Gestión de categorías con ABM completo.

---

## Estado del proyecto

Proyecto académico. 
Universidad Tecnica Nacional - FRGP -

---

## Autores

- [Sebastian Yanni](https://github.com/SebasYa)
- [Maximiliano Bianchi](https://github.com/maxibian)
- [Marcelo Rearte Becerra](https://github.com/marceloreart)
