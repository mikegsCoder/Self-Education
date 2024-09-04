<script setup>
import { reactive, ref } from 'vue';
import AppButton from './AppButton.vue';

const username = ref('Mihail');
let userData = reactive({});

function handleChange(event) {
  username.value = event.target.value;
  userData.name = event.target.value;
}

function onMyCustomBtn() {
  console.log('My custom button was clicked!');
}
</script>

<template>
  <div>
    <h1>Welcome, {{ username }}</h1>
    <input type="text" :value="username" @input="handleChange">

    <AppButton :text="username" type="secondary" @on-click="onMyCustomBtn" />
  </div>
</template>

<style lang="scss" scoped>

</style>
