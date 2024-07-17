<script>
export default {
  props: {
    img: {
      type: String,
      required: true,
    },
    type: {
      type: String,
      required: true,
    },
    idx: {
      type: Number,
      required: true,
    },
    activeItems: {
      type: Array,
    },
    guessedItems: {
      type: Array,
    },
  },
  emits: ['onClick'],
  computed: {
    isActive() {},
  },
  methods: {
    onSelect() {},
  },
};
</script>

<template>
  <article class="card" @click="onSelect">
    <template v-if="isActive">
      <img :src="img" alt="card-face">
      <h2> {{ type }}</h2>
    </template>
    <img v-else src="https://cdn1.iconfinder.com/data/icons/graphorama-playing-cards-3/80/back-512.png" alt="">
  </article>
</template>

<style scoped>
</style>
