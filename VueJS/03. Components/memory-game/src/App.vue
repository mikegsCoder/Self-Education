<script>
import Card from './components/Card.vue';

const defaultCards = [
  { idx: 1, type: 'Vue', img: 'https://upload.wikimedia.org/wikipedia/commons/9/95/Vue.js_Logo_2.svg' },
  { idx: 2, type: 'React', img: 'https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/React-icon.svg/512px-React-icon.svg.png' },
  { idx: 3, type: 'Vue', img: 'https://upload.wikimedia.org/wikipedia/commons/9/95/Vue.js_Logo_2.svg' },
  { idx: 4, type: 'React', img: 'https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/React-icon.svg/512px-React-icon.svg.png' },
  { idx: 5, type: 'Angular', img: 'https://upload.wikimedia.org/wikipedia/commons/thumb/c/cf/Angular_full_color_logo.svg/2048px-Angular_full_color_logo.svg.png' },
  { idx: 6, type: 'Angular', img: 'https://upload.wikimedia.org/wikipedia/commons/thumb/c/cf/Angular_full_color_logo.svg/2048px-Angular_full_color_logo.svg.png' },
  { idx: 7, type: 'Vite', img: 'https://upload.wikimedia.org/wikipedia/commons/thumb/f/f1/Vitejs-logo.svg/1039px-Vitejs-logo.svg.png' },
  { idx: 8, type: 'Vite', img: 'https://upload.wikimedia.org/wikipedia/commons/thumb/f/f1/Vitejs-logo.svg/1039px-Vitejs-logo.svg.png' },
];

let interval = null;

export default {
  components: {
    Card,
  },
  data() {
    return {
      difficulty: null,
      defaultTimer: 60000,
      timer: 0,
      selectedItem: [],
      guessedItems: [],
      isStarted: false,
      hasWon: false,
      hasLost: false,
    };
  },
  computed: {},
  watch: {},
  methods: {
    onStart() {
      this.isStarted = true;
      this.hasWon = false;
      this.hasLost = false;
      this.startGameTimer();
    },
    onStop() {
      this.isStarted = false;
      clearInterval(interval);
      this.guessedItems = [];
      this.selectedItem = [];
    },
    startGameTimer() {
      let seconds = 60000;
      this.timer = seconds;
      interval = setInterval(() => {
        seconds -= 1000;
        this.timer = seconds;
        if (seconds === 0) this.handleLostGame();
      }, 1000);
    },
    handleLostGame() {
      this.hasLost = true;
      this.onStop();
    },
    timeFormatter(seconds) {
      if (Number.isNaN(seconds) || seconds < 0) return '';
      const date = new Date(seconds);

      const formatter = new Intl.DateTimeFormat('en', {
        minute: '2-digit',
        second: '2-digit',
        timeZone: 'UTC',
      });

      return formatter.format(date);
    },
  },
};
</script>

<template>
  <div class="container">
    <button v-if="!isStarted" @click="onStart">
      Start game
    </button>

    <template v-else>
      <span>{{ timeFormatter(timer) }}</span>
      <progress :value="`${timer}`" :max="`${defaultTimer}`"></progress>

      <button v-if="isStarted" @click="onStop">
        Stop game
      </button>
    </template>
  </div>
  <div class="container">
    <p v-if="hasWon" class="container">
      ✨ Congratulations, you have won! ✨
    </p>

    <p v-if="hasLost" class="container">
      😥 I'm sorry, you have lost! 😥
    </p>
  </div>
</template>

<style scoped>
</style>
