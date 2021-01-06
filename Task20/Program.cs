using System;

namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff staff = new Staff();

            Worker w1 = new Worker("Tom", "Manager", 21);
            try
            {
                staff.AddWorker(w1);
            }
            catch(AddWorkerException e)
            {
                Console.WriteLine(e.Message);
            }

            staff.ShowStaff();

            Worker w2 = new Worker("sdf", "Manager", 22);
            try
            {
                staff.AddWorker(w2);
            }
            catch(AddWorkerException e)
            {
                Console.WriteLine(e.Message+": "+e.Value);
            }
        }
    }
}
