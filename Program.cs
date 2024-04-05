using Abstract_Task.Models;

namespace Abstract_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stage1 stage1 = new Stage1();
            stage1.Id = "Stage1Id";
            stage1.FamilyName = "Cahid and Sekine's Family";

            Stage2 stage2 = new Stage2();
            stage2.Id = "Stage2";
            stage2.FamilyName = "Vahid ve Cemile's Family";

            Stage3 stage3 = new Stage3();
            stage3.Id = "Stage3Id";
            stage3.FamilyName = "Xedice ve Ferruxun evi";

            Console.WriteLine("Stage1:");
            Console.WriteLine($"Id: {stage1.Id}, Family: {stage1.FamilyName}");
            stage1.Which();

            Console.WriteLine("\nStage2:");
            Console.WriteLine($"Id: {stage2.Id}, Family: {stage2.FamilyName}");
            stage2.Which();

            Console.WriteLine("\nStage3:");
            Console.WriteLine($"Id: {stage3.Id}, Family:{stage3.FamilyName}");
            stage3.Which();
        }
    }
}
