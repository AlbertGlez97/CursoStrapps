<template>
  <div class="card col-md-4">
      <div class="card-body">
          <h5 class="card-title">Opcion 1 ---- {{option}}</h5>
          <p class="card-text">Lorem ipsum, dolor sit amet consectetur adipisicing elit. Aspernatur, facilis pariatur! Fuga adipisci veritatis dignissimos numquam sunt laboriosam nesciunt sit dolor temporibus, est fugit corporis.</p>
        <!-- Cuando el usuario le de click al boton asiganrle a la data "option" un valor -->
          <button class="btn btn-primary" v-on:click="option='Me hizo click'">Opcion 1</button>
      </div>
  </div>
</template>

<script>
export default {
    name:"Opcion1",
    data(){
        return{
            option:"No me ah echo click"
        }
    }
}
</script>

<style>

</style>