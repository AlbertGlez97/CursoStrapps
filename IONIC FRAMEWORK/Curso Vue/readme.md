# Crear interfaces web interactivas con Vue.js

## Caracteristicas
* Framework de JavaScript
* Realiza tareas complejas en aplicaciones interactivas 
* Se basa en tres pilares fundamentales:
  * Facilidad de uso
  * Versatilidad
  * Alto rendimiento
* Baja huellaa, se tienen que descargar pocos datos para utilizarla
* Baja curva de aprendizaje
* Acceso a capacidades muy robustas
* Implementacion paulatina
* Trabaja elemnetos muy visuales
* Arquitectura similar a Angular

## Trabajar con Vue.js
* No usa plataforma o herramienta especifica
* Instalar Node.js en tu ordenador
* Se recomienda Visual Studio Code (Instalar como plugin Vetur)

## Instalacion basica de Vue.js
* En un proyecto normal de html , agregar el CDN de vue que se encuentra en 'https://cdn.jsdelivr.net/npm/vue/' seleccionar los de Distribucion y utilizar 'vue.min.js'

## Instalacion con la linea de comandos de Vue.js
* En la terminal poner la siguiente linea:
```
npm install -g @vue/cli
```
* Crear un proyecto de Vue.js , utilizando la terminal:
```
vue create nombreProyecto
```
* Posicionarse en el proyecto 
```
cd nombreProyecto
```
* Corre el proyecto
```
npm run serve
```

## Crear aplicaciones con la interfaz grafica de Vue.js
* En la terminal poner la siguiente linea:
```
vue ui
```
* Posicionarse en el proyecto 
```
cd nombreProyecto
```
* Corre el proyecto
```
npm run serve
```

## Estructura de un proyecto Vue.js
* Archivo Package.json
  * Tenemos las dependencias, que son los diferentes librerias para ejecutar nuestra aplicaciones, estas mismas se almacenan en la carpeta node_modules.
  * El script, que son rutinas predeterminadas para ejecutar nuestra aplicacion:
    * Serve .- Nos sirve para ejecutar un servidor dentro de nuestro sistema y poder hacer pruebas durante el desarrollo de nuestra aplicacion
    * Build .- Nos va a permitir crear un paquete optimizado y publicar nuestra aplicacion
    * Lint .- Para analizar nuestra aplicacion
* Carpeta Public
Aqui tenemos un archivo index.html, este va hacer el punto central de nuestra aplicacion, se obtiene el punto de partida. 
En el html vamos a encontrar una div con el id="app", aqui es donde se ejecutar nuestra aplicacion y donde vamos a inyectar los datos que la van a componer
* Carpeta Src
Es donde usualmente vamos a crear nuestro codigo , donde se encuentran los archivos javascript y vue, para poder crear nuestra aplicacion
  * Archivo Main.js   
  Es donde inicializamos nuestra aplicacion, definir la etiqueta app, tal como aparece en el archivo index, aqui es donde vamos a inyectar nuestra aplicacion.
  Se definen algunos elementos basicos, asi como importar las bases de lo que sera la aplicacion.
  * Archivo App.vue
  Es el archivo donde se esta ejecutando nuestra aplicacion, es el componente padre, tenemos los contenidos que se estan desplegando dentro de la aplicacion, la que se ejecuta en nuestro sistema, la capa visual
  * Carpeta Componentes
  * Assets
  Contenido multimedia

## Estructura de un componente en Vue.js
Primero hay que entender que cada componente esta dividido en tres grandes areas:
* Etiqueta template
Es una plantilla, que se va encargar de desplegar elementos visuales, lo que va a aparecer dentro del navegador. Esta puedo contener informacion estatica o dinamica, podemos incluir interaccion, diferentes variables , clases, etc.  
* Etiqueta script
Aqui es donde vamos a poner todo el codigo que va a controlar el componente , aca es donde se coloca toda la informacion, vamos a importar datos , hacer calculos ,administrar las interacciones.
* Etiqueta style
Va a manejar la parte visual, no solo los contenidos que se despliegan dentro de template , sino les va a dar una apariencia Visual, como modificar colores, aparencia, etc.