using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PagHiper.Application.Interfaces;
using PagHiper.Domain.Entities.Aluno;
using ILogger = Serilog.ILogger;

namespace PagHiper.Web.Controllers
{
	public class AlunosController : Controller
	{
		private readonly IAlunoService _alunoService;
		private readonly ILogger<AlunosController> _logger;

		public AlunosController(IAlunoService alunoService, ILogger<AlunosController> logger)
		{
			this._logger = logger;
			_alunoService = alunoService;
		}


		// GET: Aluno
		public async Task<IActionResult> Index()
		{
			_logger.LogInformation("teste");
			var listaAlunos = _alunoService.GetAll();
			return View(listaAlunos);
		}

		// GET: Aluno/Details/5
		public async Task<IActionResult> Details(Guid id)
		{
			if (id == null)
				return NotFound();

			var aluno = _alunoService.GetById(id);

			if (aluno == null)
				return NotFound();

			return View(aluno);
		}

		// GET: Aluno/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Aluno/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to, for 
		// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(Aluno aluno)
		{
			if (ModelState.IsValid)
			{
				_alunoService.Add(aluno);
				return RedirectToAction(nameof(Index));
			}
			return View(aluno);
		}

		// GET: Aluno/Edit/5
		public async Task<IActionResult> Edit(Guid id)
		{

			var aluno = _alunoService.GetById(id);

			if (aluno == null)
				return NotFound();

			return View(aluno);
		}

		// POST: Aluno/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(Guid id, Aluno aluno)
		{
			if (id != aluno.Id)
				return NotFound();

			_alunoService.Update(aluno);

			return View(aluno);
		}

		// GET: Aluno/Delete/5
		public async Task<IActionResult> Delete(Guid id)
		{
			if (id == null)
			{
				return NotFound();
			}

			_alunoService.Delete(id);


			return View();
		}

		//// POST: Aluno/Delete/5
		//[HttpPost, ActionName("Delete")]
		//[ValidateAntiForgeryToken]
		//public async Task<IActionResult> DeleteConfirmed(Guid id)
		//{
		//	var aluno = await _alunoRepository.Aluno.FindAsync(id);
		//	_alunoRepository.Aluno.Remove(aluno);
		//	await _alunoRepository.SaveChangesAsync();
		//	return RedirectToAction(nameof(Index));
		//}

		//private bool AlunoExists(Guid id)
		//{
		//	return _alunoRepository.Aluno.Any(e => e.Id == id);
		//}
	}
}
