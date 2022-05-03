namespace ClassLibrary_Esercitazione_Dipendenti.Entities
{
    public class Dipendente
    {
        public DateTime DateOfRecruitment { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public int Age 
        { 
            get 
            {
                
                DateTime DataDiOggi = DateTime.Now;
                var età = DataDiOggi.Year - DateOfBirth.Year;
                return età;
            }
        }
        public int YearsOfService
        {
            get
            {
                DateTime DataDiOggi = DateTime.Now;
                var anniDiServizio = DataDiOggi.Year - DateOfRecruitment.Year;
                return anniDiServizio;
            }
        }

        public int Productivity { get; set; }
        public int Absence { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual string ViewBenefit()
        {
            return "";
        }
    }
}