using System;

namespace faizan
{
    class pets
    {

        public string name = "cat";
        public int age = 12;
        public float happiness = 0.5f;
        public void print()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("age:" + age);
            Console.WriteLine("happiness:" + happiness);
        }
        class Mainclass
        {
            public static void Main(string[] args)
            {
                pets dog = new pets();
                dog.print();
                Console.ReadKey();
            }




        }
    }
}
