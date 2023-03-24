// See https://aka.ms/new-console-template for more information
using POOConcepts;

Console.WriteLine("POO Concepts");
Console.WriteLine("=============");


//presiona ctl k s  y escoge try 
//try
//{
//	Date date1 = new Date(2023, 3, 21);//opcion 1 para imprimir un objeto
//	Console.WriteLine(date1);
//    Console.WriteLine(new Date(2022, 2, 29));
//    Console.WriteLine(new Date(2022, 12, 7));//opcion 2 simplificada
//	Console.WriteLine(new Date(1974, 9, 23));
//	Console.WriteLine(new Date(1985, 18, 45));
//    Console.WriteLine(new Date(1985, 11, 45));
//}
//catch (Exception error)//excepcion que muestra un mensaje 
//{
//	Console.WriteLine(error.Message);

//}


//Employee employee = new Employee();//no se puede crear instancia ya que es una clase abstracta
//SalaryEmployee e1 = new SalaryEmployee();//instruccion valida pero no recomendada

Employee employee1 = new SalaryEmployee()
{
	Id = 1010,
	FirstName = "Sandra",
	LastName = "Morales",
	BirthDate = new Date(1990, 5, 23),
	HiringDate = new Date(2022, 1, 15),
	IsActive = true,
	Salary = 1815453.45M//Si es constante decima siempre se pone una M de money, tenga o no decimales la constante debe llevar M
};
//Console.WriteLine(employee1);

//Creacion de empleado 2

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirthDate = new Date(1995, 5, 23),
    HiringDate = new Date(2022, 2, 5),
    IsActive = true,
    //no tiene salario
    Sales= 320000000M,
    CommissionPercentaje = 0.03F//Debe llevar F ya que es float
};
//Console.WriteLine(employee2);
//Creacion de empleado 3
Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Gonzalo",
    LastName = "Cardona",
    BirthDate = new Date(1985, 5, 23),
    HiringDate = new Date(2022, 2, 5),
    IsActive = true,
    HourValue = 12356.56M,
    Hours = 123.5F//Debe llevar F ya que es float
};
//Console.WriteLine(employee3);
//Creacion de empleado 4
Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Jazmin",
    LastName = "Salazar",
    BirthDate = new Date(1985, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Base = 860678.45M,
    Sales = 58000000M,
    CommissionPercentaje= 0.015F
};
//Console.WriteLine(employee4);
//Creacion de lista de empleados:

//Sintaxis 1
//ICollection<Employee> employees = new List<Employee>();//Colleccion de datos, se crea una lista de empleados
//employees.Add(employee1);
//employees.Add(employee2);
//employees.Add(employee3);
//employees.Add(employee4);

//Sintaxis 2
ICollection<Employee> employees = new List<Employee>()
{
employee1, employee2, employee3, employee4
};

//Si se quiere calcular el total de la nomina se declara una variable para recorrer con un forach
decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValuetoPay();
}
Console.WriteLine("                                 ===============");
Console.WriteLine($"TOTAL                            {$"{payroll:C2}",15}");

//Se genera una factura1
Invoice invoice1 = new Invoice()
{
    Description = "Iphone 13",
    Id = 1,
    Price = 5300000M,
    Quantity = 6
};

//Se genera una factura2
Invoice invoice2 = new Invoice()
{
    Description = "Posta Preum",
    Id = 2,
    Price = 32000M,
    Quantity = 17.5F
};

//impresion de facturas
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);




