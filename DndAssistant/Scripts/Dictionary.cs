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
            Bludgeoning
        }

        public enum DamageType
        {
            [Display(Name = "Колющий")]
            Stabbing,
            [Display(Name = "рубящий")]
            Chopping,
            [Display(Name = "дробящий")]
            Crushing,
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

        //public enum WeaponType
        //{
        //    [Display(Name = "Простое")]
        //    Simple,
        //    [Display(Name = "Воинское")]
        //    Martial
        //}

        //public enum WeaponCategory
        //{
        //    [Display(Name = "Рукопашное")]
        //    Melee,
        //    [Display(Name = "Дальнобойное")]
        //    Ranged
        //}

        //public enum WeaponProperty
        //{
        //    [Display(Name = "Боеприпас>")]
        //    Ammunition,
        //    [Display(Name = "Двуручное")]
        //    TwoHanded,
        //    [Display(Name = "Досягаемость")]
        //    Long,
        //    [Display(Name = "Легкое")]
        //    LightWeight,
        //    [Display(Name = "Метательное")]
        //    Throwing,
        //    [Display(Name = "Специальное")]
        //    Special,
        //    [Display(Name = "Перезарядка")]
        //    Reload,
        //    [Display(Name = "Тяжелое")]
        //    Heavy,
        //    [Display(Name = "Универсальное")]
        //    Universal,
        //    [Display(Name = "Фехтовальное")]
        //    Fencing,
        //    [Display(Name = "Нет")]
        //    None
        //}

        //public enum MoneyType
        //{
        //    [Display(Name = "Медь")]
        //    Copper,
        //    [Display(Name = "Серебро")]
        //    Silver,
        //    [Display(Name = "Золото")]
        //    Gold
        //}

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
            d100 = 100
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
    }
}
