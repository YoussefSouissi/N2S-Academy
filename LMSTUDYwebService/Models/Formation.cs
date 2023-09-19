namespace LMSTUDYwebService.Models
{
    public class Formation
    {
        public Guid Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public string ReqKnowledge { get; set; }
        public double price { get; set; }
        public string image { get; set; }

        public Categorie Categorie { get; set; }
        


    }
}
