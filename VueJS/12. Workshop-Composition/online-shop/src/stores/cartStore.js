import { defineStore } from 'pinia';
import { computed, ref } from 'vue';

export const useCartStore = defineStore('cart', () => {
  const products = ref([]);

  const getProduct = computed(() => productId => products.value.find(prod => prod.id === productId));

  function addToCart(selectedId) {
    const productInCart = products.value.find(prod => prod.id === selectedId);
    if (!productInCart) {
      products.value.push({ id: selectedId, quantity: 1 });
    }
    else {
      productInCart.quantity += 1;
    }
  };
  
  return {
    products,
    getProduct,
    addToCart
  };
});
