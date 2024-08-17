using System.ComponentModel.DataAnnotations;

namespace DndAssistant.Models
{
    public class HitPoints
    {
        [Display(Name = "Максимальные очки здоровья")]
        public int Max { get; set; }

        [Display(Name = "Текущие очки здоровья")]
        public int Current { get; set; }

        [Display(Name = "Кости здоровья")]
        public int HitDice { get; set; }
    }
}