using System.ComponentModel.DataAnnotations;
using static DndAssistant.Scripts.Dictionary;

namespace DndAssistant.Models.Items
{
    public class Armor : Item
    {
        [Required]
        [Display(Name = "Класс доспехов")]
        public int DefenseValue { get; set; }  // Класс доспехов, определяющий защиту

        [Display(Name = "Тип брони")]
        public ArmorClass ArmorClass { get; set; }  // Тип доспехов (легкие, средние, тяжелые)

        [Display(Name = "Минимальное значение силы")]
        public int? StrengthRequirement { get; set; }  // Минимальное значение силы, необходимое для ношения доспехов

        [Display(Name = "Помеха к скрытности")]
        public bool StealthDisadvantage { get; set; }  // Указывает, накладывается ли помеха к скрытности при ношении доспехов
    }
}
