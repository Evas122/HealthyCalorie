using HealthyCalorie.Common.Storage.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.Food.Storage.Entities
{
    [Table("Nutrients")]
    public class Nutrient : BaseEntity
    {
        public string? Name { get; set; }
        public string? UnitName { get; set; }

        public virtual ICollection<FoodNutrient> FoodNutrients { get; set; }

    }
}
