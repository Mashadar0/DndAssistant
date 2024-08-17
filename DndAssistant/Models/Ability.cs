using System.Text.Json.Serialization;

namespace DndAssistant.Models
{
    public class Ability
    {
        [JsonPropertyName("Порядковый номер")]
        public int Id { get; set; }
        [JsonPropertyName("Название умения")]
        public string Name { get; set; }
        [JsonPropertyName("Описание")]
        public string Description { get; set; }
        //[JsonPropertyName("Дистанция")]
        //public int Distance { get; set; }

        public Ability(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
