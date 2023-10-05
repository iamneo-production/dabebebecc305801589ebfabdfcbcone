using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetmicroserviceone.Models;

namespace dotnetmicroserviceone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly ArticleDbContext _context;

        public ArticleController(ArticleDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Article>>> GetAllArticles()
        {
            try
            {
                var data=await _context.articles.ToListAsync();
                if(data!=null)
                {
                    return Ok(data);
                }
                else
                {
                    return NotFound(null);
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        [HttpGet("id")]
        public async Task<ActionResult<Article>> GetArticleById(int id)
        {
            try
            {
                var data =await _context.articles.FirstOrDefaultAsync(u=>u.ArticleID==id);
                if(data!=null)
                {
                    return Ok(data);
                }
                else
                {
                    return NotFound(null);
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        [HttpPost]
        public async Task

    }
}
