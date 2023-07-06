using System.Linq;
public class Linq
{
public static List<Employee> employeeList = new List<Employee>(){ new Employee(){FirstName="Arvind", LastName="Kejriwal", Id=1 , Department=Dept.IT, Country=Country.UK, Salary=12351, Dob=new DateTime(1999,05,01)},
                                                                    new Employee(){FirstName="Sandeep", LastName="Banerjee", Id=2 , Department=Dept.Payroll, Country=Country.Cannada, Salary=33546, Dob=new DateTime(1995,01,15)},
                                                                    new Employee(){FirstName="Bharat", LastName="Loksabha", Id=3 , Department=Dept.Payroll, Country=Country.USA, Salary=89383, Dob=new DateTime(1969,2,12)},
                                                                    new Employee(){FirstName="Ajit", LastName="Pawar", Id=4 , Department=Dept.Engineering, Country=Country.UK, Salary=34343, Dob=new DateTime(1999,01,18)},
                                                                    new Employee(){FirstName="Nitish", LastName="Kumar", Id=5 , Department=Dept.HR, Country=Country.USA, Salary=34458, Dob=new DateTime(1995,09,28)},
                                                                    new Employee(){FirstName="Narendra", LastName="Modi", Id=6 , Department=Dept.Sales, Country=Country.India, Salary=55786, Dob=new DateTime(1996,08,08)},
                                                                    new Employee(){FirstName="Joe", LastName="Biden", Id=7 , Department=Dept.Admin, Country=Country.France, Salary=82567, Dob=new DateTime(1997,08,23)},
                                                                    new Employee(){FirstName="Bhagwant", LastName="Maan", Id=8 , Department=Dept.IT, Country=Country.UK, Salary=22579, Dob=new DateTime(1993,12,05)},
                                                                    new Employee(){FirstName="Rajat", LastName="Sabale", Id=9 , Department=Dept.IT, Country=Country.India, Salary=20052, Dob=new DateTime(2022,01,25)},
                                                                    new Employee(){FirstName="Kirron", LastName="Bedi", Id=10 , Department=Dept.Engineering, Country=Country.USA, Salary=15115, Dob=new DateTime(2014,05,17)},
                                                                    new Employee(){FirstName="Akhilesh", LastName="Yadav", Id=11 , Department=Dept.Engineering, Country=Country.UK, Salary=21354, Dob=new DateTime(2019,04,07)},
                                                                    new Employee(){FirstName="Raj", LastName="Mittal", Id=12 , Department=Dept.Sales, Country=Country.Cannada, Salary=13515, Dob=new DateTime(2011,06,30)},
                                                                    new Employee(){FirstName="Mukesh", LastName="Ambani", Id=13 , Department=Dept.Sales, Country=Country.France, Salary=87684, Dob=new DateTime(2007,05,04)},
                                                                    new Employee(){FirstName="Raj", LastName="Thakrey", Id=14 , Department=Dept.Payroll, Country=Country.Cannada, Salary=94864, Dob=new DateTime(2000,08,09)},
                                                                    new Employee(){FirstName="Rahul", LastName="Gandhi", Id=15 , Department=Dept.HR, Country=Country.USA, Salary=84684, Dob=new DateTime(2000,01,09)},
                                                                    new Employee(){FirstName="Gau", LastName="K", Id=16 , Department=Dept.IT, Country=Country.UK, Salary=13535, Dob=new DateTime(1999,01,06)},
                                                                    new Employee(){FirstName="Adil", LastName="Ray", Id=17 , Department=Dept.Sales, Country=Country.India, Salary=6456, Dob=new DateTime(1971,06,30)},
                                                                    new Employee(){FirstName="Yatin", LastName="Reddy", Id=18 , Department=Dept.IT, Country=Country.France, Salary=68784, Dob=new DateTime(2001,05,18)},
                                                                    new Employee(){FirstName="Raghuram", LastName="Rajan", Id=19 , Department=Dept.Engineering, Country=Country.UK, Salary=99846, Dob=new DateTime(2008,04,17)},
                                                                    new Employee(){FirstName="Nitin", LastName="Gulati", Id=20 , Department=Dept.IT, Country=Country.France, Salary=13148, Dob=new DateTime(2017,09,13)},
                                                                    new Employee(){FirstName="Mukul", LastName="Sharma", Id=21 , Department=Dept.Payroll, Country=Country.USA, Salary=36546, Dob=new DateTime(2013,07,11)},
                                                                    new Employee(){FirstName="Hambir", LastName="", Id=22 , Department=Dept.Admin, Country=Country.Cannada, Salary=25466, Dob=new DateTime(2019,11,04)},
                                                                    new Employee(){FirstName="Pooja", LastName="Chavan", Id=23 , Department=Dept.Admin, Country=Country.Cannada, Salary=16854, Dob=new DateTime(2022,01,01)},
                                                                    new Employee(){FirstName="Prajakta", LastName="Bhosale", Id=24 , Department=Dept.IT, Country=Country.France, Salary=34685, Dob=new DateTime(2019,05,05)},
                                                                    new Employee(){FirstName="Dnyanada", LastName="Kadam", Id=25 , Department=Dept.Payroll, Country=Country.USA, Salary=55486, Dob=new DateTime(2023,06,12)},
                                                                    new Employee(){FirstName="Akshay", LastName="Salunkhe", Id=26 , Department=Dept.Engineering, Country=Country.Cannada, Salary=54664, Dob=new DateTime(2011,11,11)},
                                                                    
                                                                };
    public static void Main()
    {

        
        PrintAllEmployees();

        EmployeeNameMoreThan4();

        //Objects Condition and Ordering: Length ==4 and order by employees age.
        Ordering();

        //Extracting Properties from Objects in a new collection
        Extracting();
    }
    public static void Extracting()
    {
        var newList = employeeList.Select(item=>item.GetType()).ToList();
        foreach(var v in newList)
        {
            System.Console.WriteLine(v);
        }
    }

    public static void Ordering()
    {
        var v = from e in employeeList
                orderby e.Dob
                where e.FirstName.Length==4
                select e;
        System.Console.WriteLine("Employees having name llength == 4");
        foreach(Employee e in v)
        {
            System.Console.WriteLine(e);
        }
                
    }

    public static void PrintAllEmployees()
    {
        foreach (Employee employee in employeeList)
        {
            System.Console.WriteLine(employee);
        }
    }

    public static void EmployeeNameMoreThan4(){
        List<Employee> Employees = (from e in employeeList 
                                    where e.FirstName.Length > 4 
                                    select e).ToList();

        foreach(Employee e in Employees)
        {
            System.Console.WriteLine(e+"-"+e.FirstName.Length);
        }
    }
    

}