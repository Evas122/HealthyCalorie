using HealthyCalorie.Common.Storage.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.UserFood.Storage.Entities
{
    [Table("UserFoodCategories", Schema = "UserFood")]
    public class UserFoodCategory : BaseEntity
    {
        public string? Description { get; set; }

        public virtual ICollection<UserFood> UserFoods { get; set; }
    }
}
