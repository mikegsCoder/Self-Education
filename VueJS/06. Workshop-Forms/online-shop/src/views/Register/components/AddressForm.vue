<script>
import { useVuelidate } from '@vuelidate/core';
import { minLength, required, helpers, numeric } from '@vuelidate/validators';

import FormItem from './FormItem.vue';

export default {
	components: { FormItem },
	props: {
		initialData: {
			type: Object,
			required: true,
			default: () => ({
				address1: '',
				address2: '',
				city: '',
				zipCode: null,
			}),
		},
	},
	emits: ['onSubmit', 'onBack'],
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
				address1: {
					required: helpers.withMessage('Address Line 1 is required.', required),
					minLength: helpers.withMessage('Address Line 1 is required.', minLength(5)),
				},
				city: {
					required: helpers.withMessage('City is required.', required),
				},
				zipCode: {
					required: helpers.withMessage('ZIP Code is required.', required),
					numeric: helpers.withMessage('ZIP Code should contain only numbers.', numeric),
				},
			},
		};
	},
	methods: {
		async handleSubmit() {
			const isValid = await this.v$.$validate();
			console.log('Is form valid:', isValid);
			if (isValid) {
				this.$emit('onSubmit', this.formData);
			}
		},
	},
};
</script>

<template>
	<div>
		<h2>Step 2: Address Information</h2>

		<form action="" @submit.prevent="handleSubmit">
			<FormItem 
        v-model="formData.address1" 
        :v$="v$" 
        class="fullRow" 
        field="address1" 
        label="Address Line 1" 
        required 
      />

			<FormItem 
        v-model="formData.address2" 
        field="address2" 
        class="fullRow" 
        label="Address Line 2" 
      />

			<FormItem 
        v-model="formData.city" 
        :v$="v$" 
        field="city" 
        label="City" 
        required 
      />

			<FormItem 
        v-model="formData.zipCode" 
        :v$="v$" 
        field="zipCode" 
        label="ZIP Code" 
        required 
      />

			<button type="button" class="secondary" @click="$emit('onBack')">
				Go back
			</button>
			<button type="submit">
				Submit
			</button>
		</form>
	</div>
</template>

<style scoped>
</style>
