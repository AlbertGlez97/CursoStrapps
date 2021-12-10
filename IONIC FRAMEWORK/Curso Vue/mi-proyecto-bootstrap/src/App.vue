<template>
  <div class="app">
    <div class="container">
      <div class="row">
        <Navegacion/>
      </div>
      <div class="row">
        <Contenido/>
      </div>
      <hr>
      <div>
        <p class="texto">
      Lorem ipsum dolor, sit amet consectetur adipisicing elit. Quaerat magnam
      aliquid minus temporibus perspiciatis provident obcaecati. Error aliquid
      natus quisquam velit dolorem quod.
    </p>
      </div>
    </div>
  </div>
</template>

<script>
// import HelloWorld from "./components/HelloWorld.vue";
import Navegacion from "./components/Navegacion.vue";
import Contenido from "./components/Contenido.vue";


export default {
  name: "App",
  components: {
    // HelloWorld,
    Navegacion,
    Contenido
  },
};
</script>

<style></style>
