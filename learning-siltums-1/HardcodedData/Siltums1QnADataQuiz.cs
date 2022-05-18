using System;
using System.Collections.Generic;

namespace learning_siltums_1.HardcodedData
{
    public class Siltums1QnADataQuiz
    {
        public List<QuestionAndAnswers> questionAndAnswersQuizList;

        public Siltums1QnADataQuiz()
        {
            var data = HardcodedData.GetQnAList();

            var random1 = new Random().Next(0, 20);
            var random2 = new Random().Next(21, 41);
            var random3 = new Random().Next(42, 55);
            var random4 = new Random().Next(56, 76);
            var random5 = new Random().Next(77, 97);

            questionAndAnswersQuizList = new List<QuestionAndAnswers>
            {
                data[random1],
                data[random2],
                data[random3],
                data[random4],
                data[random5]
            };
        }
    }
}