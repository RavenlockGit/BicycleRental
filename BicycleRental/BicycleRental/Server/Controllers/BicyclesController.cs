using BicycleRental.Server.Data;
using BicycleRental.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BicycleRental.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BicyclesController : ControllerBase
    {
        private readonly DataContext _context;

        public BicyclesController(DataContext context)
        {
            _context = context;
        }

        // GET: Bicycles
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _context.Bicycle.ToListAsync());
        }

        // GET: Bicycles/Details/5
        [HttpGet, Route("Details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Bicycle == null)
            {
                return NotFound();
            }

            var bicycle = await _context.Bicycle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bicycle == null)
            {
                return NotFound();
            }

            return Ok(bicycle);
        }

        // POST: Bicycles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, Route("Create")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Place,Region,Brand,GearCount,TireSize,PrizePerDay,Type,FrontPicture,Picture2,Picture3,Picture4")] Bicycle bicycle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bicycle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return Ok(bicycle);
        }

        // POST: Bicycles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, Route("Edit/{id}")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Place,Region,Brand,GearCount,TireSize,PrizePerDay,Type,FrontPicture,Picture2,Picture3,Picture4")] Bicycle bicycle)
        {
            if (id != bicycle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bicycle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BicycleExists(bicycle.Id))
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
            return Ok(bicycle);
        }

        // POST: Bicycles/Delete/5
        [HttpDelete, Route("Delete/{id}")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            if (_context.Bicycle == null)
            {
                return Problem("Entity set 'DataContext.Bicycle'  is null.");
            }
            var bicycle = await _context.Bicycle.FindAsync(id);
            if (bicycle != null)
            {
                _context.Bicycle.Remove(bicycle);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BicycleExists(int id)
        {
            return _context.Bicycle.Any(e => e.Id == id);
        }
    }
}
