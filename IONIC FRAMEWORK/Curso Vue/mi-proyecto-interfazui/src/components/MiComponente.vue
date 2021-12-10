<template>
  <div class="Micomponente">
      <h1>Mi Componente de libros funciona</h1>
      <!-- Desplegando las propiedades que estan en data -->
      <p>{{libro.titulo}} de <span style="color: blue">{{libro.autor}}</span></p>
      <!-- Concatenando valores -->
      <p>{{"El libro es "+ libro.titulo +" del autor "+ libro.autor}}</p>
      <!-- Administrar o llamar funciones, no se recomienda modificar valores dentro de las llaves, la idea es que solamente se deplege la informacion-->
      <p>{{"El libro es "+ libro.titulo.toString().toUpperCase()}}</p>
      <!-- Se reomienda por buenas practicas hacer la concatenacion de la siguiente manera -->
       <p>El libro es {{libro.titulo}} del autor {{libro.autor}}</p>
        <!-- Inyectar etiquetas html desde el data, con el atributo que va hacer 'v-', es el estandar que utiliza vue para poder inyectar sus propios atributos sin modificar el codigo html y tener una pista de lo que se esta hablando -->
       <div v-html="libro.html">
          
       </div>
  </div>
</template>

<script>
//Inicializar nuestro componente para poder importarlo
export default {
  //Definir el mismo nombre que nuestro archivo
  name: "MiComponente",
  // Nos permite inyectar variables tanto estaticas o dinamicas, debe ir en 
  // formato de funcion
  data() {
    // Return es la informacion que vamos a devolver , va hacer un objeto
    return {
      //Agregar propiedas
      libro: {
          autor:"Umberto eco",
          titulo:"Pendulo de Foucault",
          html:"<h3>Este elemento html es inyectado desde el data</h3>"
      }
    };
  },
};
</script>

<style></style>
