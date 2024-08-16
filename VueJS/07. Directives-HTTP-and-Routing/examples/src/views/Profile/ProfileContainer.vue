<script>
export default {
  data() {
    return {
      pages: [
        {
          url: 'my-profile',
          text: 'My Profile',
        },
        {
          url: 'change-pass',
          text: 'Change Password',
        },
      ],
    };
  },
};
</script>

<template>
  <h1>profile container</h1>
  <ul>
    <li v-for="page in pages" :key="page.url">
      <router-link :to="`${/profile/}` + page.url">
        {{ page.text }}
      </router-link>
    </li>
  </ul>
  <router-view />
</template>

<style lang="scss" scoped></style>
