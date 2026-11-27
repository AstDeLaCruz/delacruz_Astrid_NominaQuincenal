## Sistema de Nómina Quincenal

**Proyecto:** Nómina Quincenal  
**Estudiante:** Astrid Carolina De La Cruz De La Cruz  
**Matrícula:** 2026-1718  
**Universidad:** Universidad Central del Este (UCE)  
**Carrera:** Ingeniería de Software  
**Asignatura:** Programación Básica  
**Lenguaje:** C#  
**Entorno de desarrollo:** Visual Studio  
**Tecnología:** Windows Forms

---

##  Descripción del proyecto

Este proyecto consiste en el desarrollo de una aplicación de escritorio para calcular la nómina quincenal de los empleados de una empresa, utilizando C# y Windows Forms.

La aplicación permite registrar el nombre del empleado, seleccionar su tipo de contrato y cargo, introducir las horas trabajadas durante la quincena e indicar si recibe incentivo de transporte.

El sistema calcula automáticamente el salario regular, las horas extras, las deducciones correspondientes y el pago neto de cada empleado. Además, permite registrar varios empleados y generar un resumen general de la nómina.

##  Funcionalidades principales

- **Registro de empleados:** permite introducir el nombre de cada empleado.
- **Selección de contrato:** permite elegir entre contrato fijo y temporal.
- **Selección de cargo:** permite seleccionar el puesto del empleado mediante un ComboBox.
- **Registro de horas:** permite introducir las horas trabajadas durante la quincena.
- **Incentivo de transporte:** agrega RD$1,500 al salario cuando el CheckBox está seleccionado.
- **Cálculo del salario regular:** calcula el pago correspondiente a un máximo de 88 horas.
- **Cálculo de horas extras:** aplica un 35% adicional a las horas que excedan las 88 horas.
- **Cálculo de deducciones:** aplica AFP de 2.87% y SFS de 3.04% únicamente a los empleados con contrato fijo.
- **Cálculo del salario neto:** determina el pago final del empleado después de aplicar las deducciones.
- **Listado de empleados:** muestra los empleados registrados y sus respectivos pagos.
- **Mostrar resumen:** presenta la cantidad de empleados y los totales de bruto, deducciones y neto de la nómina.
- **Limpiar:** permite reiniciar los campos del formulario.
- **Salir:** permite cerrar la aplicación.

##  Cálculos del sistema

El programa utiliza las siguientes operaciones:

1. **Salario regular:** horas trabajadas hasta 88 multiplicadas por la tarifa correspondiente al cargo.
2. **Horas extras:** horas que exceden las 88, multiplicadas por la tarifa y por 1.35.
3. **Incentivo de transporte:** RD$1,500 cuando el empleado tiene seleccionado este beneficio.
4. **Salario bruto:** suma del salario regular, las horas extras y el incentivo de transporte.
5. **Deducciones:** para contratos fijos, se calcula AFP del 2.87% y SFS del 3.04% sobre el salario regular más las horas extras. Los contratos temporales no tienen deducciones.
6. **Salario neto:** salario bruto menos las deducciones correspondientes.

### Tarifas por hora

| Cargo | Tarifa |
|---|---:|
| Auxiliar | RD$180 |
| Técnico | RD$250 |
| Supervisor | RD$350 |
| Gerente | RD$500 |

##  Conceptos de programación utilizados

- Variables y constantes.
- Tipos de datos `string`, `decimal` e `int`.
- Condicionales `if` y `else`.
- Operadores aritméticos y lógicos.
- Métodos y funciones.
- Eventos y controladores de eventos.
- Manejo de formularios con Windows Forms.
- Validación de datos mediante `int.TryParse()`.
- Cuadros de mensajes mediante `MessageBox.Show()`.
- Manipulación de listas con `ListBox`.
- Selección de opciones mediante `RadioButton`.
- Selección de cargos mediante `ComboBox`.
- Uso de `CheckBox` para el incentivo de transporte.
- Acumuladores para calcular los totales de la nómina.
- Formato de moneda RD$ con dos decimales.

##  Tecnologías utilizadas

- C#
- .NET Windows Forms
- Microsoft Visual Studio

##  Ejecución del proyecto

1. Abrir el proyecto en Visual Studio.
2. Cargar la solución del proyecto Nómina Quincenal.
3. Ejecutar la aplicación.
4. Introducir el nombre del empleado.
5. Seleccionar el tipo de contrato y el cargo correspondiente.
6. Introducir las horas trabajadas durante la quincena.
7. Marcar el incentivo de transporte si corresponde.
8. Presionar **Registrar empleado** para calcular y agregar el empleado a la lista.
9. Repetir el proceso para registrar otros empleados.
10. Presionar **Mostrar resumen** para visualizar los totales generales de la nómina.

---

##  Capturas de pantalla

### 1. Registro de empleados
![EmpleadosRegistro](Capturas/EmpleadosRegistro.png)

### 2. Validación de contrato vacío
![contratoVacio](Capturas/contratoVacio.png)

### 3. Validación de nombre vacío
![nombreVacio](Capturas/nombreVacio.png)

### 4. Validación de cargo vacío
![cargoVacio](Capturas/cargoVacio.png)

### 5. Validación de horas
![horas](Capturas/horas.png)
