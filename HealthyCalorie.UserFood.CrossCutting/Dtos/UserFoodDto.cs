using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.UserFood.CrossCutting.Dtos
{
    public class UserFoodDto
    {
        public int Id { get; set; }
        public string? DataType { get; set; }
        public int FoodCategoryId { get; set; }
        public string? Description { get; set; }
    }
}
