<template>
  <ion-page>
    <ion-header :translucent="true">
      <ion-toolbar>
        <ion-title>ActionSheet</ion-title>
      </ion-toolbar>
    </ion-header>

    <ion-content :fullscreen="true">
      <ion-header collapse="condense">
        <ion-toolbar>
          <ion-title size="large">Blank</ion-title>
        </ion-toolbar>
      </ion-header>

      <div id="container">
        <ion-button @click="presentActionSheet">Show Action Sheet</ion-button>
      </div>
    </ion-content>
  </ion-page>
</template>

<script lang="ts">
import {
  IonContent,
  IonHeader,
  IonPage,
  IonTitle,
  IonToolbar,
  IonButton,
  actionSheetController,
} from "@ionic/vue";
import { defineComponent } from "vue";
import { caretForwardCircle, close, heart, trash, share } from "ionicons/icons";

export default defineComponent({
  name: "ActionSheet",
  components: {
    IonContent,
    IonHeader,
    IonPage,
    IonTitle,
    IonToolbar,
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
              console.log("Delete clicked");
            },
          },
          {
            text: "Share",
            icon: share,
            handler: () => {
              console.log("Share clicked");
            },
          },
          {
            text: "Play (open modal)",
            icon: caretForwardCircle,
            handler: () => {
              console.log("Play clicked");
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
  },
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

#container strong {
  font-size: 20px;
  line-height: 26px;
}

#container p {
  font-size: 16px;
  line-height: 22px;

  color: #8c8c8c;

  margin: 0;
}

#container a {
  text-decoration: none;
}
</style>