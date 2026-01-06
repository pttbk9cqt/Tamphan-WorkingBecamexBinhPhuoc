namespace Tamphan_WorkingBecamexBinhPhuoc.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Mucdichsudung { get; set; } = string.Empty;
        public string MaKH { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int Tiendien { get; set; }

        public User() { }
        public User(int iD, string mucdichsudung,string maKH, string password, int tiendien)
        {
            ID = iD;
            Mucdichsudung = mucdichsudung;
            MaKH = maKH;
            Password = password;
            Tiendien = tiendien;
        }


    }
}
