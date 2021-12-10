<template>
  <div class="card cold-md-4">
      <div class="card-body">
          <h5 class="card-title">Opcion 3</h5>
          <form action="">
              <p class="card-text">
                  Lorem ipsum dolor sit amet consectetur adipisicing elit. Optio ab rem voluptate similique illo sapiente aliquid repellat corrupti labore. Error id nobis deserunt eius non.
              </p>
              <div class="row">
                  <!-- Asignar un valor dentro de Vue -->
                  <input v-bind:value="entradaDeTexto">
              </div>
              <div class="row">
                  <boton href="#" class="btn btn-secondary" v-on:click="entradaDeTexto='NUEVO VALOR'">Opcion 3</boton>
              </div>
          </form>
      </div>
  </div>
</template>

<script>
export default {
    name:"Opcion3",
    data(){
        return{
            entradaDeTexto:"***Texto***"
        }
    }
}
</script>

<style>

</style>