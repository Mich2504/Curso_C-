using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts
{
    public class Date
    {
        //Declaracion de atributos sin anderline private int year;
        private int _year;// con anderline
        private int _month;
        private int _day;

        //Crear constructor por un snifer ctor tab tab
        //Parametros a pasar anio, mes y dia
        public Date(int year, int month, int day)
        {
           _year = year;//opcion 1 this.year = year;
            _month=CheckMonth(month);//creacion de metodo
            _day = CheckDay(year,month,day);
        }

        private int CheckDay(int year, int month, int day)
        {
            //Validacion de anio bisiesto
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }
            //crear un arreglo que devuelve los dias de cada mes
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }

            throw new DayException("Sorry Invalid day");
        }
        private bool IsLeapYear(int year)
        {
            //opcion 2 simplificada
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
           //Opcion 1
            //if (year % 4 == 0)
            //{
            //    if (year % 100 == 0)
            //    {
            //        if (year % 400 == 0)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    else
            //    {
            //        return true;
            //    }
            //}
            //else
            //{
            //    return false;
            //}
        }


        private int CheckMonth(int month)
        {
            if(month>=1 && month<=12) {//valida si el mes esta entre el rango de 1 y 12
                return month;
            }
            throw new MonthException("Invalid month");//Se crea una excepcion en caso de que el rango diferente
        }

        //sobre escritura de toString

        override 
            public string ToString()
        {
           // return _year+ "/"+ _month+"/"+ _day;//opcion 1 consume recursos
            return $"{_year}/{_month:00}/{_day:00}";  //opcion 2 interpolacion
        }

    }
}
