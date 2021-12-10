<template>
  <div>
    <h1>Mi web</h1>
    <p class="texto">
      Lorem ipsum dolor, sit amet consectetur adipisicing elit. Quaerat magnam
      aliquid minus temporibus perspiciatis provident obcaecati. Error aliquid
      natus quisquam velit dolorem quod.
    </p>
  </div>
</template>

<script>
export default {
    name:"Contenido"
};
</script>

<style>
/* Estos estilos se inyecta en la raiz de la aplicacion, de manera global */
.texto{
    color: cadetblue;
}
</style>

<style scoped>
/* Podemos hacer que sea un alcanze local, solo van a estar al alcanze de este componente  */
.texto{
    background-color: coral;
}

</style>