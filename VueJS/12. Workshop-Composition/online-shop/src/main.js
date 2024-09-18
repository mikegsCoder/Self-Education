import { createApp } from 'vue';
import PrimeVue from 'primevue/config';
import { createPinia } from 'pinia';
import App from './App.vue';
import router from './router/router';
import 'primevue/resources/themes/lara-light-green/theme.css';
import 'primeicons/primeicons.css';

const app = createApp(App);
const pinia = createPinia();
app.use(PrimeVue);
app.use(pinia);
app.use(router);

app.mount('#app');
