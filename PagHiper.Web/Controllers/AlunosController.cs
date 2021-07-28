using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PagHiper.Domain.Entities.Aluno;
using PagHiper.Infra.Repositories.Interfaces;

namespace PagHiper.Web.Controllers
{
  public class AlunosController : Controller
  {
    private readonly IAlunoRepository _alunoRepository;

    public AlunosController(IAlunoRepository alunoRepository)
    {
      _alunoRepository = alunoRepository;
    }

    // GET: Alunos
    public async Task<IActionResult> Index()
    {
      var listaAlunos = _alunoRepository.GetAll();
      return View(listaAlunos);
    }

    // GET: Alunos/Details/5
    public async Task<IActionResult> Details(Guid id)
    {
      if (id == null)
        return NotFound();

      var aluno = _alunoRepository.GetById(id);

      if (aluno == null)
        return NotFound();

      return View(aluno);
    }

    // GET: Alunos/Create
    public IActionResult Create()
    {
      return View();
    }

    // POST: Alunos/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Aluno aluno)
    {
      if (ModelState.IsValid)
      {
        _alunoRepository.Add(aluno);
        return RedirectToAction(nameof(Index));
      }
      return View(aluno);
    }

    // GET: Alunos/Edit/5
    public async Task<IActionResult> Edit(Guid id)
    {

      var aluno = _alunoRepository.GetById(id);

      if (aluno == null)
        return NotFound();

      return View(aluno);
    }

    // POST: Alunos/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, Aluno aluno)
    {
      if (id != aluno.Id)
        return NotFound();

      if (ModelState.IsValid)
      {
        _alunoRepository.Update(aluno);
      }

      return View(aluno);
    }

    // GET: Alunos/Delete/5
    public async Task<IActionResult> Delete(Guid id)
    {
      if (id == null)
      {
        return NotFound();
      }

      _alunoRepository.Delete(id);


      return View();
    }

    //// POST: Alunos/Delete/5
    //[HttpPost, ActionName("Delete")]
    //[ValidateAntiForgeryToken]
    //public async Task<IActionResult> DeleteConfirmed(Guid id)
    //{
    //	var aluno = await _alunoRepository.Alunos.FindAsync(id);
    //	_alunoRepository.Alunos.Remove(aluno);
    //	await _alunoRepository.SaveChangesAsync();
    //	return RedirectToAction(nameof(Index));
    //}

    //private bool AlunoExists(Guid id)
    //{
    //	return _alunoRepository.Alunos.Any(e => e.Id == id);
    //}
  }
}
