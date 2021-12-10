<template>
  <div>
    <h1>Mi web</h1>
    <p>
      Lorem ipsum dolor sit amet consectetur adipisicing elit. Iusto aut
      repellat dolores nihil distinctio praesentium dolore debitis repellendus
      harum culpa quam voluptatum, nam aspernatur suscipit odit est beatae illo
      doloremque vitae ad magnam impedit laudantium. Nulla quasi accusantium
      provident, maiores molestias libero nihil excepturi consectetur, nostrum
      totam ipsa, dignissimos voluptate doloremque recusandae adipisci natus
      beatae ullam hic quibusdam voluptatem eius.
    </p>

    <!-- Importacion de un subcomponente -->
    <!-- v-bind nos va a permitir enviar datos tanto dinamicos o estaticos -->
    <!-- <NavegacionItem v-bind:navegacionData="{titulo:'Inicio',url:'http://ejemplovue.js.com'}"/>
      <NavegacionItem v-bind:navegacionData="{titulo:'Acerca',url:'http://ejemplovue.js.com'}"/>
      <NavegacionItem v-bind:navegacionData="{titulo:'Noticias',url:'http://ejemplovue.js.com'}"/>
      <NavegacionItem v-bind:navegacionData="{titulo:'Tienda',url:'http://ejemplovue.js.com'}"/>
      <NavegacionItem v-bind:navegacionData="{titulo:'Contacto',url:'http://ejemplovue.js.com'}"/>
      <NavegacionItem v-bind:navegacionData="{titulo:'Ubicacion',url:'http://ejemplovue.js.com'}"/> -->
    <ul>
      <NavegacionItem v-bind:navegacionData="item" v-for="item in
      itemsDeNavegacion" :key="item.id"/>
    </ul>

    <Opcion1/>
    <Opcion2/>
    <Opcion3/>
  </div>
</template>

<script>
//Importar subcomponentes
import NavegacionItem from "./NavegacionItem.vue";
import Opcion1 from "./Opcion1.vue";
import Opcion2 from "./Opcion2.vue";
import Opcion3 from "./Opcion3.vue";

export default {
  name: "Contenido",
  //Importar subcomponentes
  components: {
    NavegacionItem,
    Opcion1,
    Opcion2,
    Opcion3
  },
  data() {
    return {
      itemsDeNavegacion: [
        { titulo: "Inicio", url: "/inicio" },
        { titulo: "Acerca", url: "/acercade" },
        { titulo: "Tienda", url: "/tienda" },
        { titulo: "Contacto", url: "/contacto" },
      ],
    };
  },
};
</script>

<style></style>
