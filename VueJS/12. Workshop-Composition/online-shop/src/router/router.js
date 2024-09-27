import { createRouter, createWebHistory } from 'vue-router';

const Home = () => import('../views/Home.vue');
const Shop = () => import('../views/Shop/Shop.vue');
const About = () => import('../views/About.vue');
const Contacts = () => import('../views/Contacts.vue');

const routes = [
  { path: '/', component: Home },
  { path: '/shop', component: Shop },
  { path: '/about', component: About },
  { path: '/contacts', component: Contacts },
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;
