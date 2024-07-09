using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.Food.Storage.Entities
{
    [Table("FoodNutrients")]
    public class FoodNutrient
    {
        [Key]
        public int Id { get; set; }
        public int FdcId { get; set; }
        public int NutrientId { get; set; }
        public float Amount { get; set; }

        public virtual Food Food { get; set; }
        public virtual Nutrient Nutrient { get; set;}
    }
}
