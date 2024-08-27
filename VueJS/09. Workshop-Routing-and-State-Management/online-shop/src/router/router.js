import { createRouter, createWebHistory } from 'vue-router';

import Home from '../views/Home.vue';
import Shop from '../views/Shop/Shop.vue';
import About from '../views/About.vue';
import Contacts from '../views/Contacts.vue';
import Cart from '../views/Cart.vue';

const routes = [
  { path: '/', component: Home },
  { path: '/shop', component: Shop },
  { path: '/about', component: About },
  { path: '/contacts', component: Contacts },
  { path: '/cart', component: Cart },
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;
