import { createRouter, createWebHistory } from 'vue-router';

import Home from '../views/Home.vue';
import Product from '../views/Product.vue';
import Products from '../views/Products.vue';
import Directives from '../views/Directives.vue';
import NotFound from '../views/NotFound.vue';

import ProfileContainer from '../views/Profile/ProfileContainer.vue';

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
  {
    path: '/profile',
    component: ProfileContainer,
    children: [],
  },
  { path: '/:pathMatch(.*)*', name: 'NotFound', component: NotFound },
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;
