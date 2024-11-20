using System;

namespace Static_Class_Attributes
{
    internal class Program
    {
        //below is an example of how we print our static attribute, song count
        //Console.WriteLine(Song.songCount);
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(kashmir.getSongCount());

            Console.ReadLine();
        }
    }
}
