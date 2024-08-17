using System.ComponentModel.DataAnnotations;

namespace DndAssistant.Models
{
    public class Skills
    {
        [Display(Name = "Акробатика")]
        public int Acrobatics { get; set; }

        [Display(Name = "Обращение с животными")]
        public int AnimalHandling { get; set; }

        [Display(Name = "Магия")]
        public int Arcana { get; set; }

        [Display(Name = "Атлетика")]
        public int Athletics { get; set; }

        [Display(Name = "Обман")]
        public int Deception { get; set; }

        [Display(Name = "История")]
        public int History { get; set; }

        [Display(Name = "Проницательность")]
        public int Insight { get; set; }

        [Display(Name = "Запугивание")]
        public int Intimidation { get; set; }

        [Display(Name = "Расследование")]
        public int Investigation { get; set; }

        [Display(Name = "Медицина")]
        public int Medicine { get; set; }

        [Display(Name = "Природа")]
        public int Nature { get; set; }

        [Display(Name = "Внимание")]
        public int Perception { get; set; }

        [Display(Name = "Выступление")]
        public int Performance { get; set; }

        [Display(Name = "Убеждение")]
        public int Persuasion { get; set; }

        [Display(Name = "Религия")]
        public int Religion { get; set; }

        [Display(Name = "Ловкость рук")]
        public int SleightOfHand { get; set; }

        [Display(Name = "Скрытность")]
        public int Stealth { get; set; }

        [Display(Name = "Выживание")]
        public int Survival { get; set; }
    }
}