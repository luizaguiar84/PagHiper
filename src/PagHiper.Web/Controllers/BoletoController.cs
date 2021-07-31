using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagHiper.Application.Interfaces;
using PagHiper.Domain.Entities;

namespace PagHiper.Web.Controllers
{
    public class BoletoController : Controller
    {
        private readonly IBoletoService _boletoService;

        public BoletoController(IBoletoService boletoService)
        {
            _boletoService = boletoService;
        }

        // GET: Boleto
        public IActionResult Index()
        {
             var boletos = _boletoService.GetAll();
             return View();
        }

        // GET: Boleto/Details/5
        public IActionResult Details(Guid id)
        {
            var boleto = _boletoService.GetById(id);
            // await _context.Boleto
            // .FirstOrDefaultAsync(m => m.OrderId == id);
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
        public async Task<IActionResult> Create(
            [Bind(
                "ApiKey,OrderId,payer_email,PayerName,PayerCpfCnpj,PayerPhone,PayerStreet,PayerNumber,PayerComplement,PayerDistrict,PayerCity,PayerState,PayerZipCode,NotificationUrl,DiscountCents,ShippingPriceCents,ShippingMethods,FixedDescription,DaysDueDate,TypeBankSlip")]
            Boleto boleto)
        {
            if (ModelState.IsValid)
            {
                _boletoService.Add(boleto);
                return RedirectToAction(nameof(Index));
            }

            return View(boleto);
        }

        // GET: Boleto/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var boleto = _boletoService.GetById(id);
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
        public IActionResult Edit(Guid id,
            [Bind(
                "ApiKey,OrderId,payer_email,PayerName,PayerCpfCnpj,PayerPhone,PayerStreet,PayerNumber,PayerComplement,PayerDistrict,PayerCity,PayerState,PayerZipCode,NotificationUrl,DiscountCents,ShippingPriceCents,ShippingMethods,FixedDescription,DaysDueDate,TypeBankSlip")]
            Boleto boleto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _boletoService.Update(boleto);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoletoExists(id))
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
        public IActionResult Delete(Guid id)
        {
            var boleto = _boletoService.GetById(id);
            if (boleto == null)
            {
                return NotFound();
            }

            return View(boleto);
        }

        // POST: Boleto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var boleto = _boletoService.GetById(id);
            _boletoService.Remove(boleto);

            return RedirectToAction(nameof(Index));
        }

        private bool BoletoExists(Guid id)
        {
            return _boletoService.Exists(id);
            // _context.Boleto.Any(e => e.OrderId == id);
        }
    }
}