<template>
  <div class="DespliegueArreglo">
    <hr />
    <h2>Arreglos</h2>
    Llamar un valor espesifico del arreglo colores
    <br>
    {{ colores[0] }}
    <br>
    <br>
    Iteraccion del arreglo
    <ul>
      <!-- Desplegar la lista e iterar en el arreglo -->
      <li v-for="color in colores" :key="color.id">{{ color }}</li>
    </ul>
    
    <br>
    Es elemento que quiero que se repita por cada iteraccion de nuestro arreglo de Objetos
    <br>
    <br>
    <div v-for="colorObjeto in coloresObjetos" :key="colorObjeto.id">
      Nombre {{ colorObjeto.nombre }} <br />
      Nombre Ingles {{ colorObjeto.nombreIngles }}

      <!-- Todo elemento a dentro de la iterracion tambien se va multiplicar -->
      <p>-----------------------------------------------</p>
    </div>

    <br>
    Crear bucles de componentes
    <br>
    <br>
    <div v-for="x in 10" :key="x.id">
      Iteraccion {{ x }} creada desde template
    </div>
  </div>
</template>

<script>
export default {
  name: "DespliegueArreglo",
  data() {
    return {
      //Arreglo simple
      colores: ["rojo", "verde", "morado", "azul"],
      //Arreglo de objetos
      coloresObjetos: [
        { nombre: "rojo", nombreIngles: "red" },
        { nombre: "azul", nombreIngles: "blue" },
        { nombre: "amarrillo", nombreIngles: "yellow" },
        { nombre: "rosa", nombreIngles: "pink" },
      ],
    };
  },
};
</script>

<style></style>
