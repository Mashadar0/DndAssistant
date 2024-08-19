using DndAssistant.Models.Other;
using DndAssistant.Scripts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DndAssistant.Controllers
{
    public class LanguageController : Controller
    {
        static List<Language> languages = [];
        private static readonly string filePathLanguages = "Data/languages.json";
        // GET: LanguageController
        public async Task<ActionResult> Index()
        {
            //загрузка данных из файла
            languages = await JsonRW.LoadDataAsync<Language>(filePathLanguages);
            return View(languages);
        }

        // GET: LanguageController/Create
        public ActionResult Create()
        {
            return View(new Language());
        }

        // POST: LanguageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,IsExotic,Writing,TypicalRepresentative")] Language newLanguage)
        {

            // Чтение существующих данных из JSON-файла
            List<Language> languages = await JsonRW.LoadDataAsync<Language>(filePathLanguages);

            // Присвоение уникального Id новому элементу
            if (languages.Count == 0)
            {
                newLanguage.Id = 1;
            }
            else
            {
                int maxId = languages.Max(l => l.Id);
                newLanguage.Id = maxId + 1;
            }

            // Добавление нового элемента в коллекцию
            languages.Add(newLanguage);

            await JsonRW.SaveDataAsync(filePathLanguages, languages);

            // Перенаправление на действие Index или другое действие после добавления
            return RedirectToAction("Index");
        }

        // GET: Language/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var languages = await JsonRW.LoadDataAsync<Language>(filePathLanguages);
            var language = languages.FirstOrDefault(m => m.Id == id);

            if (language == null)
            {
                return NotFound();
            }

            return View(language);
        }

        // GET: Language/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var languages = await JsonRW.LoadDataAsync<Language>(filePathLanguages);
            var language = languages.FirstOrDefault(m => m.Id == id);

            if (language == null)
            {
                return NotFound();
            }

            return View(language);
        }

        // POST: Language/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,IsExotic,Writing,TypicalRepresentative")] Language language)
        {
            if (id != language.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var languages = await JsonRW.LoadDataAsync<Language>(filePathLanguages);
                var existingLanguage = languages.FirstOrDefault(l => l.Id == id);

                if (existingLanguage != null)
                {
                    languages.Remove(existingLanguage);
                    languages.Add(language);
                    await JsonRW.SaveDataAsync(filePathLanguages, languages);
                    return RedirectToAction(nameof(Index));
                }

                return NotFound();
            }

            return View(language);
        }

        // GET: Language/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var languages = await JsonRW.LoadDataAsync<Language>(filePathLanguages);
            var language = languages.FirstOrDefault(m => m.Id == id);

            if (language == null)
            {
                return NotFound();
            }

            return View(language);
        }

        // POST: Language/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var languages = await JsonRW.LoadDataAsync<Language>(filePathLanguages);
            var language = languages.FirstOrDefault(l => l.Id == id);

            if (language != null)
            {
                languages.Remove(language);
                await JsonRW.SaveDataAsync(filePathLanguages, languages);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
