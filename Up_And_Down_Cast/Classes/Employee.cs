namespace Up_And_Down_Cast.Classes
{
    public class Employee
    {
        public string name;

        public int GetYearsEmployed()
        {
            return 5;
        }

        public virtual string GetProgressReport()
        {
            return "Employee report";
        }

        public static Employee Lookup(string name)
        {
            return new Manager(name);
        }

    }
}
