using ConsoleApp9.Moduls;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Anar", "Qasimzade", "ab106", 34);

            student.GetInfo();
            student.CheckGraduation();
            student.GetDiplomDegree();
        }
    }
}