using System.ComponentModel.DataAnnotations;

namespace DndAssistant.Models
{
    public class Proficiencies
    {
        [Display(Name = "Владение оружием")]
        public List<string>? WeaponProficiencies { get; set; }

        [Display(Name = "Владение доспехами")]
        public List<string>? ArmorProficiencies { get; set; }

        [Display(Name = "Владение инструментами")]
        public List<string>? ToolProficiencies { get; set; }

    }
}