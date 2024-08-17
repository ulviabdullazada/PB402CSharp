namespace Namespace
{
    public class Person
    {
        public string Test { get; set; } = "Salam";
        /// <summary>
        /// Static constructor
        /// </summary>
        static Person()
        {
            Console.WriteLine("Static ctor worked");
        }
        /// <summary>
        /// Non-static constructor
        /// </summary>
        public Person()
        {
            Console.WriteLine(Test);
        }
        public static string Ad;
        public string Name;
        public string Surname;
        private int _age;
        public int Age
        {
            get 
            {
                return _age;
            }
            set 
            {
                if (value > 0 && value < 201)
                {
                    _age = value;
                }
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {Surname}");
        }

        public static void SayHi(string name)
        {
            Console.WriteLine("Salam " + name);
        }
        //private int _age;
        //public int GetAge()
        //{
        //    return _age;
        //}
        //public void SetAge(int value)
        //{
        //    if (value < 0)
        //    {
        //        value = value * -1;
        //    }
        //    if (value > 0 && _age <= 200)
        //    {
        //        _age = value;
        //    }

        //}
    }
}
