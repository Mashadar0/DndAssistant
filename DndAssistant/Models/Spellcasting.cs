using System.ComponentModel.DataAnnotations;

namespace DndAssistant.Models
{
    public class Spellcasting
    {
        [Display(Name = "Заклинания известные")]
        public List<string>? KnownSpells { get; set; }

        [Display(Name = "Ячейки заклинаний")]
        public Dictionary<int, int>? SpellSlots { get; set; } // Ключ: уровень заклинания, значение: количество ячеек

        
    }
}