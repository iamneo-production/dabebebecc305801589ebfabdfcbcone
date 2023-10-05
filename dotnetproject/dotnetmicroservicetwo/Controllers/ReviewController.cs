using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetmicroservicetwo.Models;

namespace dotnetmicroservicetwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly ReviewDbContext _context;

        public ReviewController(ReviewDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review>>> GetAllReviews()
        {
            try
            {
                var data=await _context.reviews.ToListAsync();
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

        [HttpGet("ReviewerNames")]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            try
            {
                var data =await _context.reviews.Select(u=>u.ReviewerName).ToListAsync();
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
        public async Task<ActionResult> AddReview(Review review)
        {
            try
            {
                _context.reviews.Add(review);
                if(await _context.SaveChangesAsync()>0)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        [HttpDelete("id")]
        public async Task<ActionResult> DeleteReview(int id)
        {
            try
            {
                var data=await _context.reviews.Where(a=>a.ReviewID==id).FirstOrDefaultAsync();
                if(data!=null)
                {
                    _context.reviews.Remove(data);
                    if(await _context.SaveChangesAsync()>0)
                    {
                        return Ok();
                    }
                    else
                    {
                        return BadRequest();
                    }
                }
                else
                {
                    return NotFound();
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }



    }
}
