<template>
  <ion-page>
    <!-- Default Checkbox -->
    <ion-checkbox></ion-checkbox>
    <!-- Checkboxes in a List -->
    <ion-list>
      <ion-item v-for="entry in form" :key="entry.val">
        <ion-label>{{ entry.val }}</ion-label>
        <ion-checkbox
          slot="end"
          @update:modelValue="entry.isChecked = $event"
          :modelValue="entry.isChecked">
        </ion-checkbox>
      </ion-item>
    </ion-list>

  </ion-page>
</template>

<script lang="ts">
import { IonCheckbox, IonItem, IonLabel, IonList } from "@ionic/vue";
import { defineComponent } from "vue";

export default defineComponent({
  components: { IonCheckbox, IonItem, IonLabel, IonList },
  setup() {
    const form = [
      { val: "Pepperoni", isChecked: true },
      { val: "Sausage", isChecked: false },
      { val: "Mushroom", isChecked: false },
    ];

    return { form };
  },
});
</script>


<style scoped>
</style>