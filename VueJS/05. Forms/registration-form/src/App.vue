<script>
import { useVuelidate } from '@vuelidate/core';
import { email, required, between, helpers } from '@vuelidate/validators';

// custom validator for skills:
const validateSkills = (value) => value.length > 0;

export default {
  setup() {
    return { v$: useVuelidate() };
  },
  data() {
    return {
      data: {
        fName: '',
        lName: '',
        email: '',
        age: 0,
        skills: [],
        gender: '',
        country: '',
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
        lName: { required: helpers.withMessage('Last name is required.', required) },
        email: {
          required: helpers.withMessage('Email is required.', required),
          email: helpers.withMessage('Invalid email provided.', email)
        },
        age: { betweenValue: helpers.withMessage('Age must be between 1 and 100.', between(1, 100)) },
        skills: { validateSkills: helpers.withMessage('Skills are required.', validateSkills) },
        gender: { required: helpers.withMessage('Gender is required.', required) },
        country: { required: helpers.withMessage('Please select your country.', required) }
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
      <!-- lastName -->
      <div>
        <label for="lname">Last name</label>
        <input id="lname" v-model="v$.data.lName.$model" type="text">
        <div v-for="error of v$.data.lName.$errors" :key="error.$uid" class="input-errors">
          <div class="error-msg">
            {{ error.$message }}
          </div>
        </div>
      </div>
    </div>
    <!-- email -->
    <div>
      <label for="email">Email</label>
      <input id="email" v-model="v$.data.email.$model" type="email">
      <div v-for="error of v$.data.email.$errors" :key="error.$uid" class="input-errors">
        <div class="error-msg">
          {{ error.$message }}
        </div>
      </div>
    </div>
    <!-- age -->
    <div>
      <label for="age">Age</label>
      <input id="age" v-model="v$.data.age.$model" type="number">
      <div v-for="error of v$.data.age.$errors" :key="error.$uid" class="input-errors">
        <div class="error-msg">
          {{ error.$message }}
        </div>
      </div>
    </div>
    <!-- skills -->
    <div>
      <p>Skillset</p>
      <label>
        <input v-model="data.skills" type="checkbox" value="webDevelopment">
        Web Development
      </label>
      <label>
        <input v-model="data.skills" type="checkbox" value="graphicDesign">
        Graphic Design
      </label>
      <label>
        <input v-model="data.skills" type="checkbox" value="projectManagement">
        Project Management</label>
      <label>
        <input v-model="data.skills" type="checkbox" value="communication">
        Communication
      </label>
      <div v-for="error of v$.data.skills.$errors" :key="error.$uid" class="input-errors">
        <div class="error-msg">
          {{ error.$message }}
        </div>
      </div>
    </div>
    <!-- gender -->
    <div>
      <p>Gender</p>
      <label>
        <input v-model="data.gender" type="radio" value="male">
        Male
      </label>
      <label>
        <input v-model="data.gender" type="radio" value="female"> Female
      </label>
      <label>
        <input v-model="data.gender" type="radio" value="other"> Other</label>
      <div v-for="error of v$.data.gender.$errors" :key="error.$uid" class="input-errors">
        <div class="error-msg">
          {{ error.$message }}
        </div>
      </div>
    </div>
    <!-- country -->
    <div>
      <label for="country">Country</label>
      <select id="country" v-model="data.country">
        <option disabled value="">
          Select
        </option>
        <option value="bulgaria">
          Bulgaria
        </option>
        <option value="canada">
          Canada
        </option>
        <option value="uk">
          United Kingdom
        </option>
        <option value="australia">
          Australia
        </option>
        <option value="germany">
          Germany
        </option>
      </select>
      <div v-for="error of v$.data.country.$errors" :key="error.$uid" class="input-errors">
        <div class="error-msg">
          {{ error.$message }}
        </div>
      </div>
    </div>

    <button>Submit</button>
  </form>

  <pre v-if="formData">
    <code>{{ formData }}</code>
  </pre>
</template>

<style>
.form {
  max-width: 520px;
  margin: 3rem auto;
}

.error-msg {
  color: red;
  font-weight: 500;
}
</style>
