using Android.Views;
using AndroidX.RecyclerView.Widget;

namespace learning_siltums_1.HardcodedData
{
    public class QuestionsAndAnswersAdapter : RecyclerView.Adapter
    {
        public Siltums1QnAData mData;

        public QuestionsAndAnswersAdapter(Siltums1QnAData data)
        {
            mData = data;
        }

        public override int ItemCount => mData.questionAndAnswersList.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            QnAViewHolder vh = holder as QnAViewHolder;

            //vh.Image.SetImageResource(mData.questionAndAnswersList[position].QuestionId);
            vh.Question.Text = mData.questionAndAnswersList[position].Question;
            vh.Answer.Text = mData.questionAndAnswersList[position].Answer;
            vh.Points.Text = mData.questionAndAnswersList[position].Points.ToString();
            if (mData.questionAndAnswersList[position].AnswerImage > 0) vh.Image.SetImageResource(mData.questionAndAnswersList[position].AnswerImage);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            // Inflate the CardView for the photo:
            View itemView = LayoutInflater.From(parent.Context).
                        Inflate(Resource.Layout.qna_item, parent, false);

            // Create a ViewHolder to hold view references inside the CardView:
            QnAViewHolder vh = new QnAViewHolder(itemView);
            return vh;
        }
    }
}