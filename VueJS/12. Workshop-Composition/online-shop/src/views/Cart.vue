<script setup>
import { computed, onMounted, reactive, ref } from 'vue';
import { useCartStore } from '../stores/cartStore';
import { getProductById } from '../dataProviders/products';
import Loader from '../components/Loader.vue';

const isLoading = ref(true);
const productsInfo = reactive({});
const cartStore = useCartStore();

const products = computed(() => cartStore.products);
const totalSum = computed(() => {
  let sum = 0;
  products.value.forEach((product) => {
    sum += (productsInfo[product.id]?.price ?? 0) * product.quantity;
  });
  return sum;
});

onMounted();
</script>

<template>
  <h1 style="text-align: center;">
    Cart
  </h1>
  <Loader v-if="isLoading" />
  <div v-else class="container">
    <article>
      <table>
        <thead>
          <tr>
            <th>Product</th>
            <th>Description</th>
            <th>Quantity</th>
            <th>Price</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="product in products" :key="product.id">
            <td>
              <div class="img-wrapper">
                <img :src="productsInfo[product.id].thumbnail" alt="">
              </div>
            </td>
            <td>
              <p style="font-size: 1.25rem;">
                {{ productsInfo[product.id].title }}
              </p>
              <p style="font-size: 0.75rem;">
                Product price: {{ productsInfo[product.id].price }}$
              </p>
            </td>
            <td>
              <input
                type="number"
                :value="product.quantity"
                style="width: 5rem;"
                @input="cartStore.changeQuantity(product.id, $event)"
              >
            </td>
            <td class="price">
              {{ productsInfo[product.id].price * product.quantity }}$
            </td>
          </tr>
        </tbody>
        <tfoot>
          <tr>
            <td colspan="3">
              Total:
            </td>
            <td class="price">
              {{ totalSum }}$
            </td>
          </tr>
        </tfoot>
      </table>
    </article>
  </div>
</template>

<style scoped>
table {
  max-width: 720px;
  margin: 0 auto;
}

.p-datatable :deep(.p-datatable-footer) {
  text-align: right;
}

.img-wrapper {
  width: 4rem;
  height: 4rem;
  border-radius: 100%;
  overflow: hidden;
}

.img {
  width: 100%;
  height: 100%;
  object-fit: cover;
}
</style>
