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

function shuffle(initialArray) {
  const arr = structuredClone(initialArray);
  let currentIndex = arr.length;
  let randomIndex;

  // While there remain elements to shuffle.
  while (currentIndex > 0) {
    // Pick a remaining element.
    randomIndex = Math.floor(Math.random() * currentIndex);
    currentIndex--;

    // And swap it with the current element.
    [arr[currentIndex], arr[randomIndex]] = [
      arr[randomIndex],
      arr[currentIndex]
    ];
  }

  return arr;
}

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
  computed: {
    cards() {
      if (this.isStarted) return shuffle(defaultCards);
      return defaultCards;
    },
  },
  watch: {
    selectedItem: {
      handler(newVal) {
        if (newVal.length === 2 && (newVal[0].type === newVal[1].type))
          this.guessedItems.push(newVal[0].type);
      },
      deep: true,
    },
    guessedItems: {
      handler(newVal) {
        if (this.cards.length / 2 === newVal.length) {
          this.hasWon = true;
          setTimeout(() => this.onStop(), 2000);
        }
      },
      deep: true,
    },
  },
  methods: {
    handleSelect(idx, type) {
      if (!this.isStarted) return;

      if (this.selectedItem.length < 2) {
        this.selectedItem.push({ idx, type });
      } else if (this.selectedItem.length === 2) {
        this.selectedItem = [{ idx, type }];
      }
    },
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
  <div class="cardGrid">
    <Card
      v-for="card in cards"
      :key="card.idx"
      :type="card.type"
      :img="card.img"
      :idx="card.idx"
      :active-items="selectedItem"
      :guessed-items="guessedItems"
      @on-click="handleSelect"
    />
  </div>
</template>

<style scoped>
.cardGrid {
  max-width: 60em;
  margin: 2rem auto;
  display: grid;
  grid-template-columns: repeat(4, minmax(50px, 1fr));
  gap: 1rem;
}
.container {
  max-width: 400px;
  margin: 2rem auto;
  text-align: center;
}
</style>
