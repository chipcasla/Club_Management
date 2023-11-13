### Clase `Persona`
- Atributos:
  - `numDoc: int`
  - `nombre: string`
  - `apellido: string`
  - `mail: string`
  - `password: string`

### Clase `Entrenador` (hereda de `Persona`)
- Atributos:
  - `especialidad: string`

### Clase `Socio` (hereda de `Persona`)
- Atributos:
  - `fechaInscripcion: DateTime`
  - `estadoDePago: string`

### Clase `Administrador` (hereda de `Persona`)
- Atributos:
  - `rol: string`
  - `permisos: string`

### Clase `Canchas`
- Atributos:
  - `id: int`
  - `nombre: string`
  - Otros atributos relacionados con las características de la cancha

### Clase `ActividadesDeportivas`
- Atributos:
  - `id: int`
  - `nombre: string`
  - Otros atributos relacionados con la actividad

### Clase `Turnos`
- Atributos:
  - `id: int`
  - `horaInicio: DateTime`
  - `horaFin: DateTime`
  - Otros atributos relacionados con la asignación de turnos a canchas y actividades deportivas