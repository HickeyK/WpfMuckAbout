using System;
using System.Linq;
using Model;
using Xunit;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            var repo = new DummyRepository();

            var families = repo.GetFamilies();

            Assert.Equal(2, families.Count);

            foreach (var member in families)
            {
                Console.WriteLine(member.Name);
            }



            var toys = families
                .SelectMany(f => f.FamilyMembers)
                .SelectMany(m => m.Toys);

            foreach (var toy in toys)
            {
                Console.WriteLine(toy.Name);
            }
        }
    }
}
