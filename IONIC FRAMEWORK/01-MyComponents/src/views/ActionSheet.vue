<template>
  <ion-page>
    <ion-content>
      <ion-button @click="presentActionSheet">Show Action Sheet</ion-button>
    </ion-content>
  </ion-page>
</template>


<script lang="ts">
import { IonPage, IonButton, actionSheetController } from "@ionic/vue";
import {
  caretForwardCircle,
  close,
  heart,
  trash,
  share,
} from "ionicons/icons";
import { defineComponent } from "vue";

export default defineComponent({
  components: {
    IonPage,
    IonButton,
  },

  methods: {
    async presentActionSheet() {
      const actionSheet = await actionSheetController.create({
        header: "Albums",
        cssClass: "my-custom-class",
        buttons: [
          {
            text: "Delete",
            role: "destructive",
            icon: trash,
            handler: () => {
            this.borrar();
            },
          },
          {
            text: "Share",
            icon: share,
            handler: () => {
            this.compartir();
            },
          },
          {
            text: "Play (open modal)",
            icon: caretForwardCircle,
            handler: () => {
              this.reproducir();
            },
          },
          {
            text: "Favorite",
            icon: heart,
            handler: () => {
              console.log("Favorite clicked");
            },
          },
          {
            text: "Cancel",
            icon: close,
            role: "cancel",
            handler: () => {
              console.log("Cancel clicked");
            },
          },
        ],
      });
      await actionSheet.present();

      const { role } = await actionSheet.onDidDismiss();
      console.log("onDidDismiss resolved with role", role);
    },
    borrar: function () {
      alert("Estoy borrando");
      console.log("Estoy borrando");
    },

    compartir: function () {
      alert("Estoy compartiendo");
      console.log("Estoy compartiendo");
    },

    reproducir: function () {
      alert("Estoy reproduciendo");
      console.log("Estoy reproduciendo");
    },
  },
});
</script>

<style scoped>
</style>
