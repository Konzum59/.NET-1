using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
[assembly: InternalsVisibleTo("UnitTest"), InternalsVisibleTo("Gui")]

namespace plecak
{
    //klasa Solve ktra ma zwrci typ klasy result
    internal class Przedmiot
    {
        public int Waga { get; set; }
        public int Wartosc { get; set; }
        public int Numer { get; set; }
        public Przedmiot(int waga, int wartosc, int numer)
        {
            Waga = waga;
            Wartosc = wartosc;
            Numer = numer;
        }
        public override string ToString()
        {
            return $"Item: {Numer}, Weight: {Waga}, Value:{Wartosc}\n";
        }
    }
    internal class Problem
    {
        public List<Przedmiot> ListaPrzedmiotow { get; set; }
        public int Capacity { get; }
        public Problem(int n, int seed, int capacity)
        {
            Capacity = capacity;
            ListaPrzedmiotow = new List<Przedmiot>();
            Random random = new Random(seed);
            
            for (int i = 0; i < n; i++)
            {
                ListaPrzedmiotow.Add(new Przedmiot(random.Next(1, 11), random.Next(1, 11), i + 1));
                Console.Write(ListaPrzedmiotow[i]);
            }

        }
    

        public Result  Solve()
        {
            ListaPrzedmiotow.Sort((x, y) => ((double)x.Waga / (double)x.Wartosc).CompareTo((double)y.Waga / (double)y.Wartosc));
            int CurrentCapacity = 0;
            int CurrentValue = 0;
            List<int> PackedObjects = new List<int>();

            for (int i = 0; i < ListaPrzedmiotow.Count(); i++)
            {
                if (Capacity >= CurrentCapacity + ListaPrzedmiotow[i].Waga)
                {
                    CurrentCapacity +=  ListaPrzedmiotow[i].Waga;
                    CurrentValue += ListaPrzedmiotow[i].Wartosc;
                    PackedObjects.Add(ListaPrzedmiotow[i].Numer);
                }
            }
            Result result = new Result(PackedObjects, CurrentValue, CurrentCapacity);
            Console.Write(result);
            return result;
            
        }
        public override string ToString()
        {
            string FullList = " ";
            foreach (var item in ListaPrzedmiotow)
            {
                FullList += item.ToString();
            }
            return FullList;
        }
    }
    internal class Result
    {
        public string AllItems{ get; set; }
        public List<int> PackedObjects { get; set; }
        public int MaxValue { get; set; }
        public int MaxCapacity { get; set; }
        public Result(List<int> packedObjects, int maxValue, int maxCapacity)
        {
            AllItems = "";
            PackedObjects = packedObjects;
            MaxCapacity = maxCapacity;
            MaxValue = maxValue;

            foreach (var item in PackedObjects)
            {
                AllItems = AllItems + item.ToString() + " ";
            }


        }
        public override string ToString()
        {
            return $"\n Packed items: {AllItems} \n Final capacity: {MaxCapacity} \n Final value: {MaxValue}";
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the seed: ");
            int Seed = int.Parse(Console.ReadLine());
            Console.WriteLine("How many objects: ");
            int ObjectsNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Capacity: ");
            int Capacity = int.Parse(Console.ReadLine());

            Problem problem = new Problem(ObjectsNumber, Seed, Capacity);
            Result result = problem.Solve();
            Console.WriteLine(result.AllItems);
            Console.WriteLine(result.MaxCapacity);
            Console.WriteLine(result.MaxValue);
            Console.WriteLine(problem);
            
            int Caapacity = int.Parse(Console.ReadLine());

        }
    }
}
