using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;

namespace learning_siltums_1.HardcodedData
{
    internal class QnAViewHolder : RecyclerView.ViewHolder
    {
        public TextView QuestionId { get; private set; }
        public TextView Question { get; private set; }
        public TextView Answer { get; private set; }
        public TextView Points { get; private set; }
        public ImageView Image { get; private set; }
        public Button ShowHide { get; private set; }

        public QnAViewHolder(View itemView) : base(itemView)
        {
            // Locate and cache view references:
            Image = itemView.FindViewById<ImageView>(Resource.Id.qna_item_image);
            Question = itemView.FindViewById<TextView>(Resource.Id.qna_item_question);
            Answer = itemView.FindViewById<TextView>(Resource.Id.qna_item_answer);
            Points = itemView.FindViewById<TextView>(Resource.Id.qna_item_points);
            QuestionId = itemView.FindViewById<TextView>(Resource.Id.qna_item_id);
            ShowHide = itemView.FindViewById<Button>(Resource.Id.qna_item_show_button);
        }
    }
}