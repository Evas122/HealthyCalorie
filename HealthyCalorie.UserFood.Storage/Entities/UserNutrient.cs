using HealthyCalorie.Common.Storage.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.UserFood.Storage.Entities
{
    [Table("Nutrients", Schema = "UserFood")]
    public class UserNutrient : BaseEntity
    {
        public string? Name { get; set; }
        public string? UnitName { get; set; }

        public virtual UserFoodNutrient UserFoodNutrient { get; set; }
    }
}
