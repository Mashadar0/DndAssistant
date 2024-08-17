//using DndAssistant.Models.Items;
//using System.ComponentModel.DataAnnotations;

//namespace DndAssistant.Scripts
//{
//    public class Weapon : Item
//    {
//        [Key]
//        public int Id { get; set; }

//        [Display(Name = "Название")]
//        public string Name { get; set; }

//        [Display(Name = "Урон")]
//        public string Damage { get; set; }

//        [Display(Name = "Тип урона")]
//        public string DamageType { get; set; }

//        [Display(Name = "Вес")]
//        public double Weight { get; set; }

//        [Display(Name = "Цена")]
//        public Money Price { get; set; }

//        [Display(Name = "Свойства")]
//        public WeaponProperties Properties { get; set; }

//        [Display(Name = "Тип оружия")]
//        public WeaponType Type { get; set; }

//        public Weapon(int id, string name, string damage, string damageType, double weight, Money price, WeaponProperties properties, WeaponType type)
//        {
//            Id = id;
//            Name = name;
//            Damage = damage;
//            DamageType = damageType;
//            Weight = weight;
//            Price = price;
//            Properties = properties;
//            Type = type;
//        }
//    }

//    [Flags]
//    public enum WeaponProperties
//    {
//        None = 0,
//        [Display(Name = "Боеприпас")]
//        Ammunition = 1,
//        [Display(Name = "Двуручное")]
//        TwoHanded = 2,
//        [Display(Name = "Досягаемость")]
//        Reach = 4,
//        [Display(Name = "Легкое")]
//        Light = 8,
//        [Display(Name = "Метательное")]
//        Thrown = 16,
//        [Display(Name = "Специальное")]
//        Special = 32,
//        [Display(Name = "Перезарядка")]
//        Reload = 64,
//        [Display(Name = "Тяжелое")]
//        Heavy = 128,
//        [Display(Name = "Универсальное")]
//        Versatile = 256,
//        [Display(Name = "Фехтовальное")]
//        Finesse = 512
//    }

//    public enum WeaponType
//    {
//        [Display(Name = "Простое рукопашное")]
//        SimpleMelee,

//        [Display(Name = "Простое дальнобойное")]
//        SimpleRanged,

//        [Display(Name = "Воинское рукопашное")]
//        MartialMelee,

//        [Display(Name = "Воинское дальнобойное")]
//        MartialRanged
//    }
//}
