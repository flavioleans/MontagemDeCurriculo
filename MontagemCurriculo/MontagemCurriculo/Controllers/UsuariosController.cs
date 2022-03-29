using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MontagemCurriculo.Models;
using MontagemCurriculo.ViewModels;

namespace MontagemCurriculo.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly Contexto _context;

        public UsuariosController(Contexto context)
        {
            _context = context;
        }

        // GET: Usuarios/Create
        public IActionResult Registro()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registro([Bind("UsuarioId,Email,Senha")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);

                //registrar informações do login
                InformacaoLogin informacao = new InformacaoLogin
                {
                    UsuarioId = usuario.UsuarioId,
                    EnderecoIp = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                    Data = DateTime.Now.ToShortDateString(),
                    Horario = DateTime.Now.ToLongTimeString()
                };

                _context.Add(informacao);
                await _context.SaveChangesAsync();

                //jogar o id do usuario em uma sessão para utilizar depois
                HttpContext.Session.SetInt32("UsuarioId", usuario.UsuarioId);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, usuario.Email)
                };

                var useIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useIdentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Curriculos");
            }
            return View(usuario);
        }

        [HttpGet]
        public IActionResult Login()
        {
            //limpa sessão caso esteja logado
            if (User.Identity.IsAuthenticated)
                HttpContext.Session.Clear();

            return View();
            
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                //verifica se usuario esta cadastrado
                if (_context.Usuarios.Any(u => u.Email == login.Email && u.Senha == login.Senha))
                {
                    int id = _context.Usuarios.Where(u => u.Email == login.Email && u.Senha == login.Senha).Select(u => u.UsuarioId).Single();

                    //registrar informações do login
                    InformacaoLogin informacao = new InformacaoLogin
                    {
                        UsuarioId = id,
                        EnderecoIp = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                        Data = DateTime.Now.ToShortDateString(),
                        Horario = DateTime.Now.ToLongTimeString()
                    };

                    _context.Add(informacao);
                    await _context.SaveChangesAsync();


                    //jogar o id do usuario em uma sessão para utilizar depois
                    HttpContext.Session.SetInt32("UsuarioId", id);

                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, login.Email)
                };

                    var useIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(useIdentity);
                    await HttpContext.SignInAsync(principal);

                    return RedirectToAction("Index", "Curriculos");
                }
            }

            return View(login);
        }

        //Logout
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Usuarios");
        }

        //VALIDAÇÃO REMOTA Verifica se usuario existe 
        public JsonResult UsuarioExiste(string email)
        {
            if (!_context.Usuarios.Any(e => e.Email == email))
                return Json(true);
            return Json("Email existente");
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Curriculos");
        }
    }
}
