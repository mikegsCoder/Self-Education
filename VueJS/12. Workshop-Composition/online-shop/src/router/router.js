import { createRouter, createWebHistory } from 'vue-router';

const Home = () => import('../views/Home.vue');

const routes = [
  { path: '/', component: Home },
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;
