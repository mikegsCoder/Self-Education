import { createRouter, createWebHistory } from 'vue-router';
import { isUser, isGuest } from '../guards/guards';

import Home from '../views/Home.vue';
import Shop from '../views/Shop/Shop.vue';
import About from '../views/About.vue';
import Contacts from '../views/Contacts.vue';
import Cart from '../views/Cart.vue';
import Register from '../views/Register/Register.vue';

const routes = [
  { path: '/', component: Home },
  { path: '/shop', component: Shop },
  { path: '/about', component: About },
  { path: '/contacts', component: Contacts },
  { path: '/cart', component: Cart },
  { path: '/register', component: Register, beforeEnter: isGuest },
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;
