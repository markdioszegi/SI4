using System;

namespace SI4.API
{
    public class FoodProduct : Product
    {
        public int Calories { get; set; }
        public DateTime BestBefore { get; set; }
        public FoodProduct(long barcode, string name, string manufacturer, int calories, DateTime bestBefore) : base(barcode, name, manufacturer)
        {
            Calories = calories;
            BestBefore = bestBefore;
        }

        public bool IsStillConsumable()
        {
            if (DateTime.Today > BestBefore)
                return false;
            return true;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nCalories: {Calories}\nBest before: {BestBefore.ToShortDateString()}";
        }
    }
}