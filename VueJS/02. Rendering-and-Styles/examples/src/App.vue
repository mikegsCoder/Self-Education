<script>
export default {
  data() {
    return {
      isDay: false,
      weather: '',
    };
  },
  methods: {
    getWeather(weather) {
      switch (weather) {
        case 'cloudy':
          return '⛅ Couldy';
        case 'rainy':
          return '🌧️ Rainy';
        case 'stormy':
          return '🌩️ Stormy';
        default:
          return '☀️ Sunny';
      }
    },
  },
};
</script>

<template>
<div>
  <button @click="isDay = !isDay">
    Toggle
  </button>

  <h1 v-if="isDay">
    ☀️ It's sunny outside!
  </h1>
  <h1 v-else>
    🌑 It's dark outside!
  </h1>
</div>
<hr>
  <div>
    <div v-if="weather === 'cloudy'">
      ⛅ Couldy
    </div>

    <div v-else-if="weather === 'rainy'">
      🌧️ Rainy
    </div>

    <div v-else-if="weather === 'stormy'">
      🌩️ Stormy
    </div>

    <div v-else>
      ☀️ Sunny
    </div>

    <h2>Example with function</h2>
    <p>Today's weather is: {{ getWeather(weather) }}</p>
  </div>
</template>
