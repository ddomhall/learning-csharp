namespace basicsToAdvanced.Sections
{
    partial class Sections
    {
        public static void Generics()
        {
            /*
            int[] intArray = CreateArray<int>(5, 6);
            Console.WriteLine(intArray.Length + " " + intArray[0] + " " + intArray[1]);

            string[] stringArray = CreateArray<string>("asdf", "qwerty");
            Console.WriteLine(stringArray.Length + " " + stringArray[0] + " " + stringArray[1]);

            TestMultiGenerics(intArray, stringArray);

            MyClass<EnemyMinion> myClass = new MyClass<EnemyMinion>(new EnemyMinion());
            MyClass<EnemyArcher> myClassArcher = new MyClass<EnemyArcher>(new EnemyArcher());

            static T[] CreateArray<T>(T firstElement, T secondElement)
            {
                return new T[] { firstElement, secondElement };
            }
            static void TestMultiGenerics<T1, T2>(T1 t1, T2 t2)
            {
                Console.WriteLine(t1.GetType());
                Console.WriteLine(t2.GetType());
            }
            */
        }
    }
    public class MyClass<T> where T : IEnemy<int>
    {
        public T value;
        public MyClass(T value)
        {
            value.Damage(0);
        }
        static T[] CreateArray<T>(T firstElement, T secondElement)
        {
            return new T[] { firstElement, secondElement };
        }
    }

    public interface IEnemy<T>
    {
        void Damage(T t);
    }

    public class EnemyMinion : IEnemy<int>
    {
        public void Damage(int i)
        {
            Console.WriteLine("EnemyManion.Damage()");
        }
    }
    public class EnemyArcher : IEnemy<int>
    {
        public void Damage(int i)
        {
            Console.WriteLine("EnemyArcher.Damage()");
        }
    }
}

