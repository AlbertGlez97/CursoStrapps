<template>
  <ion-page>
    <ion-header :translucent="true">
      <ion-toolbar>
        <ion-title>Checboxs</ion-title>
      </ion-toolbar>
    </ion-header>

    <ion-content :fullscreen="true">
      <div id="container">
        <!-- Default Checkbox -->
        <ion-checkbox></ion-checkbox>

        <br>
        <!-- Disabled Checkbox -->
        <ion-checkbox disabled="true"></ion-checkbox>

        <br>
        <!-- Checked Checkbox -->
        <ion-checkbox checked="false"></ion-checkbox>

        <br>
        <!-- Checkbox Colors -->
        <ion-checkbox color="primary">Primary</ion-checkbox>
        <ion-checkbox color="secondary">Secondary</ion-checkbox>
        <ion-checkbox color="danger">Danger</ion-checkbox>
        <ion-checkbox color="light">Light</ion-checkbox>
        <ion-checkbox color="dark">Dark</ion-checkbox>

        <br>
        <!-- Checkboxes in a List -->
       <!--  Iterar un arreglo de valores  -->

        <ion-button @click="agregar()">Agregar</ion-button>

        <ion-list>
          <ion-item v-for="entry in form" v-bind:key="entry">
            <ion-label>{{ entry.val }}</ion-label>
            <ion-checkbox
              @update:modelValue="entry.isChecked = $event"
              :modelValue="entry.isChecked"
            >
            </ion-checkbox>
          </ion-item>
        </ion-list>
      </div>
    </ion-content>
  </ion-page>
</template>

<script>
import { defineComponent } from 'vue';

export default defineComponent({
  components: { },
  // Representa el modelo
  data(){
      return {
          index: 3,
          form: [
            { val: 'Pepperoni', isChecked: true },
            { val: 'Sausage', isChecked: false },
            { val: 'Mushroom', isChecked: false }
          ],
      }
  },
  // Son los metodos disponibles para ser llamados 
  methods: {
      agregar: function(){
          this.PI;
          this.nombreFuncion();
          const descripcion = "Otro "+ this.index++;
          this.form.push({val: descripcion, isChecked: true})
      }
  },
  //Es un metodo que se ejecuta al iniciar el componete y retorna 
  //la configuracion
  setup() {
//     const form = [
//       { val: 'Pepperoni', isChecked: true },
//       { val: 'Sausage', isChecked: false },
//       { val: 'Mushroom', isChecked: false }
//     ];

//     return { form };
const PI = 3.1416;
const nombreFuncion = function(){
    console.log("Estamos ejecutando lo que hace la funcion nombreFuncion")
};

return {
    PI, nombreFuncion
};
 }
});
</script>


<style scoped>
#container {
  text-align: center;

  position: absolute;
  left: 0;
  right: 0;
  top: 50%;
  transform: translateY(-50%);
}
</style>
