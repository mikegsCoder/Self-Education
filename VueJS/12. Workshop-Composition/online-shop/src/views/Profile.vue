<script setup>
import { computed } from 'vue';
import Card from 'primevue/card';
import { useUserStore } from '../stores/userStore.js';

const profile = computed(() => useUserStore().profile);
</script>

<template>
<Card v-if="profile">
  <template #title>
    <h2>{{ profile.firstName }} {{ profile.lastName }}</h2>
  </template>
  <template #header>
    <img :src="profile.image" alt="">
  </template>

  <template #content>
    <p>
      <b>email: {{ profile.email }}</b>
    </p>
    <p>
      <b>Gender: {{ profile.gender }}</b>
    </p>
    <p>
      <b>Token: {{ profile.token }}</b>
    </p>
  </template>
</Card>
</template>

<style scoped>
</style>
