<script setup>
import { computed } from 'vue';
import { useUserStore } from '../stores/userStore';

const favouritesIDs = computed(() => useUserStore().favouritesIDs);
</script>

<template>
<h1>My Favourites</h1>
<ul v-if="favouritesIDs">
  <li v-for="id in favouritesIDs" :key="id">
    product {{ id }}
  </li>
</ul>
</template>

<style scoped>
</style>
