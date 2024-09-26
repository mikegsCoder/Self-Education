<script setup>
import { computed } from 'vue';
import Card from 'primevue/card';
import Button from 'primevue/button';
import { useCartStore } from '../../../stores/cartStore';
import { useUserStore } from '../../../stores/userStore';

const props = defineProps({
  product: {
    type: Object,
    required: true,
    default: () => ({
      id: -1,
      title: 'DEFAULT ITEM',
      description: 'DEFAULT ITEM',
      price: 0,
      discountPercentage: 0,
      rating: 0,
      stock: 0,
      brand: 'DEFAULT ITEM',
      category: 'groceries',
      thumbnail: 'https://cdn.dummyjson.com/products/images/groceries/Apple/thumbnail.png',
      images: [
        'https://cdn.dummyjson.com/products/images/groceries/Apple/1.png',
      ],
    }),
  },
});

const emit = defineEmits(['onAddToCart']);
const userStore = useUserStore();
const cartStore = useCartStore();

const isDisabled = computed(() => {
  const current = cartStore.getProduct(props.product.id);
  if (!current)
    return false;

  return current.quantity >= props.product.stock;
});

const isInFavourites = computed(() => {
  if (userStore.favouritesIDs.length > 0)
    return userStore.favouritesIDs.includes(props.product.id);
  return false;
});

function onFavouriteClick() {
  if (isInFavourites.value) {
    userStore.removeFavouriteProduct(props.product.id);
  }
  else {
    userStore.addFavouriteProduct(props.product.id);
  }
};
</script>

<template>
<Card>
  <template #header>
    <span v-if="isInFavourites" class="icon">❤️</span>
    <img :src="props.product.thumbnail" alt="img">
  </template>

  <template #title>
    <slot name="title">
      <h2>{{ props.product.title }}</h2>
    </slot>
  </template>
  <template #content>
    <p>
      {{ props.product.description }}
    </p>
    <p><b>Price</b>: {{ props.product.price }}$</p>
  </template>
  <template #footer>
    <Button class="secondary outline" label="Add to cart" icon="pi pi-shopping-cart"
      @click="emit('onAddToCart', props.product.id)" />
    <Button v-if="userStore.isAuthenticated" class="secondary outline" :disabled="isDisabled"
      :label="isInFavourites ? 'Remove from favourites' : 'Add to favourites'" severity="secondary"
      @click="onFavouriteClick" />
  </template>
</Card>
</template>

<style scoped>
.p-card {
  display: flex;
  flex-direction: column;
  position: relative;
  max-width: 25em;
  overflow: hidden;
}

.p-card img {
  width: 100%;
}

.p-card :deep(.p-card-footer) {
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
  align-items: center;
  gap: 1rem;
}

.p-card :deep(.p-card-body) {
  display: flex;
  flex-direction: column;
  flex-grow: 1;
}

.p-card :deep(.p-card-content) {
  flex-grow: 1;
}

.icon {
  position: absolute;
  top: 0.25rem;
  right: 0.25rem;
  color: red
}
</style>
