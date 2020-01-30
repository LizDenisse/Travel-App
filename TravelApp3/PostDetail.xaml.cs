using System;
using System.Collections.Generic;
using SQLite;
using TravelApp3.Model;

using Xamarin.Forms;

namespace TravelApp3
{
    public partial class PostDetail : ContentPage
    {
        public Post selectedPost;

        public PostDetail(Post selectedPost)
        {
            InitializeComponent();

           this.selectedPost = selectedPost;

            experienceEntry.Text = selectedPost.Experience;
        }

        void updateBotton_Clicked(object sender, System.EventArgs e)
        {

            selectedPost.Experience = experienceEntry.Text;
            //Post post = new Post()

            //{
            //    Experience = experienceEntry.Text
            //};



            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                int rows = conn.Update(selectedPost);

                if (rows > 0)
                {
                    DisplayAlert("Success", "Experience Succesfully Updated", "Ok");
                }


                else
                {
                    DisplayAlert("Failure", "Eperience failed to be Updated", "OK");
                }

            }
        }
        void deleteBotton_Clicked(object sender, System.EventArgs e)
            {

            //Post post = new Post()

            //    {
            //        Experience = experienceEntry.Text
            //    };



                using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
                {
                    conn.CreateTable<Post>();
                    int rows = conn.Delete(selectedPost);

                    if (rows > 0)
                    {
                        DisplayAlert("Success", "Experience Succesfully Deleted", "Ok");
                    }


                    else
                    {
                        DisplayAlert("Failure", "Eperience failed to be Deleted", "OK");
                    }
                }
            }
        }
    }

