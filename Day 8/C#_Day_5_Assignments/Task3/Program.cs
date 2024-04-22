namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue priorityQueue = new PriorityQueue();
            while (true)
            {
                Console.WriteLine("-----------Hospital-----------");
                Console.WriteLine("1.Add new patient\n2.Remove patient");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Enter Patient Name");
                        string patientName = Console.ReadLine();
                        Console.WriteLine("Enter emergency level from 0 to 10");
                        int urgency = int.Parse(Console.ReadLine());
                        Patient patient = new Patient(patientName, urgency);
                        priorityQueue.insert(patient);
                        break;
                    case 2:
                        Console.WriteLine(priorityQueue.remove().patientName);
                        break;
                }

            }
        }
    }
}
