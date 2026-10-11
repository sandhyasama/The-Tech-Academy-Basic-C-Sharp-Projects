
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Models;
using CarInsurance.Data;

public class InsureeController : Controller
{
    private readonly CarInsuranceContext _context;

    public InsureeController(CarInsuranceContext context)
    {
        _context = context;
    }

    // GET: INSUREES
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Insuree.ToListAsync());
    }

    // GET: INSUREES/Details/5
    public async Task<IActionResult> Details(System.Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var insuree = await _context.Insuree
            .FirstOrDefaultAsync(m => m.Id == id);
        if (insuree == null)
        {
            return NotFound();
        }

        return View(insuree);
    }

    // GET: INSUREES/Create
    public IActionResult Create()
    {
        return View();
    }

    //for ADMIN view
    public IActionResult Admin()
    {
        return View(_context.Insuree.ToList());
    }

    // POST: INSUREES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
    {
        if (ModelState.IsValid)
        {
            //start with a base quote of $50
            decimal quote = 50m;

            //calculate the age of the insuree
            DateTime today = DateTime.Today;
            int age = today.Year - insuree.DateOfBirth.Year;

            //if insuree age is under 18, add $100 to the quote
            if(age <= 18)
            {
                quote += 100m;
            //for age between 19 and 25, adding 50 to quote
            } else if(age >= 19 && age <= 25)
            {
                quote += 50m;
            }
            //for age over 25,adding 25 to the quote
            else if (age > 25)
            {
                quote += 25m;
            }

            //if the car year is before 2000, add $25 to the quote
            if (insuree.CarYear < 2000)
            {
                quote += 25m;
            } // else if the car year is after 2015, add $25 to the quote
            else if (insuree.CarYear > 2015)
            {
                quote += 25m;
            }

            //if the car make is a Porsche, add $25 to the quote
            if(insuree.CarMake == "Porsche")
            {
                quote += 25m;
                //if the car model is a 911 Carrera, add an additional $25 to the quote
                if(insuree.CarModel.ToLower() == "911 Carrera")
                {
                    quote += 25m;
                }
            }

            //add $10 to the quote for every speeding ticket the insuree has
            quote += insuree.SpeedingTickets * 10m;

            //if the insuree has a DUI, add 25% to the quote
            quote *= insuree.DUI ? 1.25m : 1m;

            //if it is full coverage, add 50% to the quote
            quote *= insuree.CoverageType.ToLower() == "full" ? 1.5m : 1m;

            //update calculated quote to the insuree object
            insuree.Quote = quote;


            _context.Add(insuree);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(insuree);
    }

    // GET: INSUREES/Edit/5
    public async Task<IActionResult> Edit(System.Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var insuree = await _context.Insuree.FindAsync(id);
        if (insuree == null)
        {
            return NotFound();
        }
        return View(insuree);
    }

    // POST: INSUREES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(System.Guid? id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
    {
        if (id != insuree.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(insuree);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InsureeExists(insuree.Id))
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
        return View(insuree);
    }

    // GET: INSUREES/Delete/5
    public async Task<IActionResult> Delete(System.Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var insuree = await _context.Insuree
            .FirstOrDefaultAsync(m => m.Id == id);
        if (insuree == null)
        {
            return NotFound();
        }

        return View(insuree);
    }

    // POST: INSUREES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(System.Guid? id)
    {
        var insuree = await _context.Insuree.FindAsync(id);
        if (insuree != null)
        {
            _context.Insuree.Remove(insuree);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool InsureeExists(System.Guid? id)
    {
        return _context.Insuree.Any(e => e.Id == id);
    }
}
