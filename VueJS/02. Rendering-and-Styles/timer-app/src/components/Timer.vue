<script>
export default {
  data() {
    return {
      timerValue: '00:00:25',
      timerIsStarted: false,
      currentTime: 0,
      pauseBtnText: 'Stop',
      isPaused: false,
      timerMax: 0,
      warrningMsg: '',
    };
  },
  computed: {},
  watch: {},
  methods: {
    setTimer(event) {
      this.timerValue = event.target.value;
    },
  },
};
</script>

<template>
  <h2>Simple Timer App</h2>

  <div class="container">
    <label for="time">Set Time</label>
    <input
      id="time"
      :value="timerValue"
      placeholder="HH:MM:SS"
      type="text"
      @change="setTimer"
    >
  </div>

</template>

<style scoped>
</style>
