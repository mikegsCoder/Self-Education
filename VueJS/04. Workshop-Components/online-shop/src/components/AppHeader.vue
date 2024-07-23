<script>
export default {
  props: {
    cartProducts: {
      type: Array,
      required: true,
      default: () => [],
    },
  },
  emits: ['onSelect'],
  methods: {
    onSelect(view) {
      this.$emit('onSelect', view);
    },
  },
};
</script>

<template>
<header>
  <nav>
    <ul>
      <li>
        <img
          src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTFZ7u6s3aD-NUTpnPn6t6dO5YTadA88J1l52BX5p6KDk7NOT2lsqV_&usqp=CAE&s"
          alt="logo">
      </li>
      <li>
        <p>Online Shop</p>
      </li>
    </ul>
    <ul>
      <li><a href="#" @click.prevent="onSelect('Home')">Home</a></li>
      <li><a href="#" @click.prevent="onSelect('Shop')">Shop</a></li>
      <li><a href="#" @click.prevent="onSelect('About')">About</a></li>
      <li><a href="#" @click.prevent="onSelect('Contacts')">Contacts</a></li>
      <li><a href="#" role="button" @click.prevent="onSelect('Cart')">
          Cart <span v-if="cartProducts.length">({{ cartProducts.length }})</span></a>
      </li>
    </ul>
  </nav>
</header>
</template>

<style scoped>
nav {
  padding: 0.25rem 3rem;
}

nav img {
  height: 2.5rem;
}
</style>
