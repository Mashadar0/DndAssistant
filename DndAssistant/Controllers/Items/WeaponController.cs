using DndAssistant.Models;
using DndAssistant.Models.Items;
using DndAssistant.Scripts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Linq;
using System.Xml;
using static DndAssistant.Scripts.Dictionary;

namespace DndAssistant.Controllers.Items
{
    public class WeaponController : Controller
    {
        static List<Weapon> weapons = [];
        private static readonly string filePathWeapons = "Data/Items/weapons.json";
        // GET: WeaponController
        public async Task<ActionResult> Index()
        {
            //загрузка данных из файла
            weapons = await JsonRW.LoadDataAsync<Weapon>(filePathWeapons);
            return View("~/Views/Items/Weapon/Index.cshtml", weapons);
        }

        // GET: WeaponController/Create
        public ActionResult Create()
        {
            return View("~/Views/Items/Weapon/Create.cshtml", new Weapon());
        }

        // POST: WeaponController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(/*[Bind("Name,IsExotic,Writing,TypicalRepresentative")]*/ Weapon newWeapon)
        {

            // Чтение существующих данных из JSON-файла
            List<Weapon> weapons = await JsonRW.LoadDataAsync<Weapon>(filePathWeapons);

            // Присвоение уникального Id новому элементу
            if (weapons.Count == 0)
            {
                newWeapon.Id = 1;
            }
            else
            {
                int maxId = weapons.Max(l => l.Id);
                newWeapon.Id = maxId + 1;
            }

            ValidationWeapon(ref newWeapon);

            // Добавление нового элемента в коллекцию
            weapons.Add(newWeapon);

            await JsonRW.SaveDataAsync(filePathWeapons, weapons);

            // Перенаправление на действие Index или другое действие после добавления
            return RedirectToAction("Index");
        }

        // GET: Weapon/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weapons = await JsonRW.LoadDataAsync<Weapon>(filePathWeapons);
            var weapon = weapons.FirstOrDefault(m => m.Id == id);

            if (weapon == null)
            {
                return NotFound();
            }

            return View("~/Views/Items/Weapon/Details.cshtml", weapon);
        }

        // GET: Weapon/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weapons = await JsonRW.LoadDataAsync<Weapon>(filePathWeapons);
            var weapon = weapons.FirstOrDefault(m => m.Id == id);

            if (weapon == null)
            {
                return NotFound();
            }

            return View("~/Views/Items/Weapon/Edit.cshtml", weapon);
        }

        // POST: Weapon/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, /*[Bind("Id,Name,IsExotic,Writing,TypicalRepresentative")]*/ Weapon weapon)
        {
            if (id != weapon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var weapons = await JsonRW.LoadDataAsync<Weapon>(filePathWeapons);
                var existingWeapon = weapons.FirstOrDefault(l => l.Id == id);

                if (existingWeapon != null)
                {
                    weapons.Remove(existingWeapon);
                    ValidationWeapon(ref weapon);
                    weapons.Add(weapon);
                    await JsonRW.SaveDataAsync(filePathWeapons, weapons);
                    return RedirectToAction(nameof(Index));
                }

                return NotFound();
            }

            return View("~/Views/Items/Weapon/Edit.cshtml", weapon);
        }

        // GET: Weapon/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weapons = await JsonRW.LoadDataAsync<Weapon>(filePathWeapons);
            var weapon = weapons.FirstOrDefault(m => m.Id == id);

            if (weapon == null)
            {
                return NotFound();
            }

            return View("~/Views/Items/Weapon/Delete.cshtml", weapon);
        }

        // POST: Weapon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var weapons = await JsonRW.LoadDataAsync<Weapon>(filePathWeapons);
            var weapon = weapons.FirstOrDefault(l => l.Id == id);

            if (weapon != null)
            {
                weapons.Remove(weapon);
                await JsonRW.SaveDataAsync(filePathWeapons, weapons);
            }

            return RedirectToAction(nameof(Index));
        }

        public void ValidationWeapon(ref Weapon weapon)
        {
            if (weapon.IsRanged)
            {
                weapon.IsVersatile = false;
                weapon.HasReach = false;
                weapon.IsThrown = false;
                weapon.IsAmmunition = true;
            }
            if (!weapon.IsRanged && !weapon.IsThrown)
            {
                weapon.RangeLong = null;
                weapon.RangeNormal = null;
            }
            if (!weapon.IsVersatile)
            {
                weapon.DamageTwoHandedVersatile = null;
            }
        }
    }
}
