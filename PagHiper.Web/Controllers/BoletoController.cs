using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagHiper.Application.Interfaces;
using PagHiper.Domain.Entities;
using PagHiper.Infra;
using Paghiper.Infra.Sqlite.Context;

namespace PagHiper.Web.Controllers
{
    
    public class BoletoController : Controller
    {
        private readonly CrudDbSqlite _context;
        private readonly IBoletoService _boletoService;

        public BoletoController(CrudDbSqlite context, IBoletoService boletoService)
        {
            _context = context;
            _boletoService = boletoService;
        }

        // GET: Boleto
        public async Task<IActionResult> Index()
        {
            return View(await _context.Boletos.ToListAsync());
        }

        // GET: Boleto/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boleto = await _context.Boletos
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (boleto == null)
            {
                return NotFound();
            }

            return View(boleto);
        }

        // GET: Boleto/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Boleto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ApiKey,OrderId,payer_email,PayerName,PayerCpfCnpj,PayerPhone,PayerStreet,PayerNumber,PayerComplement,PayerDistrict,PayerCity,PayerState,PayerZipCode,NotificationUrl,DiscountCents,ShippingPriceCents,ShippingMethods,FixedDescription,DaysDueDate,TypeBankSlip")] Boleto boleto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(boleto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(boleto);
        }

        // GET: Boleto/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boleto = await _context.Boletos.FindAsync(id);
            if (boleto == null)
            {
                return NotFound();
            }
            return View(boleto);
        }

        // POST: Boleto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ApiKey,OrderId,payer_email,PayerName,PayerCpfCnpj,PayerPhone,PayerStreet,PayerNumber,PayerComplement,PayerDistrict,PayerCity,PayerState,PayerZipCode,NotificationUrl,DiscountCents,ShippingPriceCents,ShippingMethods,FixedDescription,DaysDueDate,TypeBankSlip")] Boleto boleto)
        {
            if (id != boleto.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(boleto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoletoExists(boleto.OrderId))
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
            return View(boleto);
        }

        // GET: Boleto/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boleto = await _context.Boletos
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (boleto == null)
            {
                return NotFound();
            }

            return View(boleto);
        }

        // POST: Boleto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var boleto = await _context.Boletos.FindAsync(id);
            _context.Boletos.Remove(boleto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BoletoExists(string id)
        {
            return _context.Boletos.Any(e => e.OrderId == id);
        }
    }
}
