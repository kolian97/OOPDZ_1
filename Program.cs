using System.Reflection;

namespace OOPDZ_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FamalyMembers GrandFatherone = new FamalyMembers()
            {
                FullName = "Кирил",
                Age = 40,
                Gender = Gender.man
            };
            FamalyMembers GrandMotherone = new FamalyMembers()
            {
                FullName = "Клара",
                Age = 41,
                Gender = Gender.woman
            };
            FamalyMembers GrandFathersecond = new FamalyMembers()
            {
                FullName = "Никита",
                Age = 60,
                Gender = Gender.man
            };
            FamalyMembers GrandMothersecond = new FamalyMembers()
            {
                FullName = "Маша",
                Age = 61,
                Gender = Gender.woman
            };
            FamalyMembers Father = new FamalyMembers()
            {
                FullName = "Тимофей",
                Age = 30,
                Gender = Gender.man,
                Father = GrandFatherone,
                Mother = GrandMotherone
            };
            FamalyMembers Mother = new FamalyMembers()
            {
                FullName = "Наташа",
                Age = 27,
                Gender = Gender.woman,
                Father = GrandFathersecond,
                Mother = GrandMothersecond
            };
            FamalyMembers Son = new FamalyMembers()
            {
                FullName = "Виктор",
                Age = 9,
                Gender = Gender.man,
                Father = Father,
                Mother = Mother
            };
            FamalyMembers daugher = new FamalyMembers()
            {
                FullName = "Алиса",
                Age = 8,
                Gender = Gender.woman,
                Father = Father,
                Mother = Mother
            };
            var GrandMothers = Son.GetGrandMotherName();
            var GrandFathers = Son.GetGrandFatherName();
            var Parents = Son.GetParentsName();
            Console.WriteLine(GrandMothers[0]?.FullName);
            Console.WriteLine(GrandMothers[1]?.FullName);
            Console.WriteLine(GrandFathers[0]?.FullName);
            Console.WriteLine(GrandFathers[1]?.FullName);
            Console.WriteLine(Parents[0]?.FullName);
            Console.WriteLine(Parents[1]?.FullName);
        }
    }
}
