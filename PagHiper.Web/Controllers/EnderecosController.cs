using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagHiper.Domain.Entities.Common;
using PagHiper.Infra;
using PagHiper.Infra.MySql.Context;
using PagHiper.Infra.Repositories.Interfaces;

namespace PagHiper.Web.Controllers
{
    public class EnderecosController : Controller
    {
        private readonly IEnderecoRepository _context;

        public EnderecosController(IEnderecoRepository context)
        {
            _context = context;
        }

        // GET: Enderecos
        public async Task<IActionResult> Index()
        {
            var enderecos = _context.GetAll();
            return View(enderecos);
        }

        // GET: Enderecos/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var endereco = _context.GetById(id);
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
        //public IActionResult Create()
        //{
        //    ViewData["AlunoId"] = new SelectList(_context.Aluno, "Id", "Id");
        //    return View();
        //}

        // POST: Enderecos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("AlunoId,Cep,Rua,Numero,Complemento,Bairro,Cidade,Uf,Id")] Endereco endereco)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        endereco.Id = Guid.NewGuid();
        //        _context.Add(endereco);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["AlunoId"] = new SelectList(_context.Aluno, "Id", "Id", endereco.AlunoId);
        //    return View(endereco);
        //}

        // GET: Enderecos/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var endereco = _context.GetById(id);
            if (endereco == null)
            {
                return NotFound();
            }
            return View(endereco);
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
                    _context.Update(endereco);
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
