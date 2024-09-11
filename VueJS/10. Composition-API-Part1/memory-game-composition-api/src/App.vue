<script setup>
import { computed, reactive, ref, watch } from 'vue';
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

function handleSelect(idx, type) {
  if (!game.isStarted)
    return;
  if (selectedItem.value.length < 2)
    selectedItem.value.push({ idx, type });

  else if (selectedItem.value.length === 2)
    selectedItem.value = [{ idx, type }];
}

watch(selectedItem, (newVal) => {
  if (newVal.length === 2 && (newVal[0].type === newVal[1].type))
    guessedItems.value.push(newVal[0].type);
}, { deep: true });

watch(guessedItems, (newVal) => {
  if (cards.value.length / 2 === newVal.length) {
    game.hasWon = true;
    setTimeout(() => onStop(), 2000);
  }
}, { deep: true });
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

  <div class="container">
    <p v-if="game.hasWon" class="container">
      ✨ OH YES, you have won! ✨
    </p>

    <p v-if="game.hasLost" class="container">
      😥 OO NO, you have lost! 😥
    </p>
  </div>

  <div class="myGrid">
    <Card
      v-for="card in cards"
      :key="card.idx"
      :card="card"
      :active-items="selectedItem"
      :guessed-items="guessedItems"
      @on-click="handleSelect"
    />
  </div>
</template>

<style scoped>
</style>
