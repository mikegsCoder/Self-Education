<script>
import { useVuelidate } from '@vuelidate/core';
import GeneralForm from './components/GeneralForm.vue';

export default {
  components: { GeneralForm },
  setup() {
    return { v$: useVuelidate() };
  },
  data() {
    return {
      activeForm: 'general',
      data: {
        general: {
          name: '',
          pass: '',
          confirmPass: '',
          phone: 0,
          email: '',
          gender: '',
          dateOfBirth: '',
        },
      },
    };
  },
  methods: {
    async onGeneralSubmit(generalData) {
      const isValid = await this.v$.$validate();
      if (isValid) {
        // this.activeForm = 'address';
        this.data.general = { ...generalData };
      }
    },
    async onSubmit(addressData) {},
    onBack() {
      this.activeForm = 'general';
    },
  },
};
</script>

<template>
  <GeneralForm 
    v-if="activeForm === 'general'" 
		:initial-data="data.general" 
		@onSubmit="onGeneralSubmit" 
	/>
</template>
