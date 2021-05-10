using System;
using System.Globalization;

namespace Domain
{
    public class Product : Entity<int>
    {
        public int Amount { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public string Title { get; set; }
        public string Description
        {
            get
            {
                string description = "Awesome product with the name {0}, that has a price of {1}. Hurry! As of today, {2}, there are only {3} left in stock!";
                string description2 = string.Format(description, Title, Price, CreatedAtFormatted, Amount);

                return description2;
            }
        }
        public DateTime CreatedAt { get; set; }
        public string CreatedAtFormatted
        {
            get
            {
                return CreatedAt.ToString("U", CultureInfo.CreateSpecificCulture("en-US"));
            }
        }
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
        public virtual Promotion Promotion { get; set; }
        public int PromotionId { get; set; }
    }
}
