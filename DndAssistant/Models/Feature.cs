using System.ComponentModel.DataAnnotations;

namespace DndAssistant.Models
{
    // Класс для уникальных способностей
    public class Feature
    {
        [Display(Name = "Название")]
        public string? Name { get; set; }

        [Display(Name = "Описание")]
        public string? Description { get; set; }
    }
}