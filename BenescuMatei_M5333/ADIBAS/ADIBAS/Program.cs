using System;

namespace ADIBAS
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            Guid Id = Guid.NewGuid();
            Sample sample = new Sample(Id, "ABCD", time);
           
        }
    }
}
