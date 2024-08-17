using System.ComponentModel.DataAnnotations;

namespace DndAssistant.Models
{
    public class Languages
    {
        [Display(Name = "Языки")]
        public List<string>? KnownLanguages { get; set; }

    }
}