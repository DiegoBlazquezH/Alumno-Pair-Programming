# Gestor de alumnos con pair programming

Ampliación del proyecto Gestor de alumnos, aplicando pair programming (participantes: Diego Blázquez y Andreu Conesa)

A continuación se explican los patrones de diseño aplicados en este proyecto y la funcionalidad para la que se han implementado.

# Abstract factory
Es un patrón de creación que a traves de una interfaz permite crear familias de objetos relacionados o dependientes sin especificar sus clases concretas.
El diagrama de clases UML para este patrón es el siguiente:

![alt text](http://www.dofactory.com/images/diagrams/net/abstract.gif)

El patrón Abstract factory se ha aplicado en la creación de los distintos archivos. A traves de la interfaz IFicheroFactory y su método CrearFichero se pueden generar los 3 tipos de archivo.

# Adapter
Es un patrón de diseño estructural que convierte la interfaz de una clase en otra esperada por los clientes. Así pues, permite que clases con interfaces incompatibles puedan trabajar juntas.
El diagrama de clases UML para este patrón es el siguiente:

![alt text](http://www.dofactory.com/images/diagrams/net/adapter.gif)

El patrón Adapter se ha aplicado para la librería log4net y la posibilidad de enviar correos electrónicos así como mostrar las excepciones en Debug.
Tenemos la clase logger que implementa la interfaz ITargetAdapterForLogger y cuyos métodos llaman a funciones concretas de la clase ILog de log4net.

# Singleton
Es un patrón de diseño creacional que asegura que una clase solo tenga una instancia y proporciona un punto de acceso global a ella.
El diagrama de clases UML para este patrón es el siguiente:

![alt text](http://www.dofactory.com/images/diagrams/net/singleton.gif)

El patrón Singleton se ha aplicado en las colecciones de alumnos de los archivos JSON y XML en el formulario AlumnosShowForm. Cuando este formulario se carga, se genera una instancia de las clases ListadoAlumnosJson y ListadoAlumnosXml que contienen las listas de los ficheros en ese instante.

# ¿Cómo funciona el programa?

Por un lado hay el formulario principal que permite añadir alumnos en los tres archivos de formato JSON, TXT y XML, y por el otro el formulario que muestra los alumnos de esos archivos. En el segundo caso, se pueden filtrar los alumnos por distintos atributos.