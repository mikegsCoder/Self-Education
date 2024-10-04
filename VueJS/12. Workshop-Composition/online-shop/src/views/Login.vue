<script setup>
import Password from 'primevue/password';
import InputText from 'primevue/inputtext';
import Card from 'primevue/card';
import Button from 'primevue/button';
import Message from 'primevue/message';

import { useRouter } from 'vue-router';
import { reactive, ref } from 'vue';
import { loginUser } from '../dataProviders/auth';
import { useUserStore } from '../stores/userStore';

const router = useRouter();
const userStore = useUserStore();

const isLoading = ref(false);
const user = reactive({
  username: '',
  password: '',
});

async function onSubmit() {
  isLoading.value = true;
  const userData = await loginUser(user);
  if (userData) {
    userStore.setProfile(userData);
    router.push('/profile');
  }
  isLoading.value = false;
}
</script>

<template>
  <div class="wrapper">
    <Message :closable="false" severity="success">
      <h1>Login</h1>
      <h3>Username: emilys </h3>
      <h3>password: emilyspass</h3>
    </Message>
    <Card>
      <template #content>
        <form @submit.prevent="onSubmit">
          <span class="p-float-label">
            <InputText id="username" v-model="user.username" />
            <label for="username">Username</label>
          </span>

          <span class="p-float-label">
            <Password
              v-model="user.password"
              input-id="password"
              toggle-mask
              :feedback="false"
              :disabled="isLoading"
            />
            <label for="password">Password</label>
          </span>

          <Button
            type="submit"
            icon="pi pi-send"
            label="Submit"
            :loading="isLoading"
            :disabled="isLoading"
          />
        </form>
      </template>
    </Card>
  </div>
</template>

<style scoped>
form {
  display: flex;
  flex-direction: column;
  align-items: flex-start;
  gap: 2rem;
}

.wrapper {
  max-width: 40em;
  margin: 0 auto;
}
</style>
