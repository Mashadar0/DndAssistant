using System.ComponentModel.DataAnnotations;

namespace DndAssistant.Models
{
    public class Background
    {
        [Display(Name = "Название")]
        public string? Name { get; set; }

        [Display(Name = "Навыки")]
        public List<string>? SkillProficiencies { get; set; }

        [Display(Name = "Языки")]
        public List<string>? Languages { get; set; }

        [Display(Name = "Инструменты")]
        public List<string>? ToolProficiencies { get; set; }
    }
}