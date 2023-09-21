using LMSTUDYwebService.Data;
using LMSTUDYwebService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
namespace LMSTUDYwebService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UtilisateurController : Controller
    {
        private readonly APIDbContext dbContext;

        public UtilisateurController(APIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
