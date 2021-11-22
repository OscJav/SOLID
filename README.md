# SOLID


1.	Principio de responsabilidad única:

 Consiste en que una clase solo debe ser responsable de métodos propios de su clase, cada clase debe tener una responsabilidad. En este ejercicio la clase “empleado” tiene el método “PagoSalud”, mediante este método se calcula el total que debe pagar un empleado en salud. En esta clase no se cumple el principio de responsabilidad única ya que si cambia el porcentaje de pago en salud se debe cambiar el código de la clase. 
 
 
Para corregir los errores en la creación de los métodos mal implementados en la clase Empleado se crea la nueva clase “CseguridadSocial” dejando la responsabilidad de la seguridad social a esta clase:
 
 
 

2.	Principio de abierto cerrado:

El principio abierto cerrado consiste en que las clases y los métodos deben estar abiertos para extensión, pero cerrados para modificación. Es decir que en lo posible una vez creada la clase se pueda extender sin tener que modificarla. 
Para este ejercicio usamos el ejemplo de un programa que lleva el inventario de una tienda por lo que tenemos las Clases “Producto” y la clase “miTienda”. La clase “Producto” tiene los atributos Nombre, Categoría y Precio, y la clase “miTienda” recibe el listado de los productos y mediante un ciclo calcula el inventario. Pero si por alguna razón los requerimientos en los precios de los productos cambian se debe cambiar la clase “miTienda” por tanto no se cumple el principio de Abierto-Cerrado.




 
Clase “Producto”
 
Clase “miTienda”
 
Programa sin corrección

Para implementar el principio Abierto-Cerrado se crea una Clase Base para discriminar los diferentes tipos de productos que puede tener una tienda (Alimentos, medicamentos…etc).
 

Por medio de la Herencia se crean las clases para Alimentos y Medicamentos. De esta forma queda protegida la clase “miTienda” en caso de nuevos cambios de requerimientos.

 


