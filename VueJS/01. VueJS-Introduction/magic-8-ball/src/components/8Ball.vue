<script>
const possibleAnswers = ['Yes', ' no', 'maybe', 'I don\'t know', 'Can you repeat the question?', 'You\'re not the boss of me now and you\'re not so big', 'You\'re not the boss of me now', 'You\'re not the boss of me now', 'You\'re not the boss of me now and you\'re not so big', 'Life is unfair', 'wildcard'];

export default {
  data() {
    return {
      isThinking: false,
      hasAnswer: false,
      answers: [],
    };
  },

  methods: {
    giveWisdom() {},
  },
};
</script>

<template>
  <div class="container">
    <h1>I am the magic 8 ball</h1>
    <h2>I have all the answers</h2>
    
    <div class="container">
      <p>Ask your question outloud and press the button.</p>
      <p>The ball does not need access to your mic</p>
    </div>

    <button>
      Get my wisdom
    </button>
  </div>
</template>

<style scoped>
</style>
