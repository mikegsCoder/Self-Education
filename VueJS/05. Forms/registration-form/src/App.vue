<script>
import { useVuelidate } from '@vuelidate/core';
import { email, required, between, helpers } from '@vuelidate/validators';

export default {
  setup() {
    return { v$: useVuelidate() };
  },
  data() {
    return {
      data: {
        fName: '',
      },
      formData: null,
    };
  },
  methods: {
    async onSubmit() {
      const isValid = await this.v$.$validate();
      console.log('isValid', isValid, this.v$);
      if (isValid) {
        this.formData = JSON.stringify(this.data, null, 4);
      }
    },
  },
  validations() {
    return {
      data: {
        fName: { required: helpers.withMessage('First name is required.', required) },
      },
    };
  },
};
</script>

<template>
<form class="form" action="" @submit.prevent="onSubmit">
  <div class="two-cols">
    <!-- firstName -->
    <div>
      <label for="fname">First name</label>
      <input id="fname" v-model="v$.data.fName.$model" type="text">
      <div v-for="error of v$.data.fName.$errors" :key="error.$uid" class="input-errors">
        <div class="error-msg">
          {{ error.$message }}
        </div>
      </div>
    </div>
  </div>

  <button>Submit</button>
</form>

<pre v-if="formData">
    <code>{{ formData }}</code>
  </pre>
</template>

<style></style>
