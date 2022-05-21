using Android.App;
using Android.Text;
using Android.Text.Style;
using Android.Views;
using AndroidX.RecyclerView.Widget;

namespace learning_siltums_1.HardcodedData
{
    public class QuestionsAndAnswersQuizAdapter : RecyclerView.Adapter
    {
        public Siltums1QnADataQuiz mData;

        static string needsSuperscript = "Ӿ";
        static string needsSubscript = "ӿ";

        public QuestionsAndAnswersQuizAdapter(Siltums1QnADataQuiz data)
        {
            mData = data;
        }

        public override int ItemCount => mData.questionAndAnswersQuizList.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            QnAViewHolder vh = holder as QnAViewHolder;

            vh.QuestionId.Text = $"{mData.questionAndAnswersQuizList[position].QuestionId}. jautājums";
            vh.Question.TextFormatted = GetFormatedText(mData.questionAndAnswersQuizList[position].Question);
            vh.Answer.TextFormatted = GetFormatedText(mData.questionAndAnswersQuizList[position].Answer);
            vh.Points.Text = mData.questionAndAnswersQuizList[position].Points.ToString();
            vh.Image.SetImageResource(mData.questionAndAnswersQuizList[position].AnswerImage);
            vh.ShowHide.Click += (sender, e) =>
            {
                if (vh.Answer.Visibility == ViewStates.Gone)
                {
                    vh.Answer.Visibility = ViewStates.Visible;
                    vh.Image.Visibility = ViewStates.Visible;
                    vh.ShowHide.Text = "Slēpt atbildi";
                }
                else
                {
                    vh.Answer.Visibility = ViewStates.Gone;
                    vh.Image.Visibility = ViewStates.Gone;
                    vh.ShowHide.Text = "Rādīt atbildi";
                }
            };

            vh.Answer.Visibility = ViewStates.Gone;
            vh.Image.Visibility = ViewStates.Gone;
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

        private SpannableStringBuilder GetFormatedText(string text)
        {
            SpannableStringBuilder sb = new SpannableStringBuilder(text);

            if (string.IsNullOrEmpty(text)) return sb;

            int supSpanCount = (text.Split(needsSuperscript).Length - 1) / 2;
            int subSpanCount = (text.Split(needsSubscript).Length - 1) / 2;
            if (supSpanCount < 1 && subSpanCount < 1) return sb;
            //-----------superscript
            if (supSpanCount > 0)
            {
                int[,] supIndexArray = new int[supSpanCount, 2];
                FillInIndexArray(text, supIndexArray, needsSuperscript);

                for (int i = 0; i < supSpanCount; i++)
                {
                    sb.SetSpan(new SuperscriptSpan(), supIndexArray[i, 0], supIndexArray[i, 1], SpanTypes.ExclusiveExclusive);
                    sb.SetSpan(new RelativeSizeSpan(0.75f), supIndexArray[i, 0], supIndexArray[i, 1], SpanTypes.ExclusiveExclusive);
                }

                DeleteSpanChars(sb, supSpanCount, supIndexArray);
            }
            //------------subscript
            if (subSpanCount > 0)
            {
                int[,] subIndexDictionary = new int[subSpanCount, 2];

                FillInIndexArray(sb.ToString(), subIndexDictionary, needsSubscript);

                for (int i = 0; i < subSpanCount; i++)
                {
                    sb.SetSpan(new SubscriptSpan(), subIndexDictionary[i, 0], subIndexDictionary[i, 1], SpanTypes.ExclusiveExclusive);
                    sb.SetSpan(new RelativeSizeSpan(0.75f), subIndexDictionary[i, 0], subIndexDictionary[i, 1], SpanTypes.ExclusiveExclusive);
                }

                DeleteSpanChars(sb, subSpanCount, subIndexDictionary);
            }

            sb.Append("\n");
            return sb;
        }

        private static void FillInIndexArray(string text, int[,] supIndexDictionary, string spanTextDelimiters)
        {
            int startIndex = 0;
            int secondIndex = 0;
            int arrayIndex = 0;

            while (true)
            {
                var index = text.IndexOf(spanTextDelimiters, startIndex);
                if (index == -1) break;

                startIndex = index + 1;
                secondIndex = text.IndexOf(needsSubscript, startIndex);
                supIndexDictionary[arrayIndex, 0] = startIndex;
                supIndexDictionary[arrayIndex, 1] = secondIndex;
                arrayIndex++;
                startIndex = secondIndex + 1;
            }
        }

        private static void DeleteSpanChars(SpannableStringBuilder sb, int spanCount, int[,] indexDictionary)
        {
            int indexStart;
            int indexEnd;

            for (int i = spanCount - 1; i > -1; i--)
            {
                indexStart = indexDictionary[i, 0];
                indexEnd = indexDictionary[i, 1];
                sb.Delete(indexStart - 1, indexStart);
                sb.Delete(indexEnd - 1, indexEnd);
            }
        }
    }
}