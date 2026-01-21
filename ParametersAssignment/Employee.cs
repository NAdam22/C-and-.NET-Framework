using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    // Define a generic Employee class
    // The <T> allows the class to work with different data types
    class Employee<T>
    {
        // Create a property called Things
        // It is a List of type T (generic)
        public List<T> Things { get; set; }
    }
}
