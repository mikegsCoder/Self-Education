<script setup>
import { getAllTodos } from '../dataProviders/todos';
import { ref } from 'vue';

const data = await getAllTodos();
const hasError = ref(false);
</script>

<template>
  <h1>Our TODOS</h1>
  <ul class="grid">
    <li v-for="todo in data" :key="todo.id">
      {{ todo.todo }} - {{ `${todo.completed}` }}
    </li>
  </ul>
  <h2 v-if="hasError">
    Oops, we ahve a problem!
  </h2>
</template>

<style>
.grid {
  display: grid;
  grid-template-columns: repeat(6, 1fr);
  padding: 0;
  margin: 0;
}

.grid li {
  list-style: none;
}
</style>
