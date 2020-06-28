using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Drinkr.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Drinkr.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Drinkr.Controllers
{
    public class HomeController : Controller
    {
        const string SessionId = "Id";
        const string SessionName = "Name";

        private readonly DrinkrContext _context;

        public HomeController(DrinkrContext context)
        {
            _context = context;
        }

        // GET: Carroes/CreateCarroes
        public IActionResult CreateCarroes()
        {
            ViewData["Id"] = HttpContext.Session.GetString(SessionId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Id");
            return View();
        }

        // POST: Carroes/CreateCarroes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCarroes([Bind("Id,Modelo,Marca,Placa,Cor,UsuarioId")] Carro carro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(UserDashboard));
            }
            ViewData["Id"] = HttpContext.Session.GetString(SessionId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Id", carro.UsuarioId);
            return View(carro);
        }

        // GET: Carroes/Delete/5
        public async Task<IActionResult> DeleteCarroes(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carro = await _context.Carro
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carro == null)
            {
                return NotFound();
            }

            return View(carro);
        }

        // POST: Carroes/Delete/5
        [HttpPost, ActionName("DeleteCarroes")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCarroesConfirmed(int id)
        {
            var carro = await _context.Carro.FindAsync(id);
            _context.Carro.Remove(carro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(UserDashboard));
        }

        private bool CarroExists(int id)
        {
            return _context.Carro.Any(e => e.Id == id);
        }

        // GET: Enderecoes/CreateEnderecoes
        public IActionResult CreateEnderecoes()
        {
            ViewData["Id"] = HttpContext.Session.GetString(SessionId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Id");
            return View();
        }

        // POST: Enderecoes/CreateEnderecoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateEnderecoes([Bind("Id,Cep,Rua,Numero,Bairro,Cidade,UsuarioId")] Endereco endereco)
        {
            if (ModelState.IsValid)
            {
                _context.Add(endereco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(UserDashboard));
            }
            ViewData["Id"] = HttpContext.Session.GetString(SessionId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Id", endereco.UsuarioId);
            return View(endereco);
        }

        // GET: Cartaos/CreateCartaos
        public IActionResult CreateCartaos()
        {
            ViewData["Id"] = HttpContext.Session.GetString(SessionId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Id");
            return View();
        }

        // POST: Cartaos/CreateCartaos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCartaos([Bind("Id,Numero,Nome,Validade,UsuarioId")] Cartao cartao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(UserDashboard));
            }
            ViewData["Id"] = HttpContext.Session.GetString(SessionId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Id", cartao.UsuarioId);
            return View(cartao);
        }

        // GET: Cartaos/DeleteCartaos/5
        public async Task<IActionResult> DeleteCartaos(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartao = await _context.Cartao
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cartao == null)
            {
                return NotFound();
            }

            return View(cartao);
        }

        // POST: Cartaos/DeleteCartaos/5
        [HttpPost, ActionName("DeleteCartaos")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCartaosConfirmed(int id)
        {
            var cartao = await _context.Cartao.FindAsync(id);
            _context.Cartao.Remove(cartao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(UserDashboard));
        }

        private bool CartaoExists(int id)
        {
            return _context.Cartao.Any(e => e.Id == id);
        }

        // GET: Enderecoes/DeleteEnderecoes/5
        public async Task<IActionResult> DeleteEnderecoes(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var endereco = await _context.Endereco
                .Include(e => e.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (endereco == null)
            {
                return NotFound();
            }

            return View(endereco);
        }

        // POST: Enderecoes/DeleteEnderecoes/5
        [HttpPost, ActionName("DeleteEnderecoes")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteEnderecoesConfirmed(int id)
        {
            var endereco = await _context.Endereco.FindAsync(id);
            _context.Endereco.Remove(endereco);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(UserDashboard));
        }
        public async Task<IActionResult> UserDashboard()
        {
            if (HttpContext.Session.GetString(SessionId) != "Id")
            {
                ViewData["Nome"] = HttpContext.Session.GetString(SessionName);
                ViewData["Id"] = HttpContext.Session.GetString(SessionId);
                var carroes = await _context.Carro.Where(x => x.UsuarioId.ToString() == HttpContext.Session.GetString(SessionId)).ToListAsync();
                var cartaos = await _context.Cartao.Where(x => x.UsuarioId.ToString() == HttpContext.Session.GetString(SessionId)).ToListAsync();
                var enderecoes = await _context.Endereco.Where(x => x.UsuarioId.ToString() == HttpContext.Session.GetString(SessionId)).ToListAsync();
                UserViewModel userData = new UserViewModel { Carro = carroes, Cartao = cartaos, Endereco = enderecoes };

                return View(userData);
            }
            else
            {
                return RedirectToAction("Index");
            }        
        }

        // GET: Cartaos/CreateUsuarios
        public IActionResult CreateUsuarios()
        {
            return View();
        }

        // POST: Cartaos/CreateUsuarios
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUsuarios([Bind("Nome, Email, Cpf, Telefone, Idade, Password")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }








        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Usuario objUser)
        {
            if (ModelState.IsValid)
            {
                var obj = _context.Usuario.Where(a => a.Email.Equals(objUser.Email) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                if (obj != null)
                {
                    HttpContext.Session.SetString(SessionName, obj.Nome.ToString());
                    HttpContext.Session.SetString(SessionId, obj.Id.ToString());
                    return RedirectToAction("UserDashBoard");
                }
            }
            return View(objUser);
        }

        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
