using System;
using Xunit;
using SarasTreasures.Models;

namespace Tests
{
    public class QuizTest1
    {
        private const string CORRECT = "Correct!";
        private const string INCORRECT = "Incorrect!";

        [Fact]
        public void CorrectAnswerTest()
        {
            QuizVM q = new QuizVM()
            {
                UserInput1 = " BLACK ",
                UserInput2 = "25%",
                UserInput3 = "true"
            };

            q.CheckAnswers();

            Assert.True(q.Result1 == CORRECT);
            Assert.True(q.Result2 == CORRECT);
            Assert.True(q.Result3 == CORRECT);
        }

        [Fact]
        public void IncorrectAnswerTest()
        {
            QuizVM q = new QuizVM()
            {
                UserInput1 = "orange",
                UserInput2 = "47%",
                UserInput3 = "false"
            };

            q.CheckAnswers();

            Assert.True(q.Result1 == INCORRECT);
            Assert.True(q.Result2 == INCORRECT);
            Assert.True(q.Result3 == INCORRECT);
        }
    }
}
