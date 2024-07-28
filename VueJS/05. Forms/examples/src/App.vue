<script>
export default {
  data() {
    return {
      name: '',
      age: null,
    };
  },
};
</script>

<template>
<h1>Input elements examples</h1>
<form action="" class="container">
  <div>
    <label for="name">Name</label>
    <input id="name" v-model="name" type="text">
  </div>
  <div>
    <label for="age">Age</label>
    <input id="age" v-model="age" type="number">
  </div>
</form>
</template>

<style scoped></style>