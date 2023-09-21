using LMSTUDYwebService.Data;
using LMSTUDYwebService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace LMSTUDYwebService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormationController : Controller
    {
        private readonly APIDbContext dbContext;

        public FormationController(APIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetFormations()
        {

            return Ok(await dbContext.Formations.ToListAsync());
        }


       
        [HttpGet("ByCategory/{CategorieId}")]
        public async Task<IActionResult> GetFormationsByCategory(Guid CategorieId)
        {
            try
            {
                var formations = await dbContext.Formations
                    .Where(f => f.CategorieId == CategorieId)
                    .ToListAsync();

                return Ok(formations);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error fetching formations: {ex.Message}");
            }
        }



        [HttpPost]
        public async Task<IActionResult> AddFormation(AddFormationRequest addFormationReq)
        {
            // Check if the requested CategorieName exists in the database
            var existingCategory = await dbContext.Categories.FirstOrDefaultAsync(c => c.nomCategorie == addFormationReq.CategorieName);

            if (existingCategory == null)
            {
                // Handle the case where the requested category doesn't exist
                return BadRequest("Invalid CategorieName. The category does not exist.");
            }

            var formation = new Formation()
            {
                Id = Guid.NewGuid(),
                Title = addFormationReq.Title,
                Description = addFormationReq.Description,
                ReqKnowledge = addFormationReq.ReqKnowledge,
                Price = addFormationReq.Price,
                Image = addFormationReq.Image,
                Objectifs = addFormationReq.Objectifs,
                CategorieId = existingCategory.Id 
            };

            await dbContext.Formations.AddAsync(formation);
            await dbContext.SaveChangesAsync();
            return Ok(formation);
        }

    }
}
