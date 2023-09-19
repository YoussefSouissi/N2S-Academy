namespace LMSTUDYwebService.Models
{
    public class Panier
    {
        public Guid Id { get; set; }

        public List<Formation> Formations { get; set; }
    }
}
