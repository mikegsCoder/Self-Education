<script>
import { useVuelidate } from '@vuelidate/core';
import { helpers, required } from '@vuelidate/validators';

import FormItem from './FormItem.vue';

// custom validator for 2 names:
function hasTwoNames(value) {
  if (!value.includes(' '))
    return false;

  const names = value.split(' ').filter(Boolean);
  if (names.length !== 2)
    return false;

  return true;
}

// custom validator for capitalized names:
function namesAreCapitalized(value) {
  const regex = /^([A-Z][a-z]*\s*)+$/;
  return regex.test(value);
}

export default {
  components: { FormItem },
  props: {
    initialData: {
      type: Object,
      required: true,
      default: () => ({
        name: '',
      }),
    },
  },
  emits: ['onSubmit'],
  setup() {
    return { v$: useVuelidate() };
  },
  data() {
    return {
      formData: { ...this.initialData },
    };
  },
  validations() {
    return {
      formData: {
        name: {
          required: helpers.withMessage('Name is required.', required),
          hasTwoNames: helpers.withMessage('Should contain two names separated by a space.', hasTwoNames),
          namesAreCapitalized: helpers.withMessage('Both names should start with a capital letter.', namesAreCapitalized),
        },
      },
    };
  },
  methods: {
    async handleSubmit() {
      const isValid = await this.v$.$validate();
      console.log('Is form valid:', isValid);
      if (isValid) {
        // console.log(this.formData);
        this.$emit('onSubmit', this.formData);
      }
    },
  },
};
</script>

<template>
  <div>
    <h2>Step 1: General Information</h2>

    <form action="" @submit.prevent="handleSubmit">
      <FormItem
        v-model="formData.name"
        class="fullRow"
        :v$="v$"
        field="name"
        label="Name"
        required
      />

      <button type="submit" class="fullRow">
        Submit
      </button>
    </form>
  </div>
</template>

<style scoped>
</style>
