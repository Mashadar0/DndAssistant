using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DndAssistant.Models.Other
{
    public class Language
    {
        public int Id { get; set; }
        [Display(Name = "Название языка")]
        public string? Name { get; set; }
        [Display(Name = "Экзотический")]
        public bool? IsExotic { get; set; }
        [Display(Name = "Письменность")]
        public string? Writing { get; set; }
        [Display(Name = "Типичный представитель")]
        public string? TypicalRepresentative { get; set; }

    }
}
