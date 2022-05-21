using Android.App;
using Android.Content;
using Android.OS;
using AndroidX.RecyclerView.Widget;
using Google.Android.Material.FloatingActionButton;
using learning_siltums_1.HardcodedData;

namespace learning_siltums_1
{
    [Activity(Label = "QuizActivity")]
    public class QuizActivity : Activity
    {
        RecyclerView mQuizRecyclerView;
        RecyclerView.LayoutManager mLayoutManager;
        QuestionsAndAnswersQuizAdapter mQuizAdapter;
        Siltums1QnADataQuiz mQuizData;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_quiz);

            // Prepare the data source:
            mQuizData = new Siltums1QnADataQuiz();

            // Get our RecyclerView layout:
            mQuizRecyclerView = FindViewById<RecyclerView>(Resource.Id.siltumsQnAQuiz);

            mLayoutManager = new LinearLayoutManager(this);
            mQuizRecyclerView.SetLayoutManager(mLayoutManager);

            // Instantiate the adapter and pass in its data source:
            mQuizAdapter = new QuestionsAndAnswersQuizAdapter(mQuizData);

            // Plug the adapter into the RecyclerView:
            mQuizRecyclerView.SetAdapter(mQuizAdapter);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab_quiz);
            fab.Click += (sender, e) =>
            {
                StartActivity(new Intent(this, typeof(MainActivity)));
            };
        }
    }
}