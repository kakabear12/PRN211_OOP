namespace PRN.SE1623;
using static System.Console;
using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        //1. create a Emp object
        /*
        Employee e = new Employee { Salary = 1532d, Name = "Dong" }
        Employee b = new Employee(1, "Tran Van Meo", 1524d);
        WriteLine(b.Name);
        WriteLine(e);
        ReadLine();
        */
        //2 Define a collection Employee
        /*ArrayList lstEmps = new ArrayList();
        lstEmps.Add(new Employee(1, "Dong", 123d, new DateOnly(), new Address(493, "CMT8", "Phuong 13", "Quan 10", "HCMC")));
        lstEmps.Add(new Employee(2, "An", 1123d));
        lstEmps.Add(new Employee(3, "Ha", 823d));
        lstEmps.Add(new Employee(4, "Nam", 143d));
        lstEmps.Add(new Employee(5, "Han", 185d));
        lstEmps.Add(new Employee(6, "Van", 1444d));

        //display
        Display(lstEmps);

        Employee e = new Employee { Salary = 1532d, Name = "Dong" };

        Person p = new Employee();

        Employee k = (Employee)p;//down-casting
        Print(e);
        Print(p);
        */
        /*---------------abstract-----------------*/
        Shape s = new Circle(100);//polymorphys
        s.display();

        /*---------------interface-----------------*/
        IShape ac = new Rectangle();
        double are = s.Perimetter();
        WriteLine(are);
        ReadLine();
    }

    private static void Print (Person p)
    {
        WriteLine(p);
    }
    public static void Display(ArrayList lstData)
    {
        /*
        foreach (Employee e in lstData)
        {
            WriteLine(e);
        }
        */
        for(int i = 0; i < lstData.Count; i++)
        {
            WriteLine(lstData[i]);
        }
    }
}