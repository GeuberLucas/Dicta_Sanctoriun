namespace Dicta_Sanctorum.Models
{
    public class SaintModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime feastDay { get; set; }
        public DateTime birthYear { get; set; }
        public DateTime deathYear { get; set; }
        public DateTime canonizationYear { get; set; }
        public string nationality { get; set; }
        public string bio { get; set; }
        public string image { get; set; }
        public string prayer { get; set; }
    }
}
