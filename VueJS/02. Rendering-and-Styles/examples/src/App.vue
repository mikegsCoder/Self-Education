<script>
export default {
  data() {
    return {
      isDay: false,
    };
  },
  methods: {
  },
};
</script>

<template>
<div>
  <button @click="isDay = !isDay">
    Toggle
  </button>

  <h1 v-if="isDay">
    ☀️ It's sunny outside!
  </h1>
  <h1 v-else>
    🌑 It's dark outside!
  </h1>
</div>
</template>
