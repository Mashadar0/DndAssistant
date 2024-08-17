using System.Text.Json;
using System;
using DndAssistant.Models;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using static DndAssistant.Scripts.Dictionary;
using DndAssistant.Models.Items;
using System.Collections.Generic;

namespace DndAssistant.Scripts
{
    public class JsonRW
    {
        private static readonly JsonSerializerOptions options = new()
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true
        };

        // Метод для сохранения данных
        public static async Task SaveDataAsync<T>(string filePath, List<T> data)
        {
            var json = JsonSerializer.Serialize(data, options);
            await File.WriteAllTextAsync(filePath, json);
        }

        // Метод для загрузки данных
        public static async Task<List<T>> LoadDataAsync<T>(string filePath)
        {
            // Проверка существования файла
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The specified file does not exist.", filePath);
            }

            // Чтение содержимого файла
            var json = await File.ReadAllTextAsync(filePath);

            // Десериализация JSON в объект типа T
            var data = JsonSerializer.Deserialize<List<T>>(json)
                ?? throw new InvalidOperationException("Deserialization failed; the JSON data may be invalid or incorrect.");

            return data;
        }

        
    }
}
