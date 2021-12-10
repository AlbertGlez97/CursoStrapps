import { createRouter, createWebHistory } from '@ionic/vue-router';
import { RouteRecordRaw } from 'vue-router';
import Home from '../views/Home.vue'
import ActionSheet from '../views/ActionSheet.vue'
import Alert from '../views/Alert.vue'
import Badge from '../views/Badge.vue'
import Button from '../views/Button.vue'
import Card from '../views/Card.vue'
import Checboxs from '../views/Checboxs.vue'
import Ionchip from '../views/Ionchip.vue'
import Ioncontent from '../views/Ioncontent.vue'
import Iondatetime from '../views/Iondatetime.vue'

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
    path: '/Alert',
    name: 'Alert',
    component: Alert
  },
  {
    path: '/Badge',
    name: 'Badge',
    component: Badge
  },
  {
    path: '/Button',
    name: 'Button',
    component: Button
  },
  {
    path: '/Card',
    name: 'Card',
    component: Card
  },
  {
    path: '/Checboxs',
    name: 'Checboxs',
    component: Checboxs
  },
  {
    path: '/Ionchip',
    name: 'Ionchip',
    component: Ionchip
  },
  {
    path: '/Ioncontent',
    name: 'Ioncontent',
    component: Ioncontent
  },
  {
    path: '/Iondatetime',
    name: 'Iondatetime',
    component: Iondatetime
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
