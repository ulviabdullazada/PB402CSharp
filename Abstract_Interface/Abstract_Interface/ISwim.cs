namespace Abstract_Interface
{
    public interface ISwim
    {
        int MaxSwimTime { get; }
        void Swim();
        void Test()
        {
            Console.WriteLine("Test");
        }
    }
}
