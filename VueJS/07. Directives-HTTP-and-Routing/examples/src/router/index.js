import { createRouter, createWebHistory } from 'vue-router';
import Home from '../views/Home.vue';
import Product from '../views/Product.vue';
import Products from '../views/Products.vue';
import Directives from '../views/Directives.vue';
import NotFound from '../views/NotFound.vue';

const routes = [
  {
    path: '/',
    component: Home,
  },
  {
    path: '/products',
    component: Products,
  },
  {
    path: '/products/:id',
    name: 'singleProduct',
    component: Product,
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
