using System.Security.Cryptography.X509Certificates;

namespace plecak
{   
    //klasa Solve ktra ma zwrci typ klasy result
    internal class Przedmiot
    {
        public int Waga { get; set; }
        public int Wartosc { get; set; }
        public Przedmiot(int waga, int wartosc)
        {
            Waga = waga;
            Wartosc = wartosc;
        }
    }
    internal class Problem
    {
        public Problem(int n, int seed, int capacity)
        {
            Random random = new Random(seed);

            List<Przedmiot> ListaPrzedmiotow = new List<Przedmiot>();
            for (int i = 0; i < n; i++) {
                ListaPrzedmiotow.Add(new Przedmiot(random.Next(1,11), random.Next(1,11)));
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + ". waga/wartosc: " + ListaPrzedmiotow[i].Waga+" " + ListaPrzedmiotow[i].Wartosc);
            }
            Solve solve = new Solve(capacity, n, ListaPrzedmiotow);
            
        }
    }
    internal class Solve
    {
        public int Capacity { get; set; }

        public Solve(int Capacity,int n, List<Przedmiot> ListaPrzedmiotow)
        {
            ListaPrzedmiotow.Sort((x,y)=>((double)x.Wartosc/(double)x.Waga).CompareTo((double)y.Wartosc/(double)y.Waga));
            int CurrentCapacity = 0;
            int CurrentValue = 0;
            List<int> PackedObjects = new List<int>();
           
            for (int i = 0;i < n;i++) {
            if(Capacity>=CurrentCapacity+ListaPrzedmiotow[i].Waga) {
                CurrentCapacity=CurrentCapacity+ListaPrzedmiotow[i].Waga;
                    CurrentValue += ListaPrzedmiotow[i].Wartosc;
                    PackedObjects.Add(i);
                    Console.WriteLine(i);
              }
            }
            Result result = new Result(PackedObjects, CurrentValue, CurrentCapacity);
        }
    }
    internal class Result
    {
        public Result(List<int> PackedObjects, int MaxValue, int MaxCapacity)
        {
            string AllItems = "Packed objects: ";
            
            foreach (var item in PackedObjects)
            {
                AllItems=AllItems+item.ToString()+" ";
                Console.WriteLine(AllItems);
            }
            Console.WriteLine("Final value: "+MaxCapacity);
            Console.WriteLine("Final capacity: "+MaxValue);
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
        }
    }
}