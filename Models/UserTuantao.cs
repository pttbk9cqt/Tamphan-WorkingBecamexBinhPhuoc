namespace Tamphan_WorkingBecamexBinhPhuoc.Models
{
    public class UserTuantao
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;


        public UserTuantao(int iD, string name, string password, string phoneNumber)
        {
            ID = iD;
            Name = name;
            Password = password;
            PhoneNumber = phoneNumber;
        }
        public UserTuantao(string password, string name)
        {
            Name = name;
            Password = password;
        }
        public string GetPhoneNumber()
        {
            //vi du 0985423182, ma qg vn
            return "+84" + PhoneNumber;
        }
    }
}
