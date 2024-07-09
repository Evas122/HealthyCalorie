using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.Food.CrossCutting.Dtos
{
    public class FoodDto
    {
        public int FdcId { get; set; }
        public string? DataType { get; set; }
        public int FoodCategoryId { get; set; }
        public string? FoodCategoryDescription { get; set; }
        public string? Description { get; set; }
        public List<FoodNutrientDto> FoodNutrients { get; set;}
    }
}
