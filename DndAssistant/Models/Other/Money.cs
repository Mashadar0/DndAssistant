namespace DndAssistant.Models.Other
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Money(int copper = 0, int silver = 0, int electrum = 0, int gold = 0, int platinum = 0)
    {
        [Display(Name = "Медь")]
        public int Copper { get; set; } = copper;
        [Display(Name = "Серебро")]
        public int Silver { get; set; } = silver;
        [Display(Name = "Электрум")]
        public int Electrum { get; set; } = electrum;
        [Display(Name = "Золото")]
        public int Gold { get; set; } = gold;
        [Display(Name = "Пдатина")]
        public int Platinum { get; set; } = platinum;

        // Конвертация валюты в общую сумму в медных монетах
        public int ToCopper()
        {
            return Copper +
                   Silver * 10 +
                   Electrum * 50 +
                   Gold * 100 +
                   Platinum * 1000;
        }

        // Конвертация общей суммы в объект Money
        public static Money FromCopper(int copper)
        {
            int platinum = copper / 1000;
            copper %= 1000;

            int gold = copper / 100;
            copper %= 100;

            int electrum = copper / 50;
            copper %= 50;

            int silver = copper / 10;
            copper %= 10;

            return new Money(copper, silver, electrum, gold, platinum);
        }

        public override string ToString()
        {
            return $"{Platinum}pp {Gold}gp {Electrum}ep {Silver}sp {Copper}cp";
        }

        public Money Add(Money other)
        {
            return new Money(
                Copper + other.Copper,
                Silver + other.Silver,
                Electrum + other.Electrum,
                Gold + other.Gold,
                Platinum + other.Platinum
            );
        }

        public Money Subtract(Money other)
        {
            return new Money(
                Copper - other.Copper,
                Silver - other.Silver,
                Electrum - other.Electrum,
                Gold - other.Gold,
                Platinum - other.Platinum
            );
        }
    }

}
