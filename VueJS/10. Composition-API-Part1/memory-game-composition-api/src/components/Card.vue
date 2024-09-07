<script setup>
const props = defineProps({
  card: {
    type: Object,
    required: true,
    default: () => ({
      idx: 0,
      type: '',
      img: '',
    }),
  },
  activeItems: {
    type: Array,
  },
  guessedItems: {
    type: Array,
  },
});

const emit = defineEmits(['onClick']);

const isActive = false;

function onSelect() {}
</script>

<template>
  <article class="card" @click="onSelect">
    <template v-if="isActive">
      <img :src="props.card.img" alt="card-face">
      <h2> {{ props.card.type }}</h2>
    </template>
    <img v-else src="https://cdn1.iconfinder.com/data/icons/graphorama-playing-cards-3/80/back-512.png" alt="card blue">
  </article>
</template>

<style scoped>
.card {
    margin: 0;
    text-align: center;
}
</style>
