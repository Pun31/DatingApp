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
    public class ConsultationsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public PlayersController(ApplicationDbContext context)
        public ConsultationsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Players
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Player>>> GetPlayers()
        public async Task<IActionResult> GetConsultations()
        {
            //return await _context.Players.ToListAsync();
            var consultations = await _unitOfWork.Consultations.GetAll();
            return Ok(consultations);
        }

        // GET: api/Players/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Player>> GetPlayer(int id)
        public async Task<IActionResult> GetConsultation(int id)
        {
            //var player = await _context.Players.FindAsync(id);
            var consultation = await _unitOfWork.Consultations.Get(q => q.Id == id);

            if (consultation == null)
            {
                return NotFound();
            }

            return Ok(consultation);
        }

        // PUT: api/Players/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsultation(int id, Consultation consultation)
        {
            if (id != consultation.Id)
            {
                return BadRequest();
            }

            //_context.Entry(player).State = EntityState.Modified;
            _unitOfWork.Consultations.Update(consultation);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!PlayerExists(id))
                if (!await ConsultationExists(id))
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
        public async Task<ActionResult<Consultation>> PostConsultation(Consultation Consultation)
        {
            //_context.Players.Add(player);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Consultations.Insert(Consultation);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetConsultation", new { id = Consultation.Id }, Consultation);
        }

        // DELETE: api/Players/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsultation(int id)
        {
            //var player = await _context.Players.FindAsync(id);
            var consultation = await _unitOfWork.Consultations.Get(q => q.Id == id);
            if (consultation == null)
            {
                return NotFound();
            }

            //_context.Players.Remove(player);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Consultations.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool PlayerExists(int id)
        private async Task<bool> ConsultationExists(int id)
        {
            //return _context.Players.Any(e => e.Id == id);
            var Consultation = await _unitOfWork.Consultations.Get(q => q.Id == id);
            return Consultation != null;
        }
    }
}

