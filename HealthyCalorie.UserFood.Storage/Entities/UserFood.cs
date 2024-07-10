using HealthyCalorie.Common.Storage.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.UserFood.Storage.Entities
{
    [Table("UserFoods", Schema = "UserFood")]
    public class UserFood : BaseEntity
    {
        public string? DataType { get; set; }
        public int FoodCategoryId { get; set; }
        public string? Description { get; set; }

        public virtual UserFoodCategory UserFoodCategory { get; set; }
        public virtual List<UserFoodNutrient> UserFoodsNutrients { get; set; }

    }
}
