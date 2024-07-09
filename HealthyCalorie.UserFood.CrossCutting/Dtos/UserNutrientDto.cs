using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.UserFood.CrossCutting.Dtos
{
    public class UserNutrientDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? UnitName { get; set; }
    }
}
