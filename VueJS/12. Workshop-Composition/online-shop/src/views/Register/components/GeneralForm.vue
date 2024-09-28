<script setup>
import Password from 'primevue/password';
import Dropdown from 'primevue/dropdown';
import InputNumber from 'primevue/inputnumber';
import Calendar from 'primevue/calendar';
import InputText from 'primevue/inputtext';

import { computed, reactive } from 'vue';
import useVuelidate from '@vuelidate/core';
import { alphaNum, email, helpers, maxLength, minLength, numeric, required, sameAs } from '@vuelidate/validators';
import Button from 'primevue/button';
import FormItem from './FormItem.vue';

const props = defineProps({
  initialData: {
    type: Object,
    required: true,
    default: () => ({
      name: '',
      pass: '',
      confirmPass: '',
      phone: undefined,
      email: '',
      gender: '',
      dateOfBirth: '',
    }),
  },
});
const emit = defineEmits(['onSubmit']);
const fieldWrapperStyle = 'width: 100%;';
const inputStyle = { width: '100%' };
const options = ['Male', 'Female', 'Other'];

function hasTwoNames(value) {
  if (!value.includes(' '))
    return false;

  const names = value.split(' ').filter(Boolean);
  if (names.length !== 2)
    return false;

  return true;
}

function namesAreCapitalized(value) {
  const regex = /^([A-Z][a-z]*\s*)+$/;
  return regex.test(value);
}

const formData = reactive({ ...props.initialData });

const rules = computed(() => ({
  name: {
    required: helpers.withMessage('Custom required field msg', required),
    hasTwoNames: helpers.withMessage('Should contain two names separated by a space!', hasTwoNames),
    namesAreCapitalized: helpers.withMessage('Both names should start with a capital letter!', namesAreCapitalized),
  },
  pass: {
    required,
    alphaNum,
    minLength: minLength(3),
    maxLength: maxLength(16),
  },
  confirmPass: { required, sameAs: sameAs(formData.pass) },
  email: { required, email },
  phone: {
    required,
    numeric,
    minLength: minLength(9),
    maxLength: maxLength(10),
  },
  gender: {
    required,
  },
  dateOfBirth: {
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
  <FormItem :v$="v$" class="full-row" field="name" label="Name" required>
    <InputText id="name" v-model="formData.name" />
  </FormItem>

  <FormItem :v$="v$" field="pass" label="Password" required>
    <Password id="pass" v-model="formData.pass" toggle-mask :input-style="inputStyle" :style="fieldWrapperStyle" />
  </FormItem>

  <FormItem :v$="v$" field="confirmPass" label="Confirm password" required>
    <Password id="confirmPass" v-model="formData.confirmPass" toggle-mask :feedback="false" :input-style="inputStyle"
      :style="fieldWrapperStyle" />
  </FormItem>

  <FormItem :v$="v$" field="email" label="Email" required>
    <InputText id="email" v-model="formData.email" />
  </FormItem>

  <FormItem :v$="v$" field="phone" label="Phone number" required>
    <InputNumber id="phone" v-model="formData.phone" :format="false" />
  </FormItem>

  <FormItem :v$="v$" field="gender" label="Gender" required>
    <Dropdown id="gender" v-model="formData.gender" :options="options" />
  </FormItem>
  <FormItem :v$="v$" field="dateOfBirth" label="Date of birth" required>
    <Calendar id="dateOfBirth" v-model="formData.dateOfBirth" show-icon />
  </FormItem>
  <Button type="submit" label="Submit" icon="pi pi-send" class="full-row" />
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
