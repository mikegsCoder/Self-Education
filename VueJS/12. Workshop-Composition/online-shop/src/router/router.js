import { createRouter, createWebHistory } from 'vue-router';
import { useUserStore } from '../stores/userStore';

const Home = () => import('../views/Home.vue');
const Shop = () => import('../views/Shop/Shop.vue');
const About = () => import('../views/About.vue');
const Cart = () => import('../views/Cart.vue');
const Contacts = () => import('../views/Contacts.vue');
const Register = () => import('../views/Register/Register.vue');
const Login = () => import('../views/Login.vue');
const Profile = () => import('../views/Profile.vue');
const Favourites = () => import('../views/Favourites.vue');

function validateUser() {
  const userStore = useUserStore();
  return userStore.isAuthenticated ? userStore.isAuthenticated : { path: '/login' };
};

const routes = [
  { path: '/', component: Home },
  { path: '/shop', component: Shop },
  { path: '/about', component: About },
  { path: '/contacts', component: Contacts },
  { path: '/cart', component: Cart },
  { path: '/register', component: Register },
  { path: '/login', component: Login, beforeEnter: () => {
    const userStore = useUserStore();
    return userStore.isAuthenticated ? { path: '/profile' } : true;
  } },
  { path: '/profile', component: Profile, beforeEnter: validateUser },
  { path: '/favourites', component: Favourites, beforeEnter: validateUser },
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;
