<script setup>
import { computed, reactive } from 'vue';
import { useVuelidate } from '@vuelidate/core';
import { minLength, required } from '@vuelidate/validators';
import InputText from 'primevue/inputtext';
import Button from 'primevue/button';
import FormItem from './FormItem.vue';

const props = defineProps({
  initialData: {
    type: Object,
    required: true,
    default: () => ({
      address1: '',
      address2: '',
      city: '',
    }),
  },
});

const emit = defineEmits(['onSubmit', 'onBack']);

const formData = reactive({ ...props.initialData });

const rules = computed(() => ({
  address1: {
    required,
    minLength: minLength(5),
  },
  city: {
    required,
  },
}));

const v$ = useVuelidate(rules, formData);

async function handleSubmit() {
  const isValid = await v$.value.$validate();
  if (isValid) {
    emit('onSubmit', formData);
  }
};
</script>

<template>
<form action="" @submit.prevent="handleSubmit">
  <FormItem :v$="v$" class="full-row" field="address1" label="Address Line 1" required>
    <InputText id="address1" v-model="formData.address1" />
  </FormItem>
  <FormItem field="address2" class="full-row" label="Address Line 2">
    <InputText id="address2" v-model="formData.address2" />
  </FormItem>
  <FormItem :v$="v$" field="city" label="City" required>
    <InputText id="city" v-model="formData.city" />
  </FormItem>
  <Button type="button" label=" Go back" severity="secondary" icon="pi pi-arrow-left" @click="$emit('onBack')" />
  <Button type="submit" icon="pi pi-send" label="Submit" />
</form>
</template>

<style scoped>
form {
  display: grid;
  grid-template-columns: repeat(2, 1fr);
  gap: 2rem;
}

form .full-row {
  grid-column: 1 / 3;
}

form * {
  width: 100%;
}
</style>
