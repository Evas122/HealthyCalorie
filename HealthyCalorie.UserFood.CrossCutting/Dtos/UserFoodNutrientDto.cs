using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.UserFood.CrossCutting.Dtos
{
    public class UserFoodNutrientDto
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public int NutrientId { get; set; }
        public string? NutrientName { get; set; }
        public float Amount { get; set; }
    }
}
