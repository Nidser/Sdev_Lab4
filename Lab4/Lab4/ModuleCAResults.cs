using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class ModuleCAResults
    {
        //The class should contain auto-implemented properties for the module name, 
        //and the number of credits it is worth, and the student name.
        //
        public string ModuleName { get; set; }
        public double credits { get; set; }
        public string StudentName { get; set; }

        //It should contain a collection of results (scores) for CAs in the module in order
        private const int MAX = 50;                             // max 50 results
        private double[] results = new double[MAX];             // create array
        private int next = 0;                                   // next free slot for a result in the results array

        //Override ToString to return all module details and CA results.

        public override string ToString()
        {
            string ModuleDetails =  "Module name: " + ModuleName + "\nCredit value: " + credits + "\nStudent Name " + StudentName;

            for (int i = 0; i < next; i++)
            {
                ModuleDetails += results[i] + " ";            
            }
            return ModuleDetails;
        }

        //Implement an indexer for the class which allows retrieval of a specific CA result, 
        //and setting or a result i.e. a read/write indexer property. 

        // indexer based on CA
        public double this[int CA]
        {
            get
            {
                int index = CA - 1;                             // CA1 is at index 0 etc.
                if ((index >= 0) && (index < next))             // valid range
                {
                    return results[index];                      // return the result
                }
                else
                {
                    throw new Exception("Invalid CA number");
                }
            }
            set
            {
                // add a result or change an existing result

                int index = CA - 1;
                // no gaps allowed, must overwrite existing result or add at end, and must have space in array
                if ((index >= 0) && (index <= next) && (index < (MAX)))
                {
                    results[index] = value;                     // set the result
                    if (index == next)
                    {
                        next++;                                 // that was a new result
                    }
                }
                else
                {
                    throw new Exception("Invalid CA number");
                }
            }
        }

        public ModuleCAResults()
        {

        }

        public ModuleCAResults(string modName, double credit, string stuName)
        {
            this.ModuleName = modName;
            this.credits = credit;
            this.StudentName = stuName;

        }

        public ModuleCAResults(string modName, double credit)           
        {
            this.ModuleName = modName;
            this.credits = credit;
            this.StudentName = "";
        }

         




    }
}
