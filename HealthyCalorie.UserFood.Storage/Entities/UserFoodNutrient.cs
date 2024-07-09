using HealthyCalorie.Common.Storage.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.UserFood.Storage.Entities
{
    [Table("UserFoodNutrients", Schema = "UserFood")]
    public class UserFoodNutrient : BaseEntity
    {
        public int FoodId { get; set; }
        public int NutrientId { get; set; }
        public float Amount { get; set; }

        public virtual UserFood UserFood { get; set; }
        public virtual UserNutrient Nutrient { get; set; }
    }
}
