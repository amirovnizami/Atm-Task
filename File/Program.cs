
class Program
{
    delegate void Func(string str);

    class Myclass
    {
        public string str { get; set; }
        public Myclass(string str)
        {
            this.str = str;
        }
        public void space(string str)
        {
            foreach (char c in str)
            {
                Console.Write($"{c}_");
            }
            Console.WriteLine();
        }
        public void reverse(string str)
        {
            List<char> list = new List<char>();

            foreach (char c in str)
            {
                list.Add(c);
            }
            list.Reverse();
            foreach (char c in list)
            {
                Console.Write(c);
            }
        }
      

    }
    class Run
    {
        public void runFunc(Func func,string str)
        {
            func.Invoke(str);
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string");
        var str = Console.ReadLine();
        Myclass cls = new Myclass(str);
        Func funcDell = new Func(cls.space);
        funcDell += cls.reverse;
        Run run = new Run();
        run.runFunc(funcDell, str);
    }

}