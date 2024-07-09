using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.Recipe.CrossCutting.Dtos
{
    public class RecipeIngredientDto
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public int? FdcId { get; set; }
        public int? FoodId { get; set; }
        public float Quantity { get; set; }
        public string? Unit { get; set; }
    }
}
