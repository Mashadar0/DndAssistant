using DndAssistant.Models.Other;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static DndAssistant.Scripts.Dictionary;

namespace DndAssistant.Models.Items
{
    public class Item
    {
        public int Id { get; set; }  // ID предмета

        [Required]
        [Display(Name = "Название")]
        public string? Name { get; set; }  // Название предмета

        [Display(Name = "Описание")]
        public string? Description { get; set; }  // Дополнительное описание предмета

        [Display(Name = "Вес")]
        public double Weight { get; set; }  // Вес предмета в фунтах


        [Display(Name = "Цена")]
        public Money Cost { get; set; } = new();  // Стоимость предмета
    }
}
