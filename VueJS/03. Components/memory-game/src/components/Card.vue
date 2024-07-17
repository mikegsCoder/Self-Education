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
  computed: {},
  methods: {},
};
</script>

<template>
</template>

<style scoped>
</style>
