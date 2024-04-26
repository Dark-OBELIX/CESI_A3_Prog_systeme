using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lib { 
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Nbrsproduct { get; set; }
        public Tool Outil_actuel_1 { get; set;
            //Outil_actuel_1.Free = false;
        }
        public Tool Outil_actuel_2 { get; set;
           // Outil_actuel_2.Free = false;
        }
        public void Work()
        {

            if (Outil_actuel_1.Free == true && Outil_actuel_2.Free == true)
            {
                Outil_actuel_1.Free = false;
                Outil_actuel_2.Free = false;
                Console.WriteLine($"Employee : {Name} working");
                Thread.Sleep(4000);
                Nbrsproduct = Nbrsproduct + 1;
                Outil_actuel_1.Free = true;
                Outil_actuel_2.Free = true;

            }
        }
    }
}
