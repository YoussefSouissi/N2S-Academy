namespace LMSTUDYwebService.Models
{
    public class Utilisateur
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public Panier Panier { get; set; }
    }
}
