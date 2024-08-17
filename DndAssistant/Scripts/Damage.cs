using static DndAssistant.Scripts.Dictionary;
using System.ComponentModel.DataAnnotations;

namespace DndAssistant.Scripts
{
    public class Damage
    {
        [Required]
        [Display(Name = "Количество дайсов")]
        public int DiceCount { get; set; }  // Количество дайсов

        [Required]
        [Display(Name = "Вид дайса")]
        public Dice DiceType { get; set; }  // Вид дайса (например, "d6", "d8")

        [Required]
        [Display(Name = "Тип урона")]
        public DamageType DamageType { get; set; }  // Тип урона

        //public Damage(int diceCount, Dice diceType, DamageType damageType)
        //{
        //    DiceCount = diceCount;
        //    DiceType = diceType;
        //    DamageType = damageType;
        //}
    }
}
