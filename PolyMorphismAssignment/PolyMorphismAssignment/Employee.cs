using System;
using System.Collections.Generic;
using System.Text;

namespace PolyMorphismAssignment
{
    internal class Employee : IQuittable
    {
        //method Quit implementation
        public void Quit()
        {
            //implementation of the Quit method
            //Employee has quit
            Console.WriteLine("Employee has quit.");
        }
    }
}
