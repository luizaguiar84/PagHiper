using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagHiper.Application.Interfaces;
using PagHiper.Domain.Entities.Common;

namespace PagHiper.Web.Controllers
{
    public class EnderecosController : Controller
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecosController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        // GET: Enderecos
        public async Task<IActionResult> Index()
        {
            var enderecos = _enderecoService.GetAll();
            return View(enderecos);
        }

        // GET: Enderecos/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            
            var endereco = _enderecoService.GetById(id);
            //var endereco = await _context.AlunoEndereco
            //    .Include(e => e.Aluno)
            //    .FirstOrDefaultAsync(m => m.Id == id);
            if (endereco == null)
            {
                return NotFound();
            }

            return View(endereco);
        }

        // GET: Enderecos/Create
        public IActionResult Create()
        {
            //ViewData["AlunoId"] = new SelectList(_context.Aluno, "Id", "Id");
            return View();
        }

        // POST: Enderecos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AlunoId,Cep,Rua,Numero,Complemento,Bairro,Cidade,Uf,Id")] Endereco endereco)
        {
            if (ModelState.IsValid)
            {
                endereco.Id = Guid.NewGuid();
                _enderecoService.Add(endereco);
                return RedirectToAction(nameof(Index));
            }
            //ViewData["AlunoId"] = new SelectList(_context.Aluno, "Id", "Id", endereco.AlunoId);
            return View(endereco);
        }

        // GET: Enderecos/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var endereco = _enderecoService.GetById(id);
            if (endereco == null)
            {
                return NotFound();
            }
            return View(endereco);
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            _enderecoService.Delete(id);
            return RedirectToAction(nameof(Index));
        }   
        
        
        // POST: Enderecos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Endereco endereco)
        {
            if (id != endereco.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _enderecoService.Update(endereco);
                }
                catch (DbUpdateConcurrencyException)
                {
                   
                }
                return RedirectToAction(nameof(Index));
            }
            return View(endereco);
        }
    }
}
