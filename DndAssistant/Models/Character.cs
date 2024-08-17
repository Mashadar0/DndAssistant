using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Text.Json.Serialization;
using static DndAssistant.Scripts.Dictionary;

namespace DndAssistant.Models
{
    public class Character
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Имя")]
        public string? Name { get; set; }

        [Display(Name = "Раса")]
        public Race? Race { get; set; }

        [Display(Name = "Класс")]
        public Class? Class { get; set; }

        [Display(Name = "Характеристики")]
        public AbilityScores? AbilityScores { get; set; }

        [Display(Name = "Предыстория")]
        public Background? Background { get; set; }

        [Display(Name = "Снаряжение")]
        public Equipment? Equipment { get; set; }

        [Display(Name = "Навыки")]
        public Skills? Skills { get; set; }

        [Display(Name = "Особенности")]
        public List<Feature>? Features { get; set; }

        [Display(Name = "Заклинания")]
        public Spellcasting? Spellcasting { get; set; }

        [Display(Name = "Очки здоровья")]
        public HitPoints? HitPoints { get; set; }

        [Display(Name = "Мировоззрение")]
        public Alignment? Alignment { get; set; }

        [Display(Name = "Владение")]
        public Proficiencies? Proficiencies { get; set; }

        [Display(Name = "Языки")]
        public Languages? Languages { get; set; }

        //[JsonPropertyName("Порядковый номер")]
        //public int Id { get; set; }
        //[JsonPropertyName("Имя персонажа")]
        //public string Name { get; set; }
        ////[JsonPropertyName("Характеристики персонажа")]
        ////List<Ability> Abilities { get; set; }
        //[JsonPropertyName("Сила")]
        //public int Strength { get; set; }
        //[JsonPropertyName("Ловкость")]
        //public int Dexterity { get; set; }
        //[JsonPropertyName("Телосложение")]
        //public int Constitution { get; set; }
        //[JsonPropertyName("Интеллект")]
        //public int Intelligence { get; set; }
        //[JsonPropertyName("Мудрость")]
        //public int Wisdom { get; set; }
        //[JsonPropertyName("Харизма")]
        //public int Charisma { get; set; }
        //public List<Language> ProficiencyLanguages { get; set; }

    }
}
