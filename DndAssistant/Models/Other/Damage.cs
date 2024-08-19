using static DndAssistant.Scripts.Dictionary;
using System.ComponentModel.DataAnnotations;

namespace DndAssistant.Models.Other
{
    public class DamagePhysical
    {
        [Required]
        [Display(Name = "Количество дайсов")]
        public int DiceCount { get; set; }  // Количество дайсов

        [Required]
        [Display(Name = "Вид дайса")]
        public Dice DiceType { get; set; }  // Вид дайса (например, "d6", "d8")

        [Required]
        [Display(Name = "Тип урона")]
        public DamageTypeFull DamageType { get; set; }  // Тип урона
    }
}
