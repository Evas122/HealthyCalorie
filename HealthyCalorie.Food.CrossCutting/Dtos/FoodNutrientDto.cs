using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.Food.CrossCutting.Dtos
{
    public class FoodNutrientDto
    {
        public int Id { get; set; }
        public int FdcId { get; set; }
        public int NutrientId { get; set; }
        public string? NutrientName { get; set; }
        public float Amount { get; set; }
    }
}
