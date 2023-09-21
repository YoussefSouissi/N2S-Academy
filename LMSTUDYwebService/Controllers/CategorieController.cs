using LMSTUDYwebService.Data;
using LMSTUDYwebService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LMSTUDYwebService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategorieController : Controller
    {
        private readonly APIDbContext dbContext;

        public CategorieController(APIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetCategories()
        {
            
            return Ok(dbContext.Categories.ToList());
        }


        [HttpPost]
        public async  Task <IActionResult> AddCategories(AddCategorieRequest addCategorieReq) { var categorie = new Categorie()
        {
            Id = Guid.NewGuid(),
            nomCategorie = addCategorieReq.nomCategorie
            };
           await dbContext.Categories.AddAsync(categorie);
            await dbContext.SaveChangesAsync();
            return Ok(dbContext.Categories);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteCategories([FromRoute] Guid id)
        {
            var categorie = await dbContext.Categories.FindAsync(id);
            if (categorie != null)
            {
                dbContext.Remove(categorie);
                await dbContext.SaveChangesAsync();
                return Ok("Categorie deleted successfully");
            }
            return NotFound();
        }
       

    }
}
