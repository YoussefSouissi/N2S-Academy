using System.ComponentModel.DataAnnotations.Schema;

namespace LMSTUDYwebService.Models
{
    public class Formation
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ReqKnowledge { get; set; }
        public decimal Price { get; set; } 
        public string Image { get; set; }

        [NotMapped]
        public List<string> Objectifs { get; set; }

        public Guid CategorieId { get; set; }
        public Categorie Categorie { get; set; }
    }
}
