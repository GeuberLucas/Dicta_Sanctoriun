namespace DictaSanctorum.Models
{
    public class Saint
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime birthDay { get; set; }
        public DateTime deathDay { get; set; }
        public string biography { get; set; }
        public string image { get; set; }
        public string canonizationDate { get; set; }
        public string canonizationBy { get; set; }
    }
}
