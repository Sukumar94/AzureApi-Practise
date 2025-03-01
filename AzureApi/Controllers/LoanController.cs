using AzureApi.Entity;
using AzureApi.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AzureApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LoanController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/loan
        [HttpGet]
      
        public async Task<ActionResult<IEnumerable<Loan>>> GetLoans()
        {
            var d =  _context.Database.SqlQueryRaw<Loan>("exec test").ToList();


            return await _context.Loans.ToListAsync();
        }

        // GET: api/loan/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Loan>> GetLoan(int id)
        {
            var loan = await _context.Loans.FindAsync(id);
            if (loan == null) return NotFound();
            return loan;
        }

        // POST: api/loan
        [HttpPost]
        public async Task<ActionResult<Loan>> PostLoan(Loan loan)
        {
            _context.Loans.Add(loan);
            await _context.SaveChangesAsync();
            
            return CreatedAtAction(nameof(GetLoan), new { id = loan.id }, loan);
        }

        // PUT: api/loan/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoan(int id, Loan loan)
        {
            if (id != loan.id) return BadRequest();

            _context.Entry(loan).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/loan/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoan(int id)
        {
            var loan = await _context.Loans.FindAsync(id);
            if (loan == null) return NotFound();

            _context.Loans.Remove(loan);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
