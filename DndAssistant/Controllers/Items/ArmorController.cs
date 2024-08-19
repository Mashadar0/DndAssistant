using DndAssistant.Models.Items;
using DndAssistant.Scripts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DndAssistant.Controllers.Items
{
    public class ArmorController : Controller
    {
        static List<Armor> armors = [];
        private static readonly string filePathArmors = "Data/Items/armors.json";
        // GET: ArmorController
        public async Task<ActionResult> Index()
        {
            //загрузка данных из файла
            armors = await JsonRW.LoadDataAsync<Armor>(filePathArmors);
            return View("~/Views/Items/Armor/Index.cshtml", armors);
        }

        // GET: ArmorController/Create
        public ActionResult Create()
        {
            return View("~/Views/Items/Armor/Create.cshtml", new Armor());
        }

        // POST: ArmorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(/*[Bind("Name,IsExotic,Writing,TypicalRepresentative")]*/ Armor newArmor)
        {

            // Чтение существующих данных из JSON-файла
            List<Armor> armors = await JsonRW.LoadDataAsync<Armor>(filePathArmors);

            // Присвоение уникального Id новому элементу
            if (armors.Count == 0)
            {
                newArmor.Id = 1;
            }
            else
            {
                int maxId = armors.Max(l => l.Id);
                newArmor.Id = maxId + 1;
            }

            // Добавление нового элемента в коллекцию
            armors.Add(newArmor);

            await JsonRW.SaveDataAsync(filePathArmors, armors);

            // Перенаправление на действие Index или другое действие после добавления
            return RedirectToAction("Index");
        }

        // GET: Armor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var armors = await JsonRW.LoadDataAsync<Armor>(filePathArmors);
            var armor = armors.FirstOrDefault(m => m.Id == id);

            if (armor == null)
            {
                return NotFound();
            }

            return View("~/Views/Items/Armor/Details.cshtml", armor);
        }

        // GET: Armor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var armors = await JsonRW.LoadDataAsync<Armor>(filePathArmors);
            var armor = armors.FirstOrDefault(m => m.Id == id);

            if (armor == null)
            {
                return NotFound();
            }

            return View("~/Views/Items/Armor/Edit.cshtml", armor);
        }

        // POST: Armor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, /*[Bind("Id,Name,IsExotic,Writing,TypicalRepresentative")]*/ Armor armor)
        {
            if (id != armor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var armors = await JsonRW.LoadDataAsync<Armor>(filePathArmors);
                var existingArmor = armors.FirstOrDefault(l => l.Id == id);

                if (existingArmor != null)
                {
                    armors.Remove(existingArmor);
                    armors.Add(armor);
                    await JsonRW.SaveDataAsync(filePathArmors, armors);
                    return RedirectToAction(nameof(Index));
                }

                return NotFound();
            }

            return View("~/Views/Items/Armor/Edit.cshtml", armor);
        }

        // GET: Armor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var armors = await JsonRW.LoadDataAsync<Armor>(filePathArmors);
            var armor = armors.FirstOrDefault(m => m.Id == id);

            if (armor == null)
            {
                return NotFound();
            }

            return View("~/Views/Items/Armor/Delete.cshtml", armor);
        }

        // POST: Armor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var armors = await JsonRW.LoadDataAsync<Armor>(filePathArmors);
            var armor = armors.FirstOrDefault(l => l.Id == id);

            if (armor != null)
            {
                armors.Remove(armor);
                await JsonRW.SaveDataAsync(filePathArmors, armors);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
