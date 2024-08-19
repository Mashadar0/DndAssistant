using DndAssistant.Models.Powers;
using System.ComponentModel.DataAnnotations;

namespace DndAssistant.Models
{
    public class Class
    {
        [Display(Name = "Название")]
        public string? Name { get; set; }

        [Display(Name = "Бросок хитов")]
        public int? HitDie { get; set; }

        [Display(Name = "Особенности")]
        public List<Trait>? Traits { get; set; }

        [Display(Name = "Владение оружием")]
        public List<string>? WeaponProficiencies { get; set; }

        [Display(Name = "Владение доспехами")]
        public List<string>? ArmorProficiencies { get; set; }


    }
}
