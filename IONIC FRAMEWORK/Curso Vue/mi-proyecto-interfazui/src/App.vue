<template>
  <div id="app">
    <!-- Utilizar nuestro  componente -->
    <MiComponente></MiComponente>
    <DespliegueArreglo></DespliegueArreglo>
    <FuncionesIf></FuncionesIf>
  </div>
</template>

<script>
//import HelloWorld from './components/HelloWorld.vue'
// Importar nuestro nuevo componente 
import MiComponente from './components/MiComponente.vue'
import DespliegueArreglo from './components/DespliegueArreglo.vue'
import FuncionesIf from './components/FuncionesIf.vue'

export default {
  name: 'App',
  components: {
    //HelloWorld,
    //Darle acceso a nuestro nuevoComponente
    MiComponente,
    DespliegueArreglo,
    FuncionesIf
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
