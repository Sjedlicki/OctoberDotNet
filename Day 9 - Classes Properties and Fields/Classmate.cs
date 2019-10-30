using System;
using System.Collections.Generic;
using System.Text;

namespace Day_9___Classes_Properties_and_Fields
{
    class Classmate
    {
        #region Fields
        private string _name;
        private string _homeTown;
        private string _favoriteFood;
        private string _favoriteHobby;
        private double _favoriteNumber;
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string HomeTown
        {
            get { return _homeTown; }
            set {_homeTown = value; }
        }

        public string FavoriteFood
        {
            get { return _favoriteFood; }
            set { _favoriteFood = value; }
        }

        public string FavoriteHobby
        {
            get { return _favoriteHobby; }
            set { _favoriteHobby = value; }
        }

        public double FavoriteNumber
        {
            get { return _favoriteNumber; }
            set { _favoriteNumber = value; }
        }
        #endregion

        #region Constructors
        public Classmate() { }

        public Classmate(string name, string homeTown, string favoriteFood, string favoriteHobby, double favoriteNumber)
        {
            Name = name;
            HomeTown = homeTown;
            FavoriteFood = favoriteFood;
            FavoriteHobby = favoriteHobby;
            FavoriteNumber = favoriteNumber;
        }
        #endregion

        #region Methods
        public void PrintInformation()
        {
            Console.WriteLine($"Classmate: {Name}");
            Console.WriteLine($"Home Town: {HomeTown}");
            Console.WriteLine($"Favorite Food: {FavoriteFood}");
            Console.WriteLine($"Favorite Hobby: {FavoriteHobby}");
            Console.WriteLine($"Favorite Number: {FavoriteNumber}");
        }
        #endregion
    }
}
