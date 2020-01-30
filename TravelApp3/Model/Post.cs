﻿using System;
using SQLite;

using Xamarin.Forms;

namespace TravelApp3.Model
{
    public class Post
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Experience { get; set; }

    }
}
