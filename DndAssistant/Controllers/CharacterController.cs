//using DndAssistant.Models;
//using DndAssistant.Scripts;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace DndAssistant.Controllers
//{
//    public class CharacterController : Controller
//    {
//        // GET: CharacterController
//        public ActionResult Index()
//        {
//            return View();
//        }

//        // GET: CharacterController/Details/5
//        public ActionResult Details(int id)
//        {
//            //var character = await JsonDataProvider.LoadCharacterAsync();
//            //return View(character);

//            try
//            {
//                //Character character = await CharacterLoader.LoadCharacterAsync();
//                // Используйте загруженного персонажа
//            }
//            catch (FileNotFoundException ex)
//            {
//                Console.WriteLine($"Ошибка: {ex.Message}");
//                // Обработка ошибки отсутствия файла
//            }
//            catch (InvalidOperationException ex)
//            {
//                Console.WriteLine($"Ошибка: {ex.Message}");
//                // Обработка ошибки десериализации
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
//                // Обработка прочих возможных ошибок
//            }

//            return View();
//        }

//        // GET: CharacterController/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: CharacterController/Create
//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public ActionResult Create(IFormCollection collection)
//        //{
//        //    try
//        //    {
//        //        return RedirectToAction(nameof(Index));
//        //    }
//        //    catch
//        //    {
//        //        return View();
//        //    }
//        //}

//        [HttpPost]
//        public async Task<IActionResult> Create(Character newCharacter)
//        {
//            if (!ModelState.IsValid)
//            {
//                // Если модель недействительна, возвращаем представление с ошибками
//                return View(newCharacter);
//            }

//            // Загружаем существующую коллекцию персонажей
//            var characters = await JsonRW.LoadCharactersAsync();

//            // Добавляем нового персонажа в коллекцию
//            characters.Add(newCharacter);

//            // Сохраняем обновленную коллекцию в JSON-файл
//            await JsonRW.SaveCharactersAsync(characters);

//            // Перенаправляем на страницу с перечнем персонажей или другую целевую страницу
//            return RedirectToAction("Index");
//        }


//        // GET: CharacterController/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: CharacterController/Edit/5
//        [HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public ActionResult Edit(int id, IFormCollection collection)
//        //{
//        //    try
//        //    {
//        //        return RedirectToAction(nameof(Index));
//        //    }
//        //    catch
//        //    {
//        //        return View();
//        //    }
//        //}
//        public async Task<IActionResult> Edit(Character character)
//        {
//            //List<Character> characters = JsonRW.LoadCharacterAsync();
//            //await JsonRW.SaveCharacterAsync(character);
//            return RedirectToAction("Index");
//        }

//        // GET: CharacterController/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: CharacterController/Delete/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}
