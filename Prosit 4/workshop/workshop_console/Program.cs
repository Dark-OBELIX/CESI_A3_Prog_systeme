/*
using workshop;
using static workshop.MyClass;

Console.WriteLine("Question 1 : ");

MyClass myClass = new MyClass();
//MyClass.MethodeRetour(1, 2);
//Console.WriteLine(MyClass.MethodeRetour(1, 2));

Callback handler = MyClass.MethodeRetour; ;
Console.WriteLine(handler(1, 2));


Console.WriteLine("Question 2 : ");

Func<int, int> fonction_carre = x => x * x;
Console.WriteLine(fonction_carre(7));


Console.WriteLine("Question 3 : ");

var personne = new { prenom = "Hugo", poids = 95}; 
Console.WriteLine(personne.prenom +" " + personne.poids);
*/

using workshop;
using static workshop.Class_A;
using static workshop.Class_B;

Console.WriteLine("Question 4 : ");

Class_A class_A;
Class_B class_B;

delg class_delg;
delg class_delg_a;
delg class_delg_b;
delg[] delgtab;

class_A = new Class_A();
class_B = new Class_B();

class_delg = new delg(class_A.ma);
class_delg += class_B.mb; // abonne le delegue 
//class_delg -= class_B.mb; // desabonne le delegue
class_delg();

class_delg_a = new delg(class_A.ma);
class_delg_b = new delg(class_B.mb);

delgtab = new delg[2]{class_delg_a, class_delg_b};

for (int i = 0; i < 2; i++)
{
    delgtab[i]();
}

Console.WriteLine("Question 6 : ");

