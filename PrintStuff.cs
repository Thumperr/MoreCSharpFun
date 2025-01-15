namespace MoreCSharpFun
{
    internal class PrintStuff
    {
        private string language;
        
        // Constructors
        // Overloading Methods (two methods with the same name but perform differently based on given arguments)
        public PrintStuff()
        {
            language = "EN";
        }
        public PrintStuff(string temp)
        {
            language = temp;
        }
        
        public void PrintName(string n)
        {
            if (language == "EN")
            {
                System.Console.WriteLine("Hello, " + n + "!");
            }

            if (language == "PT")
            {
                System.Console.WriteLine("Oi, " + n + "!");
            }
        }
    }
}