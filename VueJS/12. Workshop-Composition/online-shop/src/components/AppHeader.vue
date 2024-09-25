<script setup>
import { ref } from 'vue';
import { RouterLink } from 'vue-router';
import Menubar from 'primevue/menubar';
import { useUserStore } from '../stores/userStore';

const userStore = useUserStore();
const items = ref([
  {
    label: 'Home',
    icon: 'pi pi-home',
    route: '/',
  },
  {
    label: 'About',
    icon: 'pi pi-info-circle',
    route: 'about',
  },
  {
    label: 'Contacts',
    icon: 'pi pi-phone',
    route: '/contacts',
  },
]);
</script>

<template>
<header>
  <Menubar :model="items">
    <template #start>
      <ul>
        <li>
          <img
            src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTFZ7u6s3aD-NUTpnPn6t6dO5YTadA88J1l52BX5p6KDk7NOT2lsqV_&usqp=CAE&s"
            alt="logo">
        </li>
      </ul>
    </template>
    <template #item="{ item, props }">
      <RouterLink v-if="item.route" v-slot="{ href, navigate }" :to="item.route" custom>
        <a :href="href" v-bind="props.action" @click="navigate">
          <span :class="item.icon" />
          <span class="ml-2">{{ item.label }}</span>
        </a>
      </RouterLink>
    </template>
  </Menubar>
</header>
</template>

<style scoped>
.p-menubar.p-component {
  justify-content: space-between;
}

.p-menubar .p-menubar-root-list>.p-menuitem:not(.p-highlight):not(.p-disabled)>.p-menuitem-content:hover {
  color: #4b5563;
  background-color: var(--primary-color);
}

img {
  height: 2rem;
}
</style>
