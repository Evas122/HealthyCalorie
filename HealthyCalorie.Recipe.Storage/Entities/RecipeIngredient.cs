using HealthyCalorie.Common.Storage.Entities;
using HealthyCalorie.Food.Storage.Entities;
using HealthyCalorie.UserFood.Storage.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.Recipe.Storage.Entities
{
    [Table("RecipeIngredients", Schema = "Recipe")]
    public class RecipeIngredient : BaseEntity
    {
        public int RecipeId { get; set; }
        public int? FdcId { get; set; }
        public int? FoodId { get; set; }
        public float Quantity { get; set; }
        public string? Unit { get; set; } 

        public virtual Recipe Recipe { get; set; }
        public virtual HealthyCalorie.Food.Storage.Entities.Food FdcFood { get; set; }
        public virtual HealthyCalorie.UserFood.Storage.Entities.UserFood UserFood { get; set; }
    }
}
