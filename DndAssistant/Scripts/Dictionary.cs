using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DndAssistant.Scripts
{
    public class Dictionary
    {
        public enum Alignment
        {
            [Display(Name = "Законно-Добрый")]
            LawfulGood,

            [Display(Name = "Законно-Нейтральный")]
            LawfulNeutral,

            [Display(Name = "Законно-Злой")]
            LawfulEvil,

            [Display(Name = "Нейтрально-Добрый")]
            NeutralGood,

            [Display(Name = "Истинно-Нейтральный")]
            TrueNeutral,

            [Display(Name = "Нейтрально-Злой")]
            NeutralEvil,

            [Display(Name = "Хаотично-Добрый")]
            ChaoticGood,

            [Display(Name = "Хаотично-Нейтральный")]
            ChaoticNeutral,

            [Display(Name = "Хаотично-Злой")]
            ChaoticEvil
        }

        public enum DamageTypePhysical
        {
            [Display(Name = "Колющий")]
            Piercing,
            [Display(Name = "Рубящий")]
            Slashing,
            [Display(Name = "Дробящий")]
            Bludgeoning,
            [Display(Name = "")]
            None
        }

        public enum DamageTypeFull
        {
            [Display(Name = "Колющий")]
            Stabbing,
            [Display(Name = "рубящий")]
            Chopping, 
            [Display(Name = "дробящий")]
            Crushing,
            [Display(Name = "")]
            None,
            [Display(Name = "кислотный")]
            Acidic,
            [Display(Name = "холодный")]
            Cold,
            [Display(Name = "огненный")]
            Fiery,
            [Display(Name = "силовой")]
            Forceful,
            [Display(Name = "электрический")]
            Electric,
            [Display(Name = "громовой")]
            Thunderous,
            [Display(Name = "некротический")]
            Necrotic,
            [Display(Name = "психический")]
            Psychic,
            [Display(Name = "ядовитый")]
            Poisonous,
            [Display(Name = "сияющий")]
            Radiant,
            [Display(Name = "иссушающий")]
            Withering
        }

        public enum Dice
        {
            [Display(Name = "d4")]
            d4 = 4,
            [Display(Name = "d6")]
            d6 = 6,
            [Display(Name = "d8")]
            d8 = 8,
            [Display(Name = "d10")]
            d10 = 10,
            [Display(Name = "d12")]
            d12 = 12,
            [Display(Name = "d20")]
            d20 = 20,
            [Display(Name = "d100")]
            d100 = 100,
            [Display(Name = "")]
            None
        }

        public enum ArmorClass
        {
            [Display(Name = "Легкая")]
            Light,
            [Display(Name = "Средняя")]
            Medium,
            [Display(Name = "Тяжелая")]
            High,
            [Display(Name = "Щит")]
            Shield
        }

        public enum CreatureSize
        {
            [Display(Name = "Маленький")]
            Small,
            [Display(Name = "Средний")]
            Medium,
            [Display(Name = "Большой")]
            Large
        }
    }
}
