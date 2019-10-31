using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Support.V7.Widget;
using System.Collections.Generic;

namespace ImageLoading
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        RecyclerView recyclerView;
        List<string> ImageUrlList = new List<string>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            recyclerView = (RecyclerView)FindViewById(Resource.Id.recyclerView);
             CreateData();
             SetupRecyclerView();
        }

        void CreateData()
        {
            for (int i = 1; i < 21; i++)
            {
                string url = $"https://picsum.photos/id/{i}/2560/1600";
                ImageUrlList.Add(url);
            }
        }


        void SetupRecyclerView()
        {
            recyclerView.SetLayoutManager(new Android.Support.V7.Widget.LinearLayoutManager(recyclerView.Context));
            PostAdapter postAdapter = new PostAdapter(ImageUrlList);
            recyclerView.SetAdapter(postAdapter);
        }

    }
}