using System;
using System.Collections.Generic;
using TravelApp3.Model;
using Xamarin.Forms;
using SQLite;


namespace TravelApp3
{
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Post post = new Post()

            {
                Experience = experienceEntry.Text
            };



            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                int rows = conn.Insert(post);

                if (rows > 0)
                {
                    DisplayAlert("Success", "Experience Succesfully Inserted", "Ok");
                }


                else
                {
                    DisplayAlert("Failure", "Eperience failed to be inserted", "OK");
                }
            }
        }
    }

}
