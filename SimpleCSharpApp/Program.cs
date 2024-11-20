// See https://aka.ms/new-console-template for more information
public class App {
    static int Main(string[] args)
    //Display a message and wait until a key is pressed
    {
        Console.WriteLine("***** My First C# App *****");
        Console.WriteLine("Hello, World!");
        Console.WriteLine();
        //Local method within the top level statements
        ShowEnvironmentDetails();
        //Get arguments using System.Environment
        string[] theArgs = Environment.GetCommandLineArgs();
        //Process any incoming args
        foreach(string arg in args)
        {
            Console.WriteLine("Arg: {0}", arg);
        }

    static void ShowEnvironmentDetails()
        {
            //Print out the drives on this machines
            //and other interesting details...
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);
            }
            {
                Console.WriteLine("OS: {0}", Environment.OSVersion);
                Console.WriteLine("Number of processors: {0}",
                    Environment.ProcessorCount);
                Console.WriteLine(".NET Core Version: {0}", Environment.Version);
            }
        }
        Console.ReadLine();
        return -1;
    }
}