<script>
export default {
  data() {
    return {
      pages: [{
        url: '/',
        text: 'Home',
      }],
    };
  },
};
</script>

<template>
  <header>
    <nav>
      <ul>
        <li v-for="page in pages" :key="page.url">
          <router-link :to="page.url">
            {{ page.text }}
          </router-link>
        </li>
      </ul>
    </nav>
  </header>
  <router-view />

  <footer>
    <p>my footer</p>
  </footer>
</template>
