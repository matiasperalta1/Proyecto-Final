using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProyectoFinalElectricidadSeret.Data;
using ProyectoFinalElectricidadSeret.Models;

namespace ProyectoFinalElectricidadSeret.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Usuario/Login
        public IActionResult Login()
        {
            return View();
        }

        // GET: Usuario/LoginUser
        [HttpPost]
        public async Task<IActionResult> LoginUser(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var usr = await _context.Usuarios.Where(u => u.UsuNombre == usuario.UsuNombre & u.UsuContras == usuario.UsuContras).FirstOrDefaultAsync();

                if (usr == null)
                {
                    ViewBag.ErrorMessage = "Usuario o Contraseña Incorrectos";
                    return RedirectToAction("Login");
                }
                else
                {
                    HttpContext.Session.SetString("currentUser", JsonConvert.SerializeObject(usr));
                    IEnumerable<MenuLvl1> menus = await GetMenus(usr.UsuCodusu);
                    HttpContext.Session.SetString("userMenu", JsonConvert.SerializeObject(menus));
                    return RedirectToAction("Index", "Home");
                }
            }
            return RedirectToAction("Index", "Home");
        }

        public async Task<List<MenuLvl1>> GetMenus(int codUsu)
        {
            List<MenuLvl1> menus = new List<MenuLvl1>();
            IEnumerable<int> menuIds = await _context.UsuaMenus.Where(m => m.UymCodusu == codUsu).Select(m => m.UymCodmen).ToListAsync();
            IEnumerable<string> menusLvl1 = await _context.Menus.Where(m => menuIds.Contains(m.MenCodmen)).Select(m => m.MenMenu).Distinct().ToListAsync();
            foreach (string menulvl1 in menusLvl1)
            {
                MenuLvl1 menuItem = await MapMenuLvl1(menulvl1, menuIds);
                menus.Add(menuItem);
            }
            return menus;
        }

        public async Task<MenuLvl1> MapMenuLvl1(string menuName, IEnumerable<int> userIds)
        {
            MenuLvl1 menuLvl1 = new MenuLvl1();
            IEnumerable<Menu> menu = await _context.Menus.Where(m => m.MenMenu == menuName && userIds.Contains(m.MenCodmen)).ToListAsync();
            menuLvl1.Lvl1_MenuName =  menu.First().MenMenu;
            menuLvl1.Lvl1_MenuOrder = menu.First().MenMenord;
            menuLvl1.Lvl2_MenuItems = new List<MenuLvL2>();
            IEnumerable<string> menusLvl2 = menu.Where(m => m.MenMenu == menuName && userIds.Contains(m.MenCodmen)).Select(m => m.MenSubmen).Distinct();
            foreach (string menuLvl2 in menusLvl2)
            {
                menuLvl1.Lvl2_MenuItems.Add(await MapMenuLvl2(menuName, menuLvl2, userIds));
            }
            return menuLvl1;
        }

        public async Task<MenuLvL2> MapMenuLvl2(string menuiLvl1Name, string menuLvl2Name, IEnumerable<int> userIds)
        {
            MenuLvL2 menuLvL2 = new MenuLvL2();
            menuLvL2.Lvl2_MenuItem = new MenuItem();
            IEnumerable<Menu> menu = await _context.Menus.Where(m => m.MenSubmen == menuLvl2Name && m.MenMenu==menuiLvl1Name && userIds.Contains(m.MenCodmen)).ToListAsync();
            menuLvL2.Lvl2_MenuItem.MenuItemName = await _context.Menus.Where(m => m.MenSubmen == menuLvl2Name).Select(m => m.MenSubmen).FirstOrDefaultAsync();
            menuLvL2.Lvl2_MenuItem.MenuItemOrder = await _context.Menus.Where(m => m.MenSubmen == menuLvl2Name).Select(m => m.MenSbmord).FirstOrDefaultAsync();
            if (menu.Count() == 1)
            {
                menuLvL2.Lvl2_MenuItem.MenuItemAction = menu.First().MenAction;
                menuLvL2.Lvl2_MenuItem.MenuItemController = menu.First().MenController;
            }
            else
            {
                menuLvL2.Lvl3_MenuItems = new List<MenuItem>();
                foreach (Menu subMen in menu)
                {
                    MenuItem menuItem = new MenuItem();
                    menuItem.MenuItemAction = subMen.MenAction;
                    menuItem.MenuItemController = subMen.MenController;
                    menuItem.MenuItemName = subMen.MenSsbmen;
                    menuItem.MenuItemOrder = subMen.MenSsbord;
                    menuLvL2.Lvl3_MenuItems.Add(menuItem);
                }
            }
            return menuLvL2;
        }


        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuarios.ToListAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.UsuCodusu == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UsuCodusu,UsuApeyno,UsuNombre,UsuContras,UsuCatusu,UsuAccrap,UsuObserv,UsuPin")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UsuCodusu,UsuApeyno,UsuNombre,UsuContras,UsuCatusu,UsuAccrap,UsuObserv,UsuPin")] Usuario usuario)
        {
            if (id != usuario.UsuCodusu)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.UsuCodusu))
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
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.UsuCodusu == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.UsuCodusu == id);
        }
    }
}
