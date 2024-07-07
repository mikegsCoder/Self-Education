<script>
export default {
  data() {
    return {
      isVisible: false,
      isDisabled: false,
      count: 0,
      user: {
        name: 'Mihail',
        hobby: 'Electronics',
      },
      hobbies: ['Electronics', 'Travelling'],
    };
  },
  mounted() {
    console.log('My count is', this.count);
    this.changeMyName();
    this.changeMyHobby();
    this.changeCount();
  },
  methods: {
    changeMyName() {
      this.user.name = 'Mike';
    },
    changeMyHobby() {
      this.user.hobby = 'Photography';
    },
    changeCount() {
    //   this.count = 10;
      this.count += 1;
    },
    toggleVisibility() {
      this.isVisible = !this.isVisible;
      this.changeCount();
      console.log('My count is', this.count);
    },
  },
};
</script>

<template>
  <h1 :class="{ hasHoby: isVisible }">
    Hello, my name is {{ user.name }}
  </h1>
  <h2 v-if="isVisible">
    And my hobby is: {{ user.hobby }}
  </h2>
  <button :id="count" :disabled="isDisabled" @click="toggleVisibility">
    Toggle
  </button>
</template>

<style scoped>
.hasHoby {
  color: orange;
}
</style>
