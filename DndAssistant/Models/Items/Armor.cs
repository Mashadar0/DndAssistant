using static DndAssistant.Scripts.Dictionary;

namespace DndAssistant.Models.Items
{
    public class Armor : Item
    {
        public int Defence { get; set; }
        public int NeedStrength { get; set; }
        public bool StealthHindrance { get; set; }
        public ArmorClass armorClass { get; set; }
    }
}
