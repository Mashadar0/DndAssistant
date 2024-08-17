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

namespace DndAssistant.Controllers
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
            return View(weapons);
        }

        // GET: WeaponController/Create
        public ActionResult Create()
        {
            return View(new Weapon());
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

            return View(weapon);
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

            return View(weapon);
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
                    weapons.Add(weapon);
                    await JsonRW.SaveDataAsync(filePathWeapons, weapons);
                    return RedirectToAction(nameof(Index));
                }

                return NotFound();
            }

            return View(weapon);
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

            return View(weapon);
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

        //List<Weapon> weapons = [];
        // GET: WeaponController
        //public ActionResult Index()
        //{
        //    //загрузка данных из файла
        //    //weapons = jsonRW.ReadWeapons();

        //    return View(weapons);
        //}

        //// GET: WeaponController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: WeaponController/Create
        //public ActionResult Create()
        //{
        //    //ViewBag.DamageType = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(Enum.GetValues(typeof(DamageType)));
        //    return View();
        //}

        //// POST: WeaponController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection/*, Weapon weapon*/)
        //{
        //    try
        //    {
        //        //weapons = jsonRW.ReadWeapons();

        //        //Weapon newWeapon = new();
        //        //StringValues newValue;
        //        //collection.TryGetValue("Name", out newValue);
        //        //newWeapon.Name = newValue;
        //        //collection.TryGetValue("Description", out newValue);
        //        //newWeapon.Description = newValue;
        //        //collection.TryGetValue("Weight", out newValue);
        //        //newWeapon.Weight = int.Parse(newValue);
        //        //collection.TryGetValue("Cost", out newValue);
        //        //newWeapon.Cost = int.Parse(newValue);
        //        //collection.TryGetValue("MoneyType", out newValue);
        //        //newWeapon.MoneyType = (MoneyType)Enum.Parse(typeof(MoneyType), newValue);
        //        //collection.TryGetValue("DamageType", out newValue);
        //        //newWeapon.DamageType = (DamageType)Enum.Parse(typeof(DamageType), newValue);
        //        //collection.TryGetValue("DistanceFullDamage", out newValue);
        //        //newWeapon.DistanceFullDamage = int.Parse(newValue); 
        //        //collection.TryGetValue("DistanceTotal", out newValue);
        //        //newWeapon.DistanceTotal = int.Parse(newValue);
        //        //collection.TryGetValue("WeaponRange", out newValue);
        //        //newWeapon.WeaponRange = (WeaponRange)Enum.Parse(typeof(WeaponRange), newValue);
        //        //collection.TryGetValue("WeaponClass", out newValue);
        //        //newWeapon.WeaponClass = (WeaponClass)Enum.Parse(typeof(WeaponClass), newValue);
        //        //collection.TryGetValue("WeaponProperties", out newValue);
        //        //foreach (var item in newValue)
        //        //{
        //        //    newWeapon.WeaponProperties.Add((WeaponProperty)Enum.Parse(typeof(WeaponProperty), item));
        //        //}
        //        //collection.TryGetValue("DamageDice", out newValue);
        //        //newWeapon.DamageDice = (Dice)Enum.Parse(typeof(Dice), newValue);
        //        //collection.TryGetValue("DamageDiceCount", out newValue);
        //        //newWeapon.DamageDiceCount = int.Parse(newValue);


        //        //IdCounter idCounter = jsonRW.ReadIdCounter();

        //        //newWeapon.Id = idCounter.WeaponLastId + 1;
        //        //weapons.Add(newWeapon);
        //        //jsonRW.WriteWeapons(weapons);

        //        //idCounter.WeaponLastId++;
        //        //jsonRW.WriteIdCounter(idCounter);



        //        return RedirectToAction(nameof(Index));         
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: WeaponController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: WeaponController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: WeaponController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: WeaponController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
