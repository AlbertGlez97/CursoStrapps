<template>
  <ion-page>
    <ion-header :translucent="true">
      <ion-toolbar>
        <ion-title>Ionicons</ion-title>
      </ion-toolbar>
    </ion-header>

    <ion-content :fullscreen="true">
      <div>
        <h1>Villancinco Ionic Vue</h1>
        <p>
          Pero <ion-icon :icon="eye"></ion-icon> como



          <ion-icon :icon="beer"></ion-icon> los
          <ion-icon :icon="fish"></ion-icon
          ><ion-icon :icon="fish"></ion-icon> en el
          <ion-icon :icon="boat"></ion-icon>,pero
          <ion-icon :icon="eye"></ion-icon> como
          <ion-icon :icon="beer"></ion-icon> por
          <ion-icon :icon="eye"></ion-icon> a <ion-icon :icon="sad"></ion-icon
          ><ion-icon :icon="sparkles"></ion-icon>, <br />
          <ion-icon :icon="beer"></ion-icon> y
          <ion-icon :icon="beer"></ion-icon> y
          <ion-icon :icon="gitCompareOutline"></ion-icon> a
          <ion-icon :icon="beer"> </ion-icon> los
          <ion-icon :icon="fish"></ion-icon
          ><ion-icon :icon="fish"> </ion-icon> en el
          <ion-icon :icon="boat"></ion-icon>por
          <ion-icon :icon="eye"> </ion-icon> a <ion-icon :icon="sad"></ion-icon
          ><ion-icon :icon="sparkles"></ion-icon>


          <ion-icon :icon="car"></ion-icon>

          
        </p>
      </div>
    </ion-content>
  </ion-page>
</template>

<script>
import { IonIcon } from "@ionic/vue";
import { defineComponent } from "vue";

import {
  eye,
  beer,
  fish,
  boat,
  gitCompareOutline,
  sparkles,
  sad,
  car
} from "ionicons/icons";



export default defineComponent({
  components: {
    IonIcon,
  },
  setup() {
    return {
      eye,
      beer,
      fish,
      boat,
      gitCompareOutline,
      sparkles,
      sad,
      car
    };
  },
});
</script>

<style>
    h1{
        font-size: 50px;
    }
    p{
        font-size: 30px;
        font-weight: bold;
    }

    ion-icon{
        color: darkblue;
    }
</style>
