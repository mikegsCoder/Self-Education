<script setup>
import Button from 'primevue/button';

const props = defineProps({
  categories: {
    type: Array,
    default: () => [],
  },
  activeItem: {
    type: String,
    required: true,
  },
});

const emit = defineEmits(['onSelect']);

function onSelect(selected) {
  const val = props.activeItem === selected ? '' : selected;
  emit('onSelect', val);
};
</script>

<template>
<div>
  <ul class="categories">
    <li v-for="category in props.categories" :key="category">
      <Button :severity="activeItem === category ? 'primary' : 'secondary'" :outlined="activeItem !== category"
        @click="onSelect(category.name.toLowerCase())">
        {{ category.name.toUpperCase() }}
      </Button>
    </li>
  </ul>
</div>
</template>

<style scoped>
.categories {
  display: flex;
  justify-content: center;
  flex-wrap: wrap;
  gap: 1rem;
}

.categories li {
  margin: 0;
  list-style: none;
}

.categories .btn {
  padding: 0.5rem 1rem;
  font-size: 1rem;
  margin: 0;
}
</style>
