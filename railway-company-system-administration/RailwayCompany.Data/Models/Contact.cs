namespace RailwayCompanyIS.Data.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public virtual ContactType Type { get; set; }
        public string ContactContent { get; set; }
    }

    public enum ContactType
    {
        Домашний = 1,
        Мобильный = 2,
        Факс = 3,
        Вконтакте = 4,
        Email = 5,
        Telegram = 6,
        Twitter = 7
    }

}