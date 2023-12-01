using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem
{
    // A Trainer is an Employee. A Trainer is a Teacher.
    internal class Trainer : Employee, ITeacher
    {
        public Trainer(string firstName, string lastName, string employeeId) : base(firstName, lastName, employeeId)
        {
        }

        // Need to create an interface to make the Teach method - ITeacher

        public void Teach()
        {
            Console.WriteLine("Sit up and listen, lesson about to start...");
        }

    }
}
