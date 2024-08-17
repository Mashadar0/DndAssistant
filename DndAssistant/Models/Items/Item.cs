using DndAssistant.Scripts;
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
        public Money? Cost { get; set; } = new();  // Стоимость предмета

        //public Item(int id, string name, string description, int weight, Money cost)
        //{
        //    Id = id;
        //    Name = name;
        //    Description = description;
        //    Weight = weight;
        //    Cost = cost;
        //}

        //public override string ToString()
        //{
        //    return $"{Name}: {Description}, Вес: {Weight} фунтов, Цена: {Cost}";
        //}



        //public int Id { get; set; }
        //[Display(Name = "Название")]
        //public string? Name { get; set; }
        //[Display(Name = "Описание")]
        //public string? Description { get; set; }
        //[Display(Name = "Вес")]
        //public int Weight { get; set; }
        //[Display(Name = "Стоимость")]
        //public int Cost { get; set; }
        //public MoneyType MoneyType { get; set; }

        ////public Item(int id, string name, string description, string weight, int cost)
        ////{
        ////    Id = id;
        ////    Name = name;
        ////    Description = description;
        ////    Weight = weight;
        ////    Cost = cost;
        ////}
    }
}
