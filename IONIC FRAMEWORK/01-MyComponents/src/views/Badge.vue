<template>
  <ion-page>
    <ion-header>
      <ion-toolbar>
        <ion-title>Badge</ion-title>
      </ion-toolbar>
    </ion-header>
    <ion-content>
      <ion-list>
        <ion-list-header>Badges</ion-list-header>
        <ion-item>
          <ion-label>Followers</ion-label>
          <ion-badge slot="end">{{ followers }}k</ion-badge>
        </ion-item>
        <ion-item>
          <ion-label>Likes</ion-label>
          <ion-badge color="secondary" slot="end">{{ likes }}k</ion-badge>
        </ion-item>
        <ion-item>
          <ion-label>Stars</ion-label>
          <ion-badge color="tertiary" slot="end">{{ stars }}k</ion-badge>
        </ion-item>
        <ion-item>
          <ion-label>Completed</ion-label>
          <ion-badge color="success" slot="end">{{ completed }}</ion-badge>
        </ion-item>
        <ion-item>
          <ion-label>Warnings</ion-label>
          <ion-badge color="warning" slot="end">{{ warnings }}</ion-badge>
        </ion-item>
        <ion-item>
          <ion-label>Notifications</ion-label>
          <ion-badge color="danger" slot="end">{{ notification }}</ion-badge>
        </ion-item>
        <ion-item>
          <ion-label>Unread</ion-label>
          <ion-badge color="light" slot="end">{{ unread }}</ion-badge>
        </ion-item>
        <ion-item>
          <ion-label>Drafts</ion-label>
          <ion-badge color="medium" slot="end">{{ drafs }}</ion-badge>
        </ion-item>
        <ion-item>
          <ion-label>Deleted</ion-label>
          <ion-badge color="dark" slot="end">{{ deleted }}</ion-badge>
        </ion-item>
      </ion-list>

      <ion-button @click="() => router.push('/Home')"> Ir a Home </ion-button>
    </ion-content>
  </ion-page>
</template>

<script lang="ts">
import {
  IonPage,
  IonContent,
  IonBadge,
  IonList,
  IonListHeader,
  IonItem,
  IonLabel,
} from "@ionic/vue";
import { defineComponent } from "vue";
import { useRoute, useRouter} from "vue-router";

export default defineComponent({
  components: {
    IonPage,
    IonContent,
    IonBadge,
    IonList,
    IonListHeader,
    IonItem,
    IonLabel,
  },
  data() {
    return {
      followers: 10,
      likes: 20,
      stars: 30,
      completed: 40,
      warnings: 50,
      notification: 60,
      unread: 70,
      drafs: 80,
      deleted: 90,
    };
  },

  setup() {
    const router = useRouter();
    return { router }
  },

  ionViewDidEnter() {
    console.log('ESTAMOS PROBANDO');
    this.cargarBadges();
  },

  methods: {
    agregarFollowers: function () {
      this.followers++;
    },

    cargarBadges: function () {
   
       const requestOptions = {
         method: "GET",
       };

       fetch("https://localhost:5001/Badges", requestOptions)
         .then((response) => response.json())
         .then((result) => {
           this.followers = result.followers;
           this.likes = result.likes;
           this.stars = result.stars;
           this.completed = result.completed;
           this.warnings = result.warnings;
           this.notification = result.notification;
           this.unread = result.unread;
           this.drafs = result.drafs;
           this.deleted = result.deleted;
         })
         .catch((error) => console.log("error", error));
    },
  },
});
</script>
