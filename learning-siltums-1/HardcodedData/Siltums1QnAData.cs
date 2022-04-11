using System.Collections.Generic;

namespace learning_siltums_1.HardcodedData
{
    public class Siltums1QnAData
    {
        public List<QuestionAndAnswers> questionAndAnswersList;

        public Siltums1QnAData()
        {
            this.questionAndAnswersList = HardcodedData.GetQnAList();
        }
    }
}