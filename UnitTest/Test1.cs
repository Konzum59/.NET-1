using plecak;

namespace UnitTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
            foreach (int n in sizes)
                {
                Problem problem = new Problem(n, 2,20);
                Assert.AreEqual(n, problem.ListaPrzedmiotow.Count);
                }
        }
        [TestMethod]
        public void TestSigneItem()
        {
            List <Przedmiot> sigleItem = new List<Przedmiot>() {new Przedmiot(5,5,1) };
            Problem problem = new Problem(1, 2, 20);
            problem.ListaPrzedmiotow = sigleItem;
            Result result= problem.Solve();
            Assert.AreEqual(result.MaxValue, 5);
            Assert.AreEqual(result.MaxCapacity, 5);
            Assert.AreEqual(result.PackedObjects.Count, 1);
        }
        [TestMethod]
        public void TestWrongItem()
        {
            List<Przedmiot> sigleItem = new List<Przedmiot>() { new Przedmiot(95, 95, 1) };
            Problem problem = new Problem(1, 2, 20);
            problem.ListaPrzedmiotow = sigleItem;
            Result result = problem.Solve();
            Assert.AreNotEqual(result.MaxValue, 15);
            Assert.AreNotEqual(result.MaxCapacity, 15);
            Assert.AreNotEqual(result.PackedObjects.Count, 1);
        }
        [TestMethod]
        public void TestSpecificItems()
        {
            List<Przedmiot> items = new List<Przedmiot>() { new Przedmiot(5, 5, 1), new Przedmiot(1, 10, 2) , new Przedmiot(9, 8, 3), new Przedmiot(5, 6, 4) };
            Problem problem = new Problem(1, 2, 10);
            problem.ListaPrzedmiotow = items;
            Result result = problem.Solve();
            Assert.AreEqual(result.MaxValue, 16);
            Assert.AreEqual(result.MaxCapacity, 6);
            Assert.AreEqual(result.PackedObjects.Count, 2);
        }
        [TestMethod]
        public void TestZeroItems()
        {
            List<Przedmiot> sigleItem = new List<Przedmiot>() {};
            Problem problem = new Problem(1, 2, 10);
            problem.ListaPrzedmiotow = sigleItem;
            Result result = problem.Solve();
            Assert.AreEqual(result.MaxValue, 0);
            Assert.AreEqual(result.MaxCapacity, 0);
            Assert.AreEqual(result.PackedObjects.Count, 0);
        }
        [TestMethod]
        public void TestManyManyItems() { 
        List<Przedmiot> items = new List<Przedmiot>();
            for (int i = 0; i < 99999; i++) {
                items.Add(new Przedmiot(i%11, 2+i%7,i+1));
            }
            Problem problem = new Problem(1, 2, 50000);
            problem.ListaPrzedmiotow = items;
            Result result = problem.Solve();
            Assert.IsTrue(result.PackedObjects.Count > 0);
            
        }
        
    }
}
