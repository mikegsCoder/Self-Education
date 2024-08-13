import { createRouter, createWebHistory } from 'vue-router';
import Home from '../views/Home.vue';
import Directives from '../views/Directives.vue';
import NotFound from '../views/NotFound.vue';

const routes = [
  {
    path: '/',
    component: Home,
  },
  {
    path: '/directives',
    component: Directives,
  },
  { path: '/:pathMatch(.*)*', name: 'NotFound', component: NotFound },
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;
