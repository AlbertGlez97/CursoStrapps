<template>
  <ion-page>
    <ion-content>
      <ion-button @click="presentAlert">Show Alert</ion-button>
      <ion-button @click="presentAlertMultipleButtons"
        >Show Alert (multiple buttons)</ion-button
      >
      <ion-button @click="presentAlertConfirm">Show Alert (confirm)</ion-button>
      <ion-button @click="presentAlertPrompt">Show Alert (prompt)</ion-button>
      <ion-button @click="presentAlertRadio">Show Alert (radio)</ion-button>
      <ion-button @click="presentAlertCheckbox"
        >Show Alert (checkbox)</ion-button
      >
    </ion-content>
  </ion-page>
</template>

<script lang="ts">
import { IonPage, IonContent, IonButton, alertController } from "@ionic/vue";
import { defineComponent } from "vue";

export default defineComponent({
  name: "Alert",
  components: {
    IonPage,
    IonContent,
    IonButton,
  },
  methods: {
    presentAlert: async function () {
      const alert = await alertController.create({
        cssClass: "my-custom-class",
        header: "Informacion incorrecta",
        message: "Tu usuario y contraseña son incorrectos",
        buttons: ["Aceptar"],
      });
      await alert.present();

      const { role } = await alert.onDidDismiss();
      console.log("onDidDismiss resolved with role", role);
    },
    presentAlertMultipleButtons: async function () {
      const alert = await alertController.create({
        cssClass: "my-custom-class",
        header: "Alerta",
        subHeader: "",
        message: "¿Esta seguro de realizar la acción?",
        buttons: ["Cancelar", "Abrir", "Borrar"],
      });
      return alert.present();
    },
    presentAlertConfirm: async function () {
      const alert = await alertController.create({
        cssClass: "my-custom-class",
        header: "Confirmar",
        message: "¿Estas seguro de eliminar el registro?",
        buttons: [
          {
            text: "No",
            role: "cancel",
            cssClass: "secondary",
            handler: (blah) => {
              console.log("Se cancela la acción");
            },
          },
          {
            text: "Si",
            handler: () => {
              this.eliminar();
            },
          },
        ],
      });
      return alert.present();
    },

    eliminar: function () {
      alert("Estoy eliminando");
    },

    presentAlertPrompt: async function () {
      const alert = await alertController.create({
        cssClass: "my-custom-class",
        header: "Prompt!",
        inputs: [
          {
            placeholder: "Placeholder 1",
          },
          {
            name: "name2",
            id: "name2-id",
            value: "hello",
            placeholder: "Placeholder 2",
          },
          {
            name: "name3",
            value: "http://ionicframework.com",
            type: "url",
            placeholder: "Favorite site ever",
          },
          // input date with min & max
          {
            name: "name4",
            type: "date",
            min: "2017-03-01",
            max: "2018-01-12",
          },
          // input date without min nor max
          {
            name: "name5",
            type: "date",
          },
          {
            name: "name6",
            type: "number",
            min: -5,
            max: 10,
          },
          {
            name: "name7",
            type: "number",
          },
          {
            name: "name8",
            type: "password",
            placeholder: "Advanced Attributes",
            cssClass: "specialClass",
            attributes: {
              maxlength: 4,
              inputmode: "decimal",
            },
          },
        ],
        buttons: [
          {
            text: "Cancel",
            role: "cancel",
            cssClass: "secondary",
            handler: () => {
              console.log("Confirm Cancel");
            },
          },
          {
            text: "Ok",
            handler: () => {
              console.log("Confirm Ok");
            },
          },
        ],
      });
      return alert.present();
    },
    presentAlertRadio: async function () {

      const alert = await alertController
        .create({
          cssClass: 'my-custom-class',
          header: 'Radio',
          inputs: [
            {
              type: 'radio',
              label: 'Radio 1',
              value: 'value1',
              handler: () => {
                console.log('Radio 1 selected');
              },
              checked: true,
            },
            {
              type: 'radio',
              label: 'Radio 2',
              value: 'value2',
              handler: () => {
                console.log('Radio 2 selected');
              }
            },
            {
              type: 'radio',
              label: 'Radio 3',
              value: 'value3',
              handler: () => {
                console.log('Radio 3 selected');
              }
            },
            {
              type: 'radio',
              label: 'Radio 4',
              value: 'value4',
              handler: () => {
                console.log('Radio 4 selected');
              }
            },
            {
              type: 'radio',
              label: 'Radio 5',
              value: 'value5',
              handler: () => {
                console.log('Radio 5 selected');
              }
            },
            {
              type: 'radio',
              label: 'Radio 6',
              value: 'value6',
              handler: () => {
                console.log('Radio 6 selected');
              }
            },
          ],
          buttons: [
            {
              text: 'Cancel',
              role: 'cancel',
              cssClass: 'secondary',
              handler: () => {
                console.log('Confirm Cancel')
              },
            },
            {
              text: 'Ok',
              handler: () => {
                console.log('Confirm Ok')
              },
            },
          ],
        });
      return alert.present();
    },
    presentAlertCheckbox: async function () {
const alert = await alertController
        .create({
          cssClass: 'my-custom-class',
          header: 'Checkbox',
          inputs: [
            {
              type: 'checkbox',
              label: 'Checkbox 1',
              value: 'value1',
              handler: () => {
                console.log('Checkbox 1 selected');
              },
              checked: true,
            },

            {
              type: 'checkbox',
              label: 'Checkbox 2',
              value: 'value2',
              handler: () => {
                console.log('Checkbox 2 selected');
              }
            },

            {
              type: 'checkbox',
              label: 'Checkbox 3',
              value: 'value3',
              handler: () => {
                console.log('Checkbox 3 selected');
              }
            },

            {
              type: 'checkbox',
              label: 'Checkbox 4',
              value: 'value4',
              handler: () => {
                console.log('Checkbox 4 selected');
              }
            },

            {
              type: 'checkbox',
              label: 'Checkbox 5',
              value: 'value5',
              handler: () => {
                console.log('Checkbox 5 selected');
              }
            },

            {
              type: 'checkbox',
              label: 'Checkbox 6',
              value: 'value6',
              handler: () => {
                console.log('Checkbox 6 selected');
              }
            },
          ],
          buttons: [
            {
              text: 'Cancel',
              role: 'cancel',
              cssClass: 'secondary',
              handler: () => {
                console.log('Confirm Cancel')
              },
            },
            {
              text: 'Ok',
              handler: () => {
                console.log('Confirm Ok')
              },
            },
          ],
        });
      return alert.present();
    },
  },
});
</script>

<style scoped>
</style>
