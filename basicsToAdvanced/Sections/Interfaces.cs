namespace basicsToAdvanced.Sections
{
    partial class Sections
    {
        public static void Interfaces()
        {
        /*
            MyClass myClass = new MyClass();
            TestInterface(myClass);

            MySecondClass mySecondClass = new MySecondClass();
            TestInterface(mySecondClass);
        */
        }

        static void TestInterface(IMyInterface myinterface)
        {
            myinterface.TestFunction();
        }
    }
    public interface IMyInterface : IMySecondInterface
    {
        void TestFunction();
    }
    
    public interface IMySecondInterface
    {
        void SecondInterfaceFunction(int i);
    }

    public class MyClass : IMyInterface, IMySecondInterface
    {
        public void TestFunction()
        {
            Console.WriteLine("MyClass.TestFunction()");
        }
        public void SecondInterfaceFunction(int i)
        {
        }
    }
    public class MySecondClass : IMyInterface
    {
        public void TestFunction()
        {
            Console.WriteLine("MySecondClass.TestFunction()");
        }
        public void SecondInterfaceFunction(int i)
        {
        }
    }
}
