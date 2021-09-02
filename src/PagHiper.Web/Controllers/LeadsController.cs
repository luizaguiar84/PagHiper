using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagHiper.Domain.Entities;
using PagHiper.Infra.Context;

namespace PagHiper.Web.Controllers
{
	public class LeadsController : Controller
	{
		private readonly CrudDbContext _context;

		public LeadsController(CrudDbContext context)
		{
			_context = context;
		}

		// GET: Leads
		public async Task<IActionResult> Index()
		{
			return View(await _context.Leads.ToListAsync());
		}
        public IActionResult Final()
        {
            return View();
        }
		// GET: Leads/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var lead = await _context.Leads
				.FirstOrDefaultAsync(m => m.Id == id);
			if (lead == null)
			{
				return NotFound();
			}

			return View(lead);
		}

		// GET: Leads/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Leads/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to, for 
		// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Nome,Email,Telefone,Id, Cupom, AceitaPropaganda")] Lead lead)
		{
			if (ModelState.IsValid)
			{
				//lead.Id = Guid.NewGuid();
				lead.DataCadastro = DateTime.Now;
				lead.LastUpdate = DateTime.Now;

				_context.Add(lead);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Final));
			}

			return View(lead);
		}

		// GET: Leads/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var lead = await _context.Leads.FindAsync(id);
			if (lead == null)
			{
				return NotFound();
			}
			return View(lead);
		}

		// POST: Leads/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to, for 
		// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("DataCadastro, Nome,Email,Telefone,Id")] Lead lead)
		{
			if (id != lead.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					lead.LastUpdate = DateTime.Now;

					_context.Update(lead);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!LeadExists(lead.Id))
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
			return View(lead);
		}

		// GET: Leads/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var lead = await _context.Leads
				.FirstOrDefaultAsync(m => m.Id == id);
			if (lead == null)
			{
				return NotFound();
			}

			return View(lead);
		}

		// POST: Leads/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var lead = await _context.Leads.FindAsync(id);
			_context.Leads.Remove(lead);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool LeadExists(int id)
		{
			return _context.Leads.Any(e => e.Id == id);
		}
	}
}
