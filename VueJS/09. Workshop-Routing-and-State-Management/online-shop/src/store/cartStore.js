import { defineStore } from 'pinia';

export const useCartStore = defineStore('cart', {
  state: () => ({
    products: [{ id: 41, quantity: 1 }],
  }),
  getters: {
    getProduct: (state) => {
      return productId => state.products.find(prod => prod.id === productId);
    },
  },
  actions: {
    addToCart(selectedId) {
      const productInCart = this.products.find(prod => prod.id === selectedId);
      if (!productInCart) {
        this.products.push({ id: selectedId, quantity: 1 });
      }
      else {
        productInCart.quantity += 1;
      }
    },
  },
});
