using M2HW3.Extensions;
using M2HW3.Models;

namespace M2HW3
{
    public class Starter
    {
        public void Run()
        {
            var ivan = new FirstYearStudent("Ivan", 17, false, "0183952219", 91);
            var oleg = new FourthYearStudent("Oleg", 21, false, "0193756725", 75);
            var anton = new FourthYearStudent("Anton", 20, false, "0183952219", 83);
            var vlad = new FirstYearStudent("Vlad", 18, false, "0121656025", 60);

            Student[] students = { ivan, oleg, anton, vlad };

            foreach (var student in students)
            {
                Console.WriteLine(student + "\n");
            }

            var studentWithTheLongestName = students.GetStudentWithTheLongestName();

            Console.WriteLine($"Student with the longest name\n{studentWithTheLongestName}");

            studentWithTheLongestName.Studying();
        }
    }
}
