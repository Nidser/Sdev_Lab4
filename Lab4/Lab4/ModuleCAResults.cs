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
