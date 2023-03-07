using System;

namespace _8_Ball
{
    public static class AnswerGenerator
    {
        private static string[] answers = new string[]
        {
            "Ask again.",
            "I can't answer immediately",
            "Yes, ofcourse.",
            "That's right.",
            "Concentrate and ask again.",
            "No.",
            "Sure",
            "I don't think so.",
            "You better don't ask.",
            "Bad point of view.",
            "Propably yes.",
            "It's difficult to answer.",
            "Yes, as I see.",
            "My answer is no.",
            "Yes.",
            "You can be sure.",
            "Good point of view."
        };

        public static string GetRandomAnswer()
        {
            return answers[new Random().Next(answers.Length)];
        }
    }
}
