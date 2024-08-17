using DndAssistant.Scripts;
using System.ComponentModel.DataAnnotations;
using static DndAssistant.Scripts.Dictionary;

namespace DndAssistant.Models.Items
{
    public class Weapon : Item
    {
        [Required]
        [Display(Name = "Урон")]
        public List<Damage>? Damages { get; set; } = [new()];  // Список урона

        [Display(Name = "Урон универсального (двумя руками)")]
        public List<Damage>? DamageTwoHandedVersatile { get; set; }  // Урон при использовании универсального двумя руками

        [Display(Name = "Воинское оружие")]
        public bool IsMartial { get; set; } = false;  // True для воинского, False для простого

        [Display(Name = "Дальнобойное оружие")]
        public bool IsRanged { get; set; } = false;  // True для дальнобойного, False для рукопашного

        [Display(Name = "Фехтовальное")]
        public bool IsFinesse { get; set; }  // Фехтовальное

        [Display(Name = "Двуручное")]
        public bool IsTwoHanded { get; set; }  // Двуручное оружие

        [Display(Name = "Обычная дальность")]
        public int RangeNormal { get; set; }  // Обычная дальность

        [Display(Name = "Максимальная дальность")]
        public int RangeLong { get; set; }  // Максимальная дальность

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

        // Конструктор класса
        //public Weapon(
        //    int id,
        //    string name,
        //    string description,
        //    int weight,
        //    Money cost,
        //    string damage,
        //    DamageTypePhysical damageType,
        //    bool isMartial,
        //    bool isRanged,
        //    bool isFinesse,
        //    bool isTwoHanded,
        //    int rangeNormal,
        //    int rangeLong,
        //    bool isAmmunition,
        //    bool hasReach,
        //    bool isLight,
        //    bool isThrown,
        //    bool isSpecial,
        //    bool requiresReload,
        //    bool isHeavy,
        //    bool isVersatile,
        //    string range)
        //{
        //    Id = id;
        //    Name = name;
        //    Description = description;
        //    Weight = weight;
        //    Cost = cost;
        //    Damage = damage;
        //    DamageType = damageType;
        //    IsMartial = isMartial;
        //    IsRanged = isRanged;
        //    IsFinesse = isFinesse;
        //    IsTwoHanded = isTwoHanded;
        //    RangeNormal = rangeNormal;
        //    RangeLong = rangeLong;
        //    IsAmmunition = isAmmunition;
        //    HasReach = hasReach;
        //    IsLight = isLight;
        //    IsThrown = isThrown;
        //    IsSpecial = isSpecial;
        //    RequiresReload = requiresReload;
        //    IsHeavy = isHeavy;
        //    IsVersatile = isVersatile;
        //    Range = range;
        //}

        //public Weapon(int id, string name, string description, int weight, Money cost, string damage, string damageType, bool isFinesse, bool isTwoHanded, bool isRanged, int rangeNormal, int rangeLong)
        //    : base(id, name, description, weight, cost)
        //{
        //    Damage = damage;
        //    DamageType = damageType;
        //    IsFinesse = isFinesse;
        //    IsTwoHanded = isTwoHanded;
        //    IsRanged = isRanged;
        //    RangeNormal = rangeNormal;
        //    RangeLong = rangeLong;
        //}

        //public override string ToString()
        //{
        //    return $"{base.ToString()}, Урон: {Damage}, Тип урона: {DamageType}, Ловкость: {IsFinesse}, Двуручное: {IsTwoHanded}, Дальнобойное: {IsRanged}, Дальность: {RangeNormal}/{RangeLong}";
        //}

        //[Display(Name = "Тип урона")]
        //public DamageType DamageType { get; set; }
        //[Display(Name = "Дистанция полного урона")]
        //public int DistanceFullDamage { get; set; }
        //[Display(Name = "Максимальная дистанция")]
        //public int DistanceTotal { get; set; }
        ////public bool IsSimple { get; set; }
        ////public bool IsAmmunition { get; set; }
        ////public bool IsTwoHanded { get; set; }
        ////public bool IsLong {  get; set; }
        ////public bool IsLightWeight { get; set; }
        ////public bool IsThrowing { get; set; }
        ////public bool IsSpecial { get; set; }
        ////public bool IsReload { get; set; }
        ////public bool IsHeavy { get; set; }
        ////public bool IsUniversal { get; set; }

        //public WeaponRange WeaponRange { get; set; }
        //public WeaponClass WeaponClass { get; set; }
        //public List<WeaponProperty> WeaponProperties { get; set; }
        //public int DamageDiceCount { get; set; }
        //public Dice DamageDice { get; set; }

        ////public Weapon(int id, string name, string description, int weight, int cost, MoneyType moneyType,
        ////              DamageType damageType, int distanceFullDamage, int distanceTotal, WeaponRange weaponRange,
        ////              WeaponClass weaponClass, List<WeaponProperty> weaponProperties)
        ////{
        ////    Id = id;
        ////    Name = name;
        ////    Description = description;
        ////    Weight = weight;
        ////    Cost = cost;
        ////    MoneyType = moneyType;
        ////    DamageType = damageType;
        ////    DistanceFullDamage = distanceFullDamage;
        ////    DistanceTotal = distanceTotal;
        ////    WeaponRange = weaponRange;
        ////    WeaponClass = weaponClass;
        ////    WeaponProperties = weaponProperties;
        ////}
        //public Weapon()
        //{
        //    WeaponProperties = [];
        //}
    }
}
