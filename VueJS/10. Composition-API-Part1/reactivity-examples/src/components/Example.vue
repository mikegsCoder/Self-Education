<script setup>
import { computed, reactive, ref } from 'vue';
import AppButton from './AppButton.vue';

const username = ref('Mihail');
let userData = reactive({
  name: 'Mike',
  location: 'Varna',
  books: ['Lord of the rings', 'Manga', 'Harry Potter'],
});

function handleChange(event) {
  username.value = event.target.value;
  userData.name = event.target.value;
}

function addBook() {
  userData.books.push('New book');
}

function resetUser() {
  userData = {
    name: '',
    location: '',
    books: [],
  };
}

const numberOfBooks = computed(() => {
  return userData.books.length;
});

function onMyCustomBtn() {
  console.log('My custom button was clicked!');
}
</script>

<template>
  <div>
    <h1>Welcome, {{ username }}</h1>
    <input type="text" :value="username" @input="handleChange">

    <h2>I have {{ numberOfBooks }} books in my bag</h2>
    <ul>
      <li v-for="book in userData.books" :key="book">
        {{ book }}
      </li>
    </ul>

    <button @click="addBook">
      Add new book
    </button>

    <button @click="resetUser">
      Reset user
    </button>

    <AppButton :text="username" type="secondary" @on-click="onMyCustomBtn" />
  </div>
</template>

<style lang="scss" scoped>
</style>
