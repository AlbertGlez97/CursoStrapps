<template>
  <ion-page>
    <ion-header :translucent="true">
      <ion-toolbar>
        <ion-title>Card</ion-title>
      </ion-toolbar>
    </ion-header>

    <ion-content :fullscreen="true">
      <div>
        <ion-card>
          <ion-card-header>
            <ion-card-subtitle>Card Subtitle</ion-card-subtitle>
            <ion-card-title>Card Title</ion-card-title>
          </ion-card-header>

          <ion-card-content>
            Keep close to Nature's heart... and break clear away, once in
            awhile, and climb a mountain or spend a week in the woods. Wash your
            spirit clean.
          </ion-card-content>
        </ion-card>
      </div>
      <hr />
      <div>
        <ion-card>
          <ion-item>
            <ion-icon :icon="pin"></ion-icon>
            <ion-label>ion-item in a card, icon left, button right</ion-label>
            <ion-button fill="outline">View</ion-button>
          </ion-item>

          <ion-card-content>
            This is content, without any paragraph or header tags, within an
            ion-card-content element.
          </ion-card-content>
        </ion-card>
      </div>
      <hr />
      <div>
        <ion-card>
          <ion-item href="#" class="ion-activated">
            <ion-icon :icon="wifi"></ion-icon>
            <ion-label>Card Link Item 1 activated</ion-label>
          </ion-item>

          <ion-item href="#">
            <ion-icon :icon="wine"></ion-icon>
            <ion-label>Card Link Item 2</ion-label>
          </ion-item>

          <ion-item class="ion-activated">
            <ion-icon :icon="warning"></ion-icon>
            <ion-label>Card Button Item 1 activated</ion-label>
          </ion-item>

          <ion-item>
            <ion-icon :icon="walk"></ion-icon>
            <ion-label>Card Button Item 2</ion-label>
          </ion-item>
        </ion-card>
      </div>
    </ion-content>
  </ion-page>
</template>
<script>
import { IonCard, IonCardContent, IonCardHeader, IonCardSubtitle, IonCardTitle, IonIcon, IonItem, IonLabel } from '@ionic/vue';
import { defineComponent } from 'vue';

export default defineComponent({
  components: { IonCard, IonCardContent, IonCardHeader, IonCardSubtitle, IonCardTitle, IonIcon, IonItem, IonLabel }
});
</script>