<script setup>
import { computed, onMounted, ref } from 'vue';
import Card from 'primevue/card';
import { getAllProducts } from '../../dataProviders/products';
import { getAllCategories } from '../../dataProviders/categories';
import { useCartStore } from '../../stores/cartStore';
import Loader from '../../components/Loader.vue';
import Filters from './components/Filters.vue';
import ProductCard from './components/ProductCard.vue';

const selectedFilter = ref('');
const products = ref([]);
const categories = ref([]);
const isLoading = ref(true);
const cartStore = useCartStore();

const displayProducts = computed(() => {
  if (selectedFilter.value === '')
    return products.value;
  return products.value.filter(product => product.category === selectedFilter.value);
});

onMounted(async () => {
  const promises = await Promise.all([getAllProducts(), getAllCategories()]);
  products.value = promises[0].products;
  categories.value = promises[1];
  isLoading.value = false;
});

function onFilterSelect(selected) {
  selectedFilter.value = selected;
};
</script>

<template>
<Card>
  <template #title>
    <h2>Shop Our Collections</h2>
  </template>
  <template #content>
    <p>
      From casual wear to formal attire, we have something for every occasion. Browse through our diverse range of
      products and find the perfect outfit that suits your style.
    </p>
  </template>
</Card>
<Filters :categories="categories" :active-item="selectedFilter" @on-select="onFilterSelect" />
<Loader v-if="isLoading" />
<div v-else class="products">
  <ProductCard v-for="product in displayProducts" :key="`products-${product.id}`" :product="product"
    @on-add-to-cart="cartStore.addToCart">
    <template #title>
      <h2 class="title">
        {{ product.title }}
      </h2>
    </template>
  </ProductCard>
</div>
</template>

<style scoped>
.products {
  display: grid;
  grid-template-columns: repeat(var(--product-cols, 1), 1fr);
  gap: 1rem;
}

@media screen and (min-width: 560px) {
  .products {
    --product-cols: 2;
  }
}

@media screen and (min-width: 768px) {
  .products {
    --product-cols: 3;
  }
}

@media screen and (min-width: 1024px) {
  .products {
    --product-cols: 4;
  }
}
</style>
