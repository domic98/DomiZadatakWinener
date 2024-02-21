namespace DomiZadatakWin.Models
{
    public class Policy
    {
        public int Id { get; set; }
        public string PolicyNumber { get; set; }
        public decimal PolicyAmount { get; set; }

        // Foreign key za Partnera
        public int PartnerId { get; set; }
        public Partner Partner { get; set; }
    }
}
