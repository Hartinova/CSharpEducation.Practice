using Practice5.Task1.Model;
using Practice5.Task2;
using System;
using System.Collections.Generic;

namespace Practice5.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Камилла", 123456);
            Console.WriteLine($"Имя: {employee.Name}; Зарплата: {employee.Salary}; Бонус: {employee.CalculateBonus()} ");

            var managerTimur = new Manager("Тимур", 123456,1);
            Console.WriteLine($"Имя: {managerTimur.Name}; Зарплата: {managerTimur.Salary}; размер команды: {managerTimur.TeamSize} Бонус: {managerTimur.CalculateBonus()} ");

            var managerOksana = new Manager("Оскана", 123456, 6);
            Console.WriteLine($"Имя: {managerOksana.Name}; Зарплата: {managerOksana.Salary}; размер команды: {managerOksana.TeamSize} Бонус: {managerOksana.CalculateBonus()} ");

            var contractor = new Contractor("Подрядчик", 120111, 1000,5);
            Console.WriteLine($"Имя: {contractor.Name}; Зарплата: {contractor.Salary}; Почасовая ставка: {contractor.HourlyRate} Бонус: {contractor.CalculateBonus()} ");           
            Console.WriteLine();

            var list=new List<Employee>();
            list.Add(employee);
            list.Add(managerTimur);
            list.Add(managerOksana);
            list.Add(contractor);

            foreach( Employee emp in list ) 
            {
                double bonus = 0;
                if (emp is Contractor) 
                { 
                    bonus= (emp as Contractor).CalculateBonus();                                      
                }
                else
                {
                    bonus = emp.CalculateBonus();
                }
                Console.WriteLine($"Имя: {emp.Name}; Бонус: {bonus}");
            }
            Console.ReadLine();

        }
    }
}
