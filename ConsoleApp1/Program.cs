

using ConsoleApp1.Models;

Employee employee = new
    Employee();
Console.WriteLine(employee.CalcSalary("Ahmad", 500, 8000, 5));


Console.WriteLine("------ Loop Statmwnt");


for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("i= " + i);
}

Console.WriteLine("------ Even");
for (int i = 2; i <= 10; i += 2)
{
    Console.WriteLine("i= " + i);
}


Console.WriteLine("------ Odd");
for (int i = 1; i <= 10; i += 2)
{
    Console.WriteLine("i= " + i);
}


Console.WriteLine("------ New Even Numbers");
for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        if (i > 4)
        {
            Console.WriteLine("i= " + i);
        }

    }

}

Console.WriteLine("------ Array");

// dataType[] x= new dataType[]

//int[] number=new int[10] ;
//string msg = "";
//for (int i = 0; i < number.Length; i++)
//{
//    number[i] =int.Parse( Console.ReadLine());
//   msg=msg + number[i] + " ";
//}
//Console.WriteLine("------ Sum");


//double sum = 0;


//for (int i = 0; i < number.Length; i++)
//{
//    number[i] = int.Parse(Console.ReadLine());
//    sum = sum + number[i] ;
//}

//Console.WriteLine("Total: " + sum);
Console.WriteLine("------ Print Names");
int x = 5;
string[] names = new string[x] ;
foreach (var n in names)
{
    Console.Write(n + ", ");
}

for (int i = 0; i < names.Length; i++)
{
    Console.Write(names[i] + ", ");
}

Console.ReadLine(); Console.ReadLine(); 