using lib;

Console.WriteLine("Do Factory");

ContreMaitre contreMaitre = new ContreMaitre();

Employee emp1 = new(){Id = 1,Name = "Anakin", Nbrsproduct  = 0};
Employee emp2 = new(){Id = 2,Name = "Obi wan", Nbrsproduct = 0 };
Employee emp3 = new(){Id = 3,Name = "Qui gon", Nbrsproduct = 0 };
Employee emp4 = new(){Id = 4,Name = "yoda", Nbrsproduct = 0 };

Tool tool1 = new(){Id = 1, Name = "tournevis_1", Free = true};
Tool tool2 = new(){Id = 2, Name = "tournevis_2", Free = true };
Tool tool3 = new(){Id = 3, Name = "cle_1", Free = true };
Tool tool4 = new(){Id = 4, Name = "cle_2", Free = true };

emp1.Outil_actuel_1 = tool1;
emp3.Outil_actuel_1 = tool2;

void fonc_treademp1() {
    try
    {
        if (tool4.Free == true && tool1.Free == true)
        {

        }
    }
    finally { }
    
}
Thread treademp1 = new Thread(fonc_treademp1);
treademp1.Start();

while (true)
{
    /*
    emp1.Outil_actuel_1 = tool1;
    emp1.Work();

    emp2.Outil_actuel_1 = tool1;
    emp2.Outil_actuel_2 = tool3;
    emp2.Work();

    emp3.Outil_actuel_1 = tool1;
    emp3.Outil_actuel_2 = tool3;
    emp3.Work();
    */
    contreMaitre.verifierquecesgrosbranleursbossent(emp1, emp2, emp3, emp4);
    contreMaitre.Nbresproduitfabrique(emp1, emp2, emp3, emp4);
    Thread.Sleep(5000);
}