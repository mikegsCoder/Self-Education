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
  computed: {
    timeRepresent() {
      if (this.timerIsStarted) {
        const hours = Math.floor(this.currentTime / 3600);
        const minutes = Math.floor((this.currentTime - hours * 3600) / 60);
        const seconds = this.currentTime % 3600 % 60;
        return `${String(hours).padStart(2, '0')}:${String(minutes).padStart(2, '0')}:${String(seconds).padStart(2, '0')}`;
      }
      return '';
    }
  },
  watch: {},
  methods: {
    setTimer(event) {
      this.timerValue = event.target.value;
    },
    startTimer() {
      this.timerIsStarted = true;
      const [h, m, s] = this.timerValue.split(':');
      this.currentTime = Number(s) + (Number(m) * 60) + (Number(h) * 3600);
      this.timerMax = this.currentTime;
      this.handleTimeChange();
    },
    handleTimeChange() {
      const interval = setInterval(() => {
        if (this.isPaused)
          clearInterval(interval);
        if (this.currentTime === 0) {
          clearInterval(interval);
          this.resetTimer();
        }
        this.currentTime -= 1;
      }, 1000);
    },
    pauseTimer(event) {
      this.isPaused = true;
      const text = event.target.textContent;
      if (text === 'Stop') {
        this.pauseBtnText = 'Continue';
      }
      else {
        this.pauseBtnText = 'Stop';
        this.isPaused = false;
        this.handleTimeChange();
      }
    },
    resetTimer() {
      this.timerIsStarted = false;
      this.currentTime = 0;
      this.timerValue = '00:00:25';
      this.pauseBtnText = 'Stop';
      this.warrningMsg = '';
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

  <div class="container">
    <button id="startBtn" :disabled="timerIsStarted" @click="startTimer">
      Start
    </button>
    <button id="pauseBth" :disabled="!timerIsStarted" @click="pauseTimer">
      {{ pauseBtnText }}
    </button>
    <button id="resetBtn" :disabled="!timerIsStarted" @click="resetTimer">
      Reset
    </button>
  </div>

  <div class="container">
    <label for="current">Time Left</label>
    <input
      id="current"
      type="text"
      :value="timeRepresent"
    >
  </div>

</template>

<style scoped>
</style>
