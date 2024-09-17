<script setup>
import AppHeader from './components/AppHeader.vue';
import AppFooter from './components/AppFooter.vue';
</script>

<template>
<AppHeader />
<main>
  <router-view />
</main>
<AppFooter />
</template>

<style scoped>
main {
  padding: 1rem 2rem;
}
</style>
