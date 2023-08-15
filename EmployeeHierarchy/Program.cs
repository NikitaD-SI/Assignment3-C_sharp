using EmployeeHierarchy;

while (true)
{
    Employee employee;
    Console.WriteLine("1.Manager\n2.Developer\n3.Salesperson");
    int opt = Convert.ToInt32(Console.ReadLine());
    switch (opt)
    {
        case 1:
            employee = new Manager("wjbdjw",1,1000);
            Console.WriteLine($"Bonus: {employee.CalculateBonus()}"); break;
        case 2:
            employee = new Developer("jhcbjdhc",54,7348);
            Console.WriteLine($"Bonus: {employee.CalculateBonus()}"); break;
        case 3:
            employee = new Salesperson("jjwdw",56,9287);
            Console.WriteLine($"Bonus: {employee.CalculateBonus()}"); break;
        case 4:
            return;
        default:
            Console.WriteLine("Wrong Input");
            break;
    }
}
