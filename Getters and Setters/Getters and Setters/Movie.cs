using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getters_and_Setters
{
    class Movie
    {
        //I will complete applying getters and setters to our rating
        public string title;
        public string director;
        private string rating;
        public Movie(string aTitle, string aDirector, string aRating)

        //By using the capital R below I am changing to my getter and setter below instead of my private string variable above (private string variable has lower case r)
        //Doing this makes the class more secure by ensuring that each object has a valid rating
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        //The getter is going to give us the rating everytime we say Rating with a capital R
        //The setter will allow us to modify the rating by defining a specific rule
        //If the value is one of the valid ratings within my setter then we will take it otherwise we will pass it NR
        //Our if statement down here is saying if it isn't one of those values then it will be set to NR 
        public string Rating
        {
            get { return rating; }
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "NR") {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
