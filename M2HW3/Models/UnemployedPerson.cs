namespace M2HW3.Models
{
    public abstract class UnemployedPerson : Person
    {
        public UnemployedPerson(string name, int age, bool isWorking) : base(name, age)
        {
            IsWorking = isWorking;
        }

        public bool IsWorking { get; set; }
    }
}
