namespace Razor1.Pages.Models
{
    public class Student
    {
        public int Yas { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double Ortalama { get; set; }
        public string Uyrugu { get; set; }

        public string FullName => Ad + " " + Soyad;


    }
}
