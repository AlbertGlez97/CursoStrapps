<template>
  <ul class="nav">
    <li class="nav-item" v-bind:style="{backgroundColor:colorRandom, border:'solid 3px yellow'}">
        <!-- Esta directiva "v-bind" permite enlazar (bindear) una variable de Vue con un atributo específico de una etiqueta HTM -->
        <!-- Anade en la etiqueta a , la clase active solo si su propiedad es True -->
      <a class="nav-link" v-bind:class="{active : mostrarActivo}">Active</a>
    </li>
    <li class="nav-item">
      <a class="nav-link">Link</a>
    </li>
    <li class="nav-item">
      <a class="nav-link">Link</a>
    </li>
    <li class="nav-item">
      <a class="nav-link disabled">Disabled</a>
    </li>
  </ul>
</template>

<script>
export default {
  name: "Navegacion",
  data() {
    return {
      mostrarActivo: true,
      colorRandom:'#'+ Math.floor(Math.random()*6777215).toString(16)
    };
  },
};
</script>

<style>
.active {
    font-weight: bold;
}
</style>
