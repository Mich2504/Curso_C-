namespace POOConcepts
{
    public class HourlyEmployee : Employee//hereda de la clase empleado
    {
        public float Hours { get; set; }

        public decimal HourValue { get; set; }
        public override decimal GetValuetoPay()
        {
            return (Decimal)Hours * HourValue;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tHours................: {$"{Hours:N2}",18}" + //N2 es un formato de numero pero son decimales
                $"\n\tHour Value...........: {$"{HourValue:C2} ",18}" +
                $"\n\tValue to pay.........: {$"{GetValuetoPay():C2}",18}";//El formato C@ quiere decir dos decimales
        }
    }
}
