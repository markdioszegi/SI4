using System;

namespace SI4
{
    public class FoodProduct : Product
    {
        int Calories { get; set; }
        DateTime BestBefore { get; set; }
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
            return $"Calories: {Calories}\nBest before: {BestBefore.ToShortDateString()}";
        }
    }
}