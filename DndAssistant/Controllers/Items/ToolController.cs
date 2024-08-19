using DndAssistant.Models.Items;
using DndAssistant.Scripts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DndAssistant.Controllers.Items
{
    public class ToolController : Controller
    {
        static List<Tool> tools = [];
        private static readonly string filePathTools = "Data/Items/tools.json";
        // GET: ToolController
        public async Task<ActionResult> Index()
        {
            //загрузка данных из файла
            tools = await JsonRW.LoadDataAsync<Tool>(filePathTools);
            return View("~/Views/Items/Tool/Index.cshtml", tools);
        }

        // GET: ToolController/Create
        public ActionResult Create()
        {
            return View("~/Views/Items/Tool/Create.cshtml", new Tool());
        }

        // POST: ToolController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(/*[Bind("Name,IsExotic,Writing,TypicalRepresentative")]*/ Tool newTool)
        {

            // Чтение существующих данных из JSON-файла
            List<Tool> tools = await JsonRW.LoadDataAsync<Tool>(filePathTools);

            // Присвоение уникального Id новому элементу
            if (tools.Count == 0)
            {
                newTool.Id = 1;
            }
            else
            {
                int maxId = tools.Max(l => l.Id);
                newTool.Id = maxId + 1;
            }

            // Добавление нового элемента в коллекцию
            tools.Add(newTool);

            await JsonRW.SaveDataAsync(filePathTools, tools);

            // Перенаправление на действие Index или другое действие после добавления
            return RedirectToAction("Index");
        }

        // GET: Tool/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tools = await JsonRW.LoadDataAsync<Tool>(filePathTools);
            var tool = tools.FirstOrDefault(m => m.Id == id);

            if (tool == null)
            {
                return NotFound();
            }

            return View("~/Views/Items/Tool/Details.cshtml", tool);
        }

        // GET: Tool/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tools = await JsonRW.LoadDataAsync<Tool>(filePathTools);
            var tool = tools.FirstOrDefault(m => m.Id == id);

            if (tool == null)
            {
                return NotFound();
            }

            return View("~/Views/Items/Tool/Edit.cshtml", tool);
        }

        // POST: Tool/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, /*[Bind("Id,Name,IsExotic,Writing,TypicalRepresentative")]*/ Tool tool)
        {
            if (id != tool.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var tools = await JsonRW.LoadDataAsync<Tool>(filePathTools);
                var existingTool = tools.FirstOrDefault(l => l.Id == id);

                if (existingTool != null)
                {
                    tools.Remove(existingTool);
                    tools.Add(tool);
                    await JsonRW.SaveDataAsync(filePathTools, tools);
                    return RedirectToAction(nameof(Index));
                }

                return NotFound();
            }

            return View("~/Views/Items/Tool/Edit.cshtml", tool);
        }

        // GET: Tool/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tools = await JsonRW.LoadDataAsync<Tool>(filePathTools);
            var tool = tools.FirstOrDefault(m => m.Id == id);

            if (tool == null)
            {
                return NotFound();
            }

            return View("~/Views/Items/Tool/Delete.cshtml", tool);
        }

        // POST: Tool/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tools = await JsonRW.LoadDataAsync<Tool>(filePathTools);
            var tool = tools.FirstOrDefault(l => l.Id == id);

            if (tool != null)
            {
                tools.Remove(tool);
                await JsonRW.SaveDataAsync(filePathTools, tools);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
