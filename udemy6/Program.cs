namespace udemy6;

class Program
{
    static void Main(string[] args)
    {
        //constants are immutable values which are know
        //cannot be changed during the lifetime of the program

        //constants as fields

        const double PI = 3.14;
        const int weeks = 52, months = 12;
        //create const as string with my birthday as its value
        const string myBirthday = "June 11 1995";
        Console.WriteLine("my birstday is always going to be: {0}", myBirthday);
        Console.Read();
    }
}

