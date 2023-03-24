using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts
{
    public class CommissionEmployee : Employee// se le heredan los metodos
    {
        public float CommissionPercentaje { get; set; }// porque es un porcentaje por eso es float
        public decimal Sales { get; set; }
        public override decimal GetValuetoPay()//debe devolver un decimal por lo tanto se hace un casting
        {
            return Sales* (decimal) CommissionPercentaje;// SE AGREGA (decimal)  ya que no se puede multiplicar un decimal por un float
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommission percentaje: {$"{CommissionPercentaje:P2}",18}"+ //P2 es un formato de porcentaje
                $"\n\tSales................: {$"{Sales:C2} ",18}" +
                $"\n\tValue to pay.........:{$"{GetValuetoPay():C2}",18}";//El formato C@ quiere decir dos decimales
        }
    }
}
