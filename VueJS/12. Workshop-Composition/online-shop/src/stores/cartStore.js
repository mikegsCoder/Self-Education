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
  
  function changeQuantity(productId, event) {
    const qty = Number(event.target.value) ?? 0;
    const productInCart = products.value.find(prod => prod.id === productId);
    if (!productInCart)
      return;

    if (qty > 0) {
      productInCart.quantity = qty;
    }
    else {
      products.value = products.value.filter(prod => prod.id !== productId);
    }
  };

  return {
    products,
    getProduct,
    addToCart,
    changeQuantity
  };
});
