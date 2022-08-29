namespace DotNet._06.TP5Dojo.Web.Models
{
    public class SamouraiViewModel
    {
        public int Id { get; set; }
        public int Force { get; set; }
        public string Nom { get; set; }
        public virtual ArmeViewModel Arme { get; set; }
    }
}
