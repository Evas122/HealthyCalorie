using HealthyCalorie.Common.Storage.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.Food.Storage.Entities
{
    [Table("FoodCategories")]
    public class FoodCategory : BaseEntity
    { 
        public string? Description { get; set; }

        public virtual ICollection<Food> Foods { get; set; }
    }
}
