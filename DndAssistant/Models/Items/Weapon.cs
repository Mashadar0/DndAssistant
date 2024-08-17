using DndAssistant.Scripts;
using System.ComponentModel.DataAnnotations;
using static DndAssistant.Scripts.Dictionary;

namespace DndAssistant.Models.Items
{
    public class Weapon : Item
    {
        [Required]
        [Display(Name = "Урон")]
        public DamagePhysical Damage { get; set; } = new();  // Список урона

        [Display(Name = "Кость урона универсального (двумя руками)")]
        public Dice? DamageTwoHandedVersatile { get; set; } // Урон при использовании универсального двумя руками

        [Display(Name = "Воинское")]
        public bool IsMartial { get; set; } = false;  // True для воинского, False для простого

        [Display(Name = "Дальнобойное")]
        public bool IsRanged { get; set; } = false;  // True для дальнобойного, False для рукопашного

        [Display(Name = "Фехтовальное")]
        public bool IsFinesse { get; set; }  // Фехтовальное

        [Display(Name = "Двуручное")]
        public bool IsTwoHanded { get; set; }  // Двуручное оружие

        [Display(Name = "Обычная дальность")]
        public int? RangeNormal { get; set; }  // Обычная дальность

        [Display(Name = "Максимальная дальность")]
        public int? RangeLong { get; set; }  // Максимальная дальность

        [Display(Name = "Боеприпас")]
        public bool IsAmmunition { get; set; }

        [Display(Name = "Досягаемость")]
        public bool HasReach { get; set; }

        [Display(Name = "Легкое")]
        public bool IsLight { get; set; }

        [Display(Name = "Метательное")]
        public bool IsThrown { get; set; }

        [Display(Name = "Специальное")]
        public bool IsSpecial { get; set; }

        [Display(Name = "Перезарядка")]
        public bool RequiresReload { get; set; }

        [Display(Name = "Тяжелое")]
        public bool IsHeavy { get; set; }

        [Display(Name = "Универсальное")]
        public bool IsVersatile { get; set; }
    }
}
