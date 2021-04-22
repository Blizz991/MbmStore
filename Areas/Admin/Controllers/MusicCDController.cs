using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MbmStore.Data;
using MbmStore.Models;

namespace MbmStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MusicCDController : Controller
    {
        private readonly MbmStoreContext _context;

        public MusicCDController(MbmStoreContext context)
        {
            _context = context;
        }

        // GET: Admin/MusicCD
        public async Task<IActionResult> Index()
        {
            return View(await _context.MusicCDs.ToListAsync());
        }

        // GET: Admin/MusicCD/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musicCD = await _context.MusicCDs
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (musicCD == null)
            {
                return NotFound();
            }

            return View(musicCD);
        }

        // GET: Admin/MusicCD/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/MusicCD/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Artist,Label,Publisher,TotalTime,ProductId,Title,Price,ImageFileName,Category")] MusicCD musicCD)
        {
            if (ModelState.IsValid)
            {
                _context.Add(musicCD);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(musicCD);
        }

        // GET: Admin/MusicCD/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musicCD = await _context.MusicCDs.FindAsync(id);
            if (musicCD == null)
            {
                return NotFound();
            }
            return View(musicCD);
        }

        // POST: Admin/MusicCD/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Artist,Label,Publisher,TotalTime,ProductId,Title,Price,ImageFileName,Category")] MusicCD musicCD)
        {
            if (id != musicCD.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(musicCD);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MusicCDExists(musicCD.ProductId))
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
            return View(musicCD);
        }

        // GET: Admin/MusicCD/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musicCD = await _context.MusicCDs
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (musicCD == null)
            {
                return NotFound();
            }

            return View(musicCD);
        }

        // POST: Admin/MusicCD/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var musicCD = await _context.MusicCDs.FindAsync(id);
            _context.MusicCDs.Remove(musicCD);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MusicCDExists(int id)
        {
            return _context.MusicCDs.Any(e => e.ProductId == id);
        }
    }
}
