using System.Text.Json.Serialization;

namespace DndAssistant.Models
{
    public class Skill
    {
        [JsonPropertyName("Порядковый номер")]
        int Id { get; set; }
        [JsonPropertyName("Название навыка")]
        public string? Name { get; set; }
        [JsonPropertyName("Номер характеристики от которой зависит навык")]
        public int AbilitiId { get; set; }

        //[JsonIgnore]
        //static int Count = 0;


        //public static void ResetCountOfSkill()
        //{
        //    Count = 0;
        //}
    }
}
