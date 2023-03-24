namespace POOConcepts
{
    //Es una clase que hereda por lo cual lleva dos puntos
    public class SalaryEmployee : Employee//Heredara los metodos abstractos
    {
        public decimal Salary { get; set; }
        public override decimal GetValuetoPay()
        {
            return Salary;
        }
        public override string ToString()
        {
            // return $"{base.ToString()}\n\tValue to pay.........:{GetValuetoPay():C2} ";//El formato C@ quiere decir dos decimales
            //Creacion de doble interpolacion
            return $"{base.ToString()}" +
                $"\n\tValue to pay.........: {$"{GetValuetoPay():C2}",18}";// el numero 18 ocupa 18 posiciones y se alinea a la derecha
        }
    }
}
