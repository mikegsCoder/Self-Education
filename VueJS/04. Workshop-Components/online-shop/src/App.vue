<script>
import AppHeader from './components/AppHeader.vue';
import AppFooter from './components/AppFooter.vue';
import Home from './views/Home.vue';

export default {
  components: {
    AppHeader,
    AppFooter,
    Home
  },
  data() {
    return {
      view: 'Home',
      cartProducts: [],
    };
  },
  methods: {},
};
</script>

<template>
</template>

<style scoped>
</style>
