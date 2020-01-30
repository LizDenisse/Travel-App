using System;
using System.Collections.Generic;
using SQLite;
using TravelApp3.Model;
using System.Linq;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;


namespace TravelApp3
{
    public partial class HistoryPage
    {
        public HistoryPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))

            {

                conn.CreateTable<Post>();
                var posts = conn.Table<Post>().ToList();

                postListView.ItemsSource = posts;


            }
        }

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
                var selectedPost = postListView.SelectedItem as Post;

                if(selectedPost != null)
                {
                    Navigation.PushAsync(new PostDetail(selectedPost)); 
                }
        }

    }
}
