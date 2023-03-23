// See https://aka.ms/new-console-template for more information
using POOConcepts;

Console.WriteLine("POO Concepts");
Console.WriteLine("=============");


//presiona ctl k s  y escoge try 
try
{
	Date date1 = new Date(2023, 3, 21);//opcion 1 para imprimir un objeto
	Console.WriteLine(date1);
    Console.WriteLine(new Date(2022, 2, 29));
    Console.WriteLine(new Date(2022, 12, 7));//opcion 2 simplificada
	Console.WriteLine(new Date(1974, 9, 23));
	Console.WriteLine(new Date(1985, 18, 45));
    Console.WriteLine(new Date(1985, 11, 45));
}
catch (Exception error)//excepcion que muestra un mensaje 
{
	Console.WriteLine(error.Message);
	
}