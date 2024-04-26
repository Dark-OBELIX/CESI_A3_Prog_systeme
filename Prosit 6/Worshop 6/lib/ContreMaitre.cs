using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    public class ContreMaitre
    {
        public void verifierquecesgrosbranleursbossent(Employee employee1, Employee employee2, Employee employee3, Employee employee4)
        {
            Console.WriteLine("");
            Console.WriteLine("Rapport : ");
            Console.WriteLine($"{employee1.Name} a produit {employee1.Nbrsproduct} produits.");
            Console.WriteLine($"{employee2.Name} a produit {employee2.Nbrsproduct} produits.");
            Console.WriteLine($"{employee3.Name} a produit {employee3.Nbrsproduct} produits.");
            Console.WriteLine($"{employee4.Name} a produit {employee4.Nbrsproduct} produits.");
            Console.WriteLine("");
        }

        public void Nbresproduitfabrique(Employee employee1, Employee employee2, Employee employee3, Employee employee4)
        {
            int total = employee1.Nbrsproduct +
                employee2.Nbrsproduct +
                employee3.Nbrsproduct +
                employee4.Nbrsproduct;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Nombres total de produit : {total}");
            Console.ResetColor();
            Console.WriteLine("");
        }
    }
}

