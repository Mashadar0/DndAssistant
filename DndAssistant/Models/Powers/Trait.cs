using System.ComponentModel.DataAnnotations;

namespace DndAssistant.Models.Powers
{
    // Класс для черт расы
    public class Trait
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Название")]
        public string? Name { get; set; }  // Название способности

        [Display(Name = "Описание")]
        public string? Description { get; set; }  // Описание способности

    }
}