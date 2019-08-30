using System;
using System.Collections.Generic;
namespace Employees
{
        public class Employee
        {
                public Employee(string name, double basepay)
                {
                        this.Name = name;
                        this.Basepay = basepay;
                }

                public string Name { get; set; }
                public double Basepay { get; set;}
                public virtual double CalculatePay()
                {
                        return this.Basepay;
                }
        }
        public class SalesEmployee : Employee
        {
                public SalesEmployee(string name, double basepay, double paybonus) : base(name, basepay)
                {
                        this.Paybonus = paybonus;
                }

                public double Paybonus { get;set; }
                public override double CalculatePay()
                {
                        return (this.Basepay + this.Paybonus);
                }
        }
        public class EmployeeManager : Employee
        {
                public EmployeeManager(string name, double basepay , List<Employee> empleados, double percent) : base(name, basepay)
                {
                        this.Empleados = empleados;
                        this.Percent = percent;
                }

                public List<Employee> Empleados { get; set; }
                public double Percent { get; }

                public override double CalculatePay()
                {
                        double total = 0;
                        foreach(Employee empleado in this.Empleados)
                        {
                                total += empleado.CalculatePay();
                        }
                        return (this.Basepay + this.Percent * total );
                }
        }
}
