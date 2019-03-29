using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Repositorio.AcessoBanco.Contextos;
using Repositorio.AcessoBanco.Entidades;
using Repositorio.AcessoBanco.Repositorios.UnitOfWork;

namespace Repositorio.Web.Controllers
{
    public class JogadorController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public JogadorController(ContextoAcessoBanco context, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Jogadors
        public IActionResult Index()
        {
            return View(_unitOfWork.Jogadores.GetAll());
        }

        // GET: Jogadors/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jogador = _unitOfWork.Jogadores.Get(id);

            if (jogador == null)
            {
                return NotFound();
            }

            return View(jogador);
        }

        // GET: Jogadors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Jogadors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("JogadorId,Nome")] Jogador jogador)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Jogadores.Add(jogador);
                _unitOfWork.Commit();

                return RedirectToAction(nameof(Index));
            }
            return View(jogador);
        }

        // GET: Jogadors/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jogador = _unitOfWork.Jogadores.Get(id);

            if (jogador == null)
            {
                return NotFound();
            }
            return View(jogador);
        }

        // POST: Jogadors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("JogadorId,Nome")] Jogador jogador)
        {
            if (id != jogador.JogadorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.Jogadores.Update(jogador);
                    _unitOfWork.Commit();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JogadorExists(jogador.JogadorId))
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

            return View(jogador);
        }

        // GET: Jogadors/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jogador = _unitOfWork.Jogadores.Get(id);

            if (jogador == null)
            {
                return NotFound();
            }

            return View(jogador);
        }

        // POST: Jogadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var jogador = _unitOfWork.Jogadores.Get(id);
            _unitOfWork.Jogadores.Remove(jogador);
            _unitOfWork.Commit();

            return RedirectToAction(nameof(Index));
        }

        private bool JogadorExists(int id)
        {
            return (_unitOfWork.Jogadores.Get(id) != null);
        }
    }
}
