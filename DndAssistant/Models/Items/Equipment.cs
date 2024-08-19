using System.ComponentModel.DataAnnotations;

namespace DndAssistant.Models.Items
{
    public class Equipment
    {
        [Display(Name = "Оружие")]
        public List<string>? Weapons { get; set; }

        [Display(Name = "Доспехи")]
        public List<string>? Armor { get; set; }

        [Display(Name = "Другие предметы")]
        public List<string>? OtherItems { get; set; }
    }
}