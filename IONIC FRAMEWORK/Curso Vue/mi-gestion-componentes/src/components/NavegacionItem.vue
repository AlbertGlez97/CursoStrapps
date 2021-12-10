<template>
  <li class="nav-item">
      <!-- href es una propiedad de HTML, para Vues es "v-bind:href=''" -->
      <a class="nav-link" v-bind:href='navegacionData.url'>{{navegacionData.titulo}}</a>
  </li>
</template>

<script>
export default {
    name:"NavegacionItem",
    data(){
    },
    props:{
        navegacionData:Object
    }
}
</script>

<style>

</style>
