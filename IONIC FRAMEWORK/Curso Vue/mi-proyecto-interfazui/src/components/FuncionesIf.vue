<template>
  <div>
    <hr />
    <h1>If condicionales</h1>
    <!-- Podemos usar v-show para ocultar informacion,pero a diferencia de v-if, no lo elimina, solo lo oculta -->
    <!-- El if remueve por completo el codigo sino cumple con la codicion -->
    <div v-if="mostrarBoton == true">
      Usuario autenticado <button>BOTON SECRETO</button>
    </div>
    <!-- Sino se cumple la condicion -->
    <div v-else-if="mostrarBoton ==false">
      Usuario no autenticado {{mostrarBoton}}
    </div>
    <!-- Sino se cumplieron las condiciones -->
    <div v-else>
      Error
    </div>
  </div>
</template>

<script>
export default {
  name: "FuncionesIf",
  data() {
    return {
      mostrarBoton: true,
    };
  },
};
</script>

<style></style>
