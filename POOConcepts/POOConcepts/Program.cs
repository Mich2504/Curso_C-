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
Console.WriteLine(employee1);

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
    Sales= 32000000M,
    CommissionPercentaje = 0.03F//Debe llevar F ya que es float
};
//Console.WriteLine(employee1);
Console.WriteLine(employee2);










