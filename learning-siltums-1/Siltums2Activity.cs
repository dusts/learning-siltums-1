using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using learning_siltums_1.HardcodedData;
using Google.Android.Material.FloatingActionButton;
using Android.Content;
using Xamarin.Essentials;

namespace learning_siltums_1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class Siltums2Activity : Activity
    {
        RecyclerView mRecyclerView;
        RecyclerView.LayoutManager mLayoutManager;
        QuestionsAndAnswersAdapter mAdapter;
        Siltums2QnAData mData;

        //protected MediaPlayer player;
        //public void StartPlayer()
        //{
        //    if (player == null)
        //    {
        //        player = new MediaPlayer();
        //    }
        //    else
        //    {
        //        player.Reset();
        //        player.SetDataSource();
        //        player.Prepare();
        //        player.Start();
        //    }
        //}

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_siltums2);

            // Prepare the data source:
            mData = new Siltums2QnAData();

            // Set our view from the "main" layout resource:
            SetContentView(Resource.Layout.activity_siltums2);

            // Get our RecyclerView layout:
            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.siltumsQnAList);

            mLayoutManager = new LinearLayoutManager(this);
            mRecyclerView.SetLayoutManager(mLayoutManager);

            // Instantiate the adapter and pass in its data source:
            mAdapter = new QuestionsAndAnswersAdapter(mData);

            // Plug the adapter into the RecyclerView:
            mRecyclerView.SetAdapter(mAdapter);

            FloatingActionButton fabs1 = FindViewById<FloatingActionButton>(Resource.Id.fab_quiz);
            fabs1.Click += (sender, e) =>
            {
                StartActivity(new Intent(this, typeof(MainActivity)));
            };

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += (sender, e) =>
            {
                StartActivity(new Intent(this, typeof(QuizActivity)));
            };


        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
