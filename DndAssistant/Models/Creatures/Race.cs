using DndAssistant.Models.Powers;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using static DndAssistant.Scripts.Dictionary;

namespace DndAssistant.Models.Creatures
{
    // Класс для черт расы
    public class Race
    {
        public int Id { get; set; }  // Уникальный идентификатор расы

        [Required]
        [Display(Name = "Название")]
        public string? Name { get; set; }  // Название расы

        [Display(Name = "Описание")]
        public string? Description { get; set; }  // Описание расы

        [Display(Name = "Размер")]
        public CreatureSize Size { get; set; }  // Размер расы (малый, средний и т.д.)

        [Display(Name = "Языки")]
        public List<string> Languages { get; set; } = new();  // Языки, на которых говорит раса

        [Display(Name = "Бонусы к характеристикам")]
        public AbilityScore AbilityScoreBonuses { get; set; } = new();  // Бонусы к характеристикам

        [Display(Name = "Способности")]
        public List<Trait> Traits { get; set; } = new();  // Особые способности расы

        [Display(Name = "Особые черты")]
        public List<string> SpecialFeatures { get; set; } = new();  // Особые черты расы


        //[Display(Name = "Возраст")]
        //public AgeRange AgeRange { get; set; }  // Диапазон возраста расы

        //[Display(Name = "Рост")]
        //public HeightRange HeightRange { get; set; }  // Диапазон роста расы

        //[Display(Name = "Вес")]
        //public WeightRange WeightRange { get; set; }  // Диапазон веса расы
    }

    //public class AgeRange
    //{
    //    [Display(Name = "Минимальный возраст")]
    //    public int Min { get; set; }

    //    [Display(Name = "Максимальный возраст")]
    //    public int Max { get; set; }
    //}

    //public class HeightRange
    //{
    //    [Display(Name = "Минимальный рост (см)")]
    //    public int Min { get; set; }

    //    [Display(Name = "Максимальный рост (см)")]
    //    public int Max { get; set; }
    //}

    //public class WeightRange
    //{
    //    [Display(Name = "Минимальный вес (кг)")]
    //    public int Min { get; set; }

    //    [Display(Name = "Максимальный вес (кг)")]
    //    public int Max { get; set; }
    //}

    
}
