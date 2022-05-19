


public class Employee:Person
{
    /*Fields/data */
    private int _id;

    /*Properties/Atributes*/
    //init-only properities
    public double Salary { get; init; }//NET Core
    public int Id { get => _id; set => _id = value; }

    public string Level { get; set; }//Senior, Leader
    public string NameOfCompany { get; } = " FPT Education";

    /*Contructors*/
    public Employee()
    {
        
    }

    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    public Employee( int id, string name, double salary, DateOnly dob, Address address, string license):base(name, dob, address)
    {
        Salary = salary;
        Id = id;
        License = license;
    }


    //display to console
    //Overiding                         
    public override string? ToString()
    {
        return $"[Id = {this._id}, Name = {Name}, Salary = {Salary}, Dob = {Dob}, Address = {Address}]";
    }
    //manual methods here
    public double GetSalaryByLevel()
    {
        if (this.Level == "Senior")
        {
            return this.Salary * 0.1;
        }
        else
        {
            return this.Salary;
        }
    }
    //Overloading
    public double GetSalaryByLevel(double commitment)
    {
        return this.GetSalaryByLevel() + commitment;
    }

}
