using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.ConsumptionTracking.CrossCutting.Dtos
{
    public class ConsumptionDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? FdcId { get; set; }
        public int? UserFoodId { get; set; }
        public float Quantity { get; set; }
        public string? Unit { get; set; }
        public DateTime Date { get; set; }
    }
}
