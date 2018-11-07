using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AuthFun.Data;
using AuthFun.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using AuthFun.Business;

namespace AuthFun.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private readonly UserManager<IdentityUser> _um;
        private readonly MoviesService _service;

        public MoviesController(MoviesService service, UserManager<IdentityUser> um)
        {
            _um = um;
            _service = service;
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public IEnumerable<Movie> Get(int id)
        {
            return _service.GetMoviesByGenre(id);
        }


        //    [AllowAnonymous]
        //    // GET: Movies
        //    public async Task<IActionResult> Index()
        //    {
        //        return View(await _context.Movies.ToListAsync());
        //    }

        //    // GET: Movies/Details/5
        //    public async Task<IActionResult> Details(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var movie = await _context.Movies
        //            .FirstOrDefaultAsync(m => m.Id == id);
        //        if (movie == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(movie);
        //    }

        //    // GET: Movies/Create
        //    [Authorize(Roles = "ADMIN")]
        //    public IActionResult Create()
        //    {
        //        return View();
        //    }

        //    // POST: Movies/Create
        //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Create([Bind("Title,Description,Rating")] Movie movie)
        //    {

        //        var user = _um.GetUserAsync(HttpContext.User).Result;
        //        movie.UserId = user.Id;



        //        if (ModelState.IsValid)
        //        {
        //            _context.Add(movie);
        //            await _context.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(movie);
        //    }

        //    // GET: Movies/Edit/5
        //    public async Task<IActionResult> Edit(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var movie = await _context.Movies.FindAsync(id);
        //        if (movie == null)
        //        {
        //            return NotFound();
        //        }
        //        return View(movie);
        //    }

        //    // POST: Movies/Edit/5
        //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Rating,UserId")] Movie movie)
        //    {
        //        if (id != movie.Id)
        //        {
        //            return NotFound();
        //        }

        //        if (ModelState.IsValid)
        //        {
        //            try
        //            {
        //                _context.Update(movie);
        //                await _context.SaveChangesAsync();
        //            }
        //            catch (DbUpdateConcurrencyException)
        //            {
        //                if (!MovieExists(movie.Id))
        //                {
        //                    return NotFound();
        //                }
        //                else
        //                {
        //                    throw;
        //                }
        //            }
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(movie);
        //    }

        //    // GET: Movies/Delete/5
        //    public async Task<IActionResult> Delete(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var movie = await _context.Movies
        //            .FirstOrDefaultAsync(m => m.Id == id);
        //        if (movie == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(movie);
        //    }

        //    // POST: Movies/Delete/5
        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> DeleteConfirmed(int id)
        //    {
        //        var movie = await _context.Movies.FindAsync(id);
        //        _context.Movies.Remove(movie);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }

        //    private bool MovieExists(int id)
        //    {
        //        return _context.Movies.Any(e => e.Id == id);
        //    }
    }
}
