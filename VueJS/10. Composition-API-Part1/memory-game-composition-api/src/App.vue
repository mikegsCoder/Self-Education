<script setup>
import { reactive, ref } from 'vue';

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
</script>

<template>
  <div class="container">
    <button v-if="!game.isStarted" @click="onStart">
      Start game
    </button>

    <template v-else>
    </template>
  </div>
</template>

<style scoped>
</style>
