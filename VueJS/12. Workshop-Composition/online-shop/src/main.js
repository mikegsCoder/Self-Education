import { createApp } from 'vue';
import PrimeVue from 'primevue/config';
import { createPinia } from 'pinia';
import { useUserStore } from '../src/stores/userStore.js';
import App from './App.vue';
import router from './router/router';
import 'primevue/resources/themes/lara-light-green/theme.css';
import 'primeicons/primeicons.css';

const app = createApp(App);
const pinia = createPinia();
app.use(PrimeVue);
app.use(pinia);
app.use(router);

const userStore = useUserStore();
userStore.getPersistedProfile();
app.mount('#app');
