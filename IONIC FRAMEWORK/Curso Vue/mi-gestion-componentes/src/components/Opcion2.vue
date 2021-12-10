<template>
  <div class="card col-md-4">
      <div class="card-body">
          <h5 class="card-title">Opcion 2 ---- {{option}}</h5>
          <p class="card-text">{{texto}} Lorem ipsum, dolor sit amet consectetur adipisicing elit. Aspernatur, facilis pariatur! Fuga adipisci veritatis dignissimos numquam sunt laboriosam nesciunt sit dolor temporibus, est fugit corporis.</p>
        <!-- Cuando el usuario le de click al boton asiganrle a la data "option" un valor -->
          <button class="btn btn-primary" v-on:click="sumar">Opcion 1</button>
          <button class="btn btn-primary" v-on:click="letraEligida('a')">Opcion 2</button>
      </div>
  </div>
</template>

<script>
export default {
    name:"Opcion2",
    data(){
        return{
            option:"As click llama al metodo",
            texto:"Soy texto dentro de data"
        }
    },
    methods:{
        sumar: function(){
            //con This voy a poder encontrar el valor que esta en dat
            this.option= 5+ 5;
        },
        letraEligida: function(letra){
            this.texto = "SELECCIONASTE BUTTON " + letra ;
        }
    }
}
</script>

<style>

</style>