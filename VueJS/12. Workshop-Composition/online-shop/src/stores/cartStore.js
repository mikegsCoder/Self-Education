import { defineStore } from 'pinia';
import { computed, ref } from 'vue';

export const useCartStore = defineStore('cart', () => {
  const products = ref([]);

  const getProduct = computed(() => productId => products.value.find(prod => prod.id === productId));

  return {
    products,
    getProduct,
  };
});
