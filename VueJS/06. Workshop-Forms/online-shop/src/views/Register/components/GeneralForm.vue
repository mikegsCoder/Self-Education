<script>
import { useVuelidate } from '@vuelidate/core';
import { alphaNum, helpers, email, maxLength, minLength, required, sameAs } from '@vuelidate/validators';

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
        pass: '',
        confirmPass: '',
        email: '',
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
        pass: {
          required: helpers.withMessage('Password is required.', required),
          alphaNum: helpers.withMessage('Password must contain only letters and digits.', alphaNum),
          minLength: helpers.withMessage('Password should be atleast 3 characters long.', minLength(3)),
          maxLength: helpers.withMessage('Password should be atmost 16 characters long.', maxLength(16)),
        },
        confirmPass: { required, sameAs: helpers.withMessage('Passwords don\'t match.', sameAs(this.formData.pass)) },
        email: { 
            required: helpers.withMessage('Email is required.', required), 
            email: helpers.withMessage('Invalid email provided.', email)
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

      <FormItem
        :v$="v$"
        field="pass"
        label="Password"
        required
      >
        <input id="pass" v-model="formData.pass" type="password">
      </FormItem>

      <FormItem
        :v$="v$"
        field="confirmPass"
        label="Confirm password"
        required
      >
        <input id="confirmPass" v-model="formData.confirmPass" type="password">
      </FormItem>

      <FormItem
        v-model="formData.email"
        :v$="v$"
        field="email"
        label="Email"
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
