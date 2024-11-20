using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class_Attributes
{
    internal class Song

    //Normal attributes to my class are below, these attributes can be changed depending on the user
    //Static attributes DO NOT change. They are fixed variables. The songCount below is our static attribute
    //A static attribute is defined as storing information about the class. Not about the objects themselves. Therefore it is an attribute that is always related to 
    //the class when called. Not the object or in this case the song

    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;

        //We are adding a line to increment the song count below, so that each time the code is run and a song object is created the song count increases
        //We are also adding a method to get the song count below our first method
        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;   
            duration = aDuration;   
            songCount++;
        }
        public int getSongCount()
        {
            return songCount;
        }

    }
}
