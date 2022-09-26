using M2HW3.Models;

namespace M2HW3.Extensions
{
    public static class ArrayExtension
    {
        public static Student GetStudentWithTheLongestName(this Student[] students)
        {
            Student student = students[0];

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Name.Length > student.Name.Length)
                {
                    student = students[i];
                }
            }

            return student;
        }
    }
}
