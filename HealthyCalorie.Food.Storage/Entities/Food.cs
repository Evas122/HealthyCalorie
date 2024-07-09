using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.Food.Storage.Entities
{
    [Table("Foods")]
    public class Food
    {
        [Key]
        public int FdcId { get; set; }
        public string DataType { get; set; }
        public int FoodCategoryId { get; set; }
        public string Description { get; set; }

        public virtual FoodCategory FoodCategory { get; set; }
        public virtual List<FoodNutrient> FoodNutrients { get; set; }

    }
}
