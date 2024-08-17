using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using static DndAssistant.Scripts.Dictionary;

namespace DndAssistant.Models
{
    // Класс для черт расы
    public class Race
    {
        [Display(Name = "Название")]
        public string? Name { get; set; }

        [Display(Name = "Модификаторы характеристик")]
        public AbilityScoreModifiers? AbilityModifiers { get; set; }

        [Display(Name = "Черты")]
        public List<Trait>? Traits { get; set; }

        [Display(Name = "Особенности")]
        public List<Feature>? Features { get; set; }

        [Display(Name = "Темное зрение")]
        public Darkvision? Darkvision { get; set; }

        [Display(Name = "Владение оружием")]
        public List<string>? WeaponProficiencies { get; set; }

        [Display(Name = "Владение инструментами")]
        public List<string>? ToolProficiencies { get; set; }

        //[JsonIgnore]
        //public int Id { get; set; }
        //[JsonPropertyName("Название расы")]
        //public string Name { get; set; }
        //[JsonPropertyName("Описание")]
        //public string Description { get; set; }
        ////[JsonIgnore]
        ////static int Count = 0;
        //[JsonPropertyName("Расовая прибавка к Силе")]
        //public int RaceStrength { get; set; }
        //[JsonPropertyName("Расовая прибавка к Ловкости")]
        //public int RaceDexterity { get; set; }
        //[JsonPropertyName("Расовая прибавка к Телосложению")]
        //public int RaceConstitution { get; set; }
        //[JsonPropertyName("Расовая прибавка к Интеллекту")]
        //public int RaceIntelligence { get; set; }
        //[JsonPropertyName("Расовая прибавка к Мудрости")]
        //public int RaceWisdom { get; set; }
        //[JsonPropertyName("Расовая прибавка к Харизме")]
        //public int RaceCharisma { get; set; }
        //[JsonPropertyName("Скорость")]
        //public int Speed { get; set; }
        //[JsonPropertyName("Расовые умения")]
        //public int[] AbilitiesId { get; set; }
        //[JsonPropertyName("Расовое владение оружием")]
        //public int[] WeaponsId { get; set; }
        //public int[] ToolChooseId { get; set; }
        //public int[] LanguagesId { get; set; }
        //public ArmorClass[] ArmorClasses { get; set; }





        ////public Race(int id, string name, string description, int raceStrength, int raceDexterity, int raceConstitution,
        ////            int raceIntelligence, int raceWisdom, int raceCharisma, int speed, int[] abilitiesId)
        ////{
        ////    Id = id;
        ////    Name = name;
        ////    Description = description;
        ////    RaceStrength = raceStrength;
        ////    RaceDexterity = raceDexterity;
        ////    RaceConstitution = raceConstitution;
        ////    RaceIntelligence = raceIntelligence;
        ////    RaceWisdom = raceWisdom;
        ////    RaceCharisma = raceCharisma;
        ////    Speed = speed;
        ////    AbilitiesId = abilitiesId;
        ////}



        ////public Race(int id, string name, string description)
        ////{
        ////    //Id = Count;
        ////    //Count++;\
        ////    Id = id;
        ////    Name = name;
        ////    Description = description;
        ////}

        ////public static void ResetCountOfRaces()
        ////{
        ////    Count = 0;
        ////}

    }
}
