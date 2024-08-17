using System.ComponentModel.DataAnnotations;

namespace DndAssistant.Models
{
    public class AbilityScores
    {
        [Display(Name = "Сила")]
        public int Strength { get; set; }

        [Display(Name = "Ловкость")]
        public int Dexterity { get; set; }

        [Display(Name = "Телосложение")]
        public int Constitution { get; set; }

        [Display(Name = "Интеллект")]
        public int Intelligence { get; set; }

        [Display(Name = "Мудрость")]
        public int Wisdom { get; set; }

        [Display(Name = "Харизма")]
        public int Charisma { get; set; }
    }
}