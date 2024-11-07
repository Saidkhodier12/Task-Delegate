namespace Task_Two;

internal class Program
{
    static void SortEmployees(List<Employee> employees, Func<Employee, Employee, int> comparison)
    {
        employees.Sort((emp1, emp2) => comparison(emp1, emp2));
    }
    static void CalculateBonus(List<Employee> employees, Func<Employee, double> bonusCalculator)
    {
        foreach (var employee in employees)
        {
            double bonus = bonusCalculator(employee);
            Console.WriteLine($"Employee: {employee.Name}, Bonus: {bonus}");
        }
    }
    static void Main(string[] args)
    {
        var employees = new List<Employee>
        {
            new Employee("Alice", 5, 50000),
            new Employee("Bob", 10, 70000),
            new Employee("Charlie", 3, 45000)
        };

        Console.WriteLine("Sorting by Years of Experience:");
        SortEmployees(employees, (emp1, emp2) => emp2.YearsOfExperience.CompareTo(emp1.YearsOfExperience));
        employees.ForEach(emp => Console.WriteLine($"Name: {emp.Name}, Experience: {emp.YearsOfExperience}, Salary: {emp.Salary}"));

        Console.WriteLine("\nSorting by Salary:");
        SortEmployees(employees, (emp1, emp2) => emp2.Salary.CompareTo(emp1.Salary));
        employees.ForEach(emp => Console.WriteLine($"Name: {emp.Name}, Experience: {emp.YearsOfExperience}, Salary: {emp.Salary}"));

        Console.WriteLine("\nCalculating Bonus based on Years of Experience:");
        CalculateBonus(employees, emp => emp.YearsOfExperience * 500);

        Console.WriteLine("\nCalculating Bonus based on Salary:");
        CalculateBonus(employees, emp => emp.Salary * 0.1);
    }
}
