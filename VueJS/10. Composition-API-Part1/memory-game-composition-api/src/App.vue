<script setup>
import { computed, reactive, ref } from 'vue';
import { timeFormatter } from './helpers/formatTime';
import { shuffle } from './helpers/cardsShuffle';
import Card from './components/Card.vue';
import defaultCards from './mockData/cardsArray';

let interval = null;

const defaultTimer = ref(60000);
const timer = ref(0);
const selectedItem = ref([]);
const guessedItems = ref([]);
const game = reactive({
  isStarted: false,
  hasWon: false,
  hasLost: false,
});

function onStart() {
  game.isStarted = true;
  game.hasWon = false;
  game.hasLost = false;
  startGameTimer();
}

function onStop() {
  game.isStarted = false;
  clearInterval(interval);
  guessedItems.value = [];
  selectedItem.value = [];
}

function startGameTimer() {
  let seconds = 60000;
  timer.value = seconds;
  interval = setInterval(() => {
    seconds -= 1000;
    timer.value = seconds;
    if (seconds === 0)
      handleLostGame();
  }, 1000);
}

function handleLostGame() {
  game.hasLost = true;
  onStop();
}

const cards = computed(() => {
  if (game.isStarted)
    return shuffle(defaultCards);
  return defaultCards;
});
</script>

<template>
  <div class="container">
    <button v-if="!game.isStarted" @click="onStart">
      Start game
    </button>

    <template v-else>
      <span>{{ timeFormatter(timer) }}</span>
      <progress :value="`${timer}`" :max="`${defaultTimer}`" />

      <button v-if="game.isStarted" @click="onStop">
        Stop game
      </button>
    </template>
  </div>
</template>

<style scoped>
</style>
