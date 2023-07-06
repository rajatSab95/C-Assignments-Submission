public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }   
    public string LastName { get; set; }             
    public Dept Department { get; set; } 
    public Gender Gender { get; set; }    
    public Country Country { get; set; } 
    public int Salary { get; set; }
    public DateTime Dob  { get; set; }

    public override string ToString()
    {
        string str = string.Empty;
        str+=$"Id: {this.Id}\n";
        str+=$"First Name: {this.FirstName}\n";
        str+=$"Last Name: {this.LastName}\n";
        str+=$"Department: {this.Department}\n";
        str+=$"Gender: {this.Gender}\n";
        str+=$"Country: {this.Country}\n";
        str+=$"Salary: {this.Salary}\n";
        str+=$"Date of Birth: {this.Dob}\n";
        str+="----------------------------------";
        return str;
    }
}

public enum Dept
{
    IT,
    HR,
    Payroll,
    Engineering,
    Admin,
    Sales
}
public enum Gender{
    Male, 
    Female,
    Unknown
}
public enum Country{
    India,
    USA,
    UK,
    Cannada,
    France
}