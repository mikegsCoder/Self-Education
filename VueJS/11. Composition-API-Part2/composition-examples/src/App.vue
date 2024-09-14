<script setup>
import ComponentsTabs from './components/ComponentsTabs.vue';
import HelloWorld from './components/HelloWorld.vue';
import ListTodos from './components/ListTodos.vue';
import ListUsers from './components/ListUsers.vue';
</script>

<template>
  <ComponentsTabs />

  <Suspense>
    <ListTodos />
    <template #fallback>
      Loading...
    </template>
  </Suspense>
  
  <HelloWorld />

  <ListUsers />
</template>

<style></style>
