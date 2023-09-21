using System.ComponentModel.DataAnnotations.Schema;

namespace LMSTUDYwebService.Models
{
    public class AddFormationRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ReqKnowledge { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        [NotMapped]
        public List<string> Objectifs { get; set; }
        public string CategorieName { get; set; }
    }
}
