import { createRouter, createWebHistory } from '@ionic/vue-router';
import { RouteRecordRaw } from 'vue-router';
import Home from '../views/Home.vue'
import ActionSheet from '../views/ActionSheet.vue'
import Checkbox from '../views/Checkbox.vue'

const routes: Array<RouteRecordRaw> = [
  {
    path: '/',
    redirect: '/home'
  },
  {
    path: '/home',
    name: 'Home',
    component: Home
  },
  {
    path: '/ActionSheet',
    name: 'ActionSheet',
    component: ActionSheet
  },
  {
    path: '/Checkbox',
    name: 'Checkbox',
    component: Checkbox
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
