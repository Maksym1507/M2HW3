using M2HW3.Interfaces;

namespace M2HW3.Models
{
    public abstract class Student : UnemployedPerson, IStudy
    {
        public Student(string name, int age, bool isWorking, string studentTicket) : base(name, age, isWorking)
        {
            StudentTicket = studentTicket;
        }

        public string StudentTicket { get; set; }

        public virtual void Studying()
        {
            Console.WriteLine("I can study");
        }
    }
}
