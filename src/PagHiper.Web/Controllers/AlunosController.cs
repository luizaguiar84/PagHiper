using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PagHiper.Application.Interfaces;
using PagHiper.Domain.Entities.Aluno;

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
		public IActionResult Index()
		{
			_logger.LogInformation("teste");
			var listaAlunos = _alunoService.GetAll();
			return View(listaAlunos);
		}

		// GET: Aluno/Details/5
		public IActionResult Details(int id)
		{
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
		public IActionResult Create(Aluno aluno)
		{
			if (ModelState.IsValid)
			{
				_alunoService.Add(aluno);
				return RedirectToAction(nameof(Index));
			}
			return View(aluno);
		}

		// GET: Aluno/Edit/5
		public IActionResult Edit(int id)
		{

			var aluno = _alunoService.GetById(id);

			if (aluno == null)
				return NotFound();

			return View(aluno);
		}

		// POST: Aluno/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(int id, Aluno aluno)
		{
			if (id != aluno.Id)
				return NotFound();

			_alunoService.Update(aluno);

			return View(aluno);
		}

		// GET: Aluno/Delete/5
		public IActionResult Delete(int id)
		{
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
