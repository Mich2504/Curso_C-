namespace POOConcepts
{//Definicion de clase abstracta
    public abstract class Employee// no tiene constructor porque se genera uno generico
    {
        // pro tab tab crea propiedad
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Date BirthDate { get; set; }

        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }

        public abstract decimal GetValuetoPay();//metodo de sobreescritura
                                                // interpolacion de string

        public override string ToString()
        {
            return $"{Id} - {FirstName} {LastName},Birth: {BirthDate}, Hiring: {HiringDate}, Is active: {IsActive}";
        }


    }
}