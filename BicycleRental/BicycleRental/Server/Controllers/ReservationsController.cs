using BicycleRental.Server.Data;
using BicycleRental.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BicycleRental.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly DataContext _context;

        public ReservationsController(DataContext context)
        {
            _context = context;
        }

        // GET: Reservations
        [HttpGet, Route("{bicycleId}")]
        public async Task<IActionResult> Index(int bicycleId)
        {
            return Ok(await _context.Reservation.Where(x => x.BicycleId == bicycleId).ToListAsync());
        }

        // GET: Reservations/Details/5
        [HttpGet, Route("Details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Reservation == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return Ok(reservation);
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, Route("Create")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BicycleId, StartDate, EndDate")] Reservation reservation)
        {
            if (ModelState.IsValid && await CheckTimeSpan(reservation))
            {
                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return Ok(reservation);
            }
            return BadRequest(reservation);
        }

        private async Task<bool> CheckTimeSpan(Reservation reservation)
        {
            var allReservations = await _context.Reservation.Where(x => x.BicycleId == reservation.BicycleId).ToListAsync();
            bool noOverlap = true;

            foreach (var res in allReservations)
            {
                if (reservation.StartDate.Date <= res.EndDate.Date && res.StartDate.Date <= reservation.EndDate.Date)
                {
                    noOverlap = false;
                }
            }
            return noOverlap;
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, Route("Edit/{id}")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Place,Region,Brand,GearCount,TireSize,PrizePerDay,Type,FrontPicture,Picture2,Picture3,Picture4")] Reservation reservation)
        {
            if (id != reservation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return Ok(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpDelete, Route("Delete/{id}")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            if (_context.Reservation == null)
            {
                return Problem("Entity set 'DataContext.Reservation'  is null.");
            }
            var reservation = await _context.Reservation.FindAsync(id);
            if (reservation != null)
            {
                _context.Reservation.Remove(reservation);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservation.Any(e => e.Id == id);
        }
    }
}
