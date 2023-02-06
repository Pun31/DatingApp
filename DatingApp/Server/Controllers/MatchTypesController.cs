using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatingApp.Server.Data;
using DatingApp.Shared.Domain;
using DatingApp.Server.IRepository;

namespace DatingApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchTypesController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public PlayersController(ApplicationDbContext context)
        public MatchTypesController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Players
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Player>>> GetPlayers()
        public async Task<IActionResult> GetMatchTypes()
        {
            //return await _context.Players.ToListAsync();
            var matchTypes = await _unitOfWork.MatchTypes.GetAll();
            return Ok(matchTypes);
        }

        // GET: api/Players/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Player>> GetPlayer(int id)
        public async Task<IActionResult> GetMatchType(int id)
        {
            //var player = await _context.Players.FindAsync(id);
            var matchtype = await _unitOfWork.MatchTypes.Get(q => q.Id == id);

            if (matchtype == null)
            {
                return NotFound();
            }

            return Ok(matchtype);
        }

        // PUT: api/Players/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMatchType(int id, MatchType matchtype)
        {
            if (id != matchtype.Id)
            {
                return BadRequest();
            }

            //_context.Entry(player).State = EntityState.Modified;
            _unitOfWork.MatchTypes.Update(matchtype);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!PlayerExists(id))
                if (!await MatchTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Players
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MatchType>> PostPlayer(MatchType matchType)
        {
            //_context.Players.Add(player);
            //await _context.SaveChangesAsync();
            await _unitOfWork.MatchTypes.Insert(matchType);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetMatchType", new { id = matchType.Id }, matchType);
        }

        // DELETE: api/Players/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMatchType(int id)
        {
            //var player = await _context.Players.FindAsync(id);
            var matchtype = await _unitOfWork.MatchTypes.Get(q => q.Id == id);
            if (matchtype == null)
            {
                return NotFound();
            }

            //_context.Players.Remove(player);
            //await _context.SaveChangesAsync();
            await _unitOfWork.MatchTypes.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool PlayerExists(int id)
        private async Task<bool> MatchTypeExists(int id)
        {
            //return _context.Players.Any(e => e.Id == id);
            var matchtype = await _unitOfWork.MatchTypes.Get(q => q.Id == id);
            return matchtype != null;
        }
    }
}
