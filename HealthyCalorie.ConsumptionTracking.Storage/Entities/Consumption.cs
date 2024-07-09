using HealthyCalorie.Common.Storage.Entities;
using HealthyCalorie.Food.Storage.Entities;
using HealthyCalorie.User.Storage.Entities;
using HealthyCalorie.UserFood.Storage.Entities;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.ConsumptionTracking.Storage.Entities
{
    [Table("Consumptions", Schema = "Consumption")]
    public class Consumption : BaseEntity
    {
        public int UserId { get; set; }
        public int? FdcId { get; set; }
        public int? UserFoodId { get; set; }
        public float Quantity { get; set; }
        public string? Unit { get; set; }
        public DateTime Date { get; set; }

        public virtual HealthyCalorie.User.Storage.Entities.User User { get; set; }
        public virtual HealthyCalorie.Food.Storage.Entities.Food Food { get; set; }
        public virtual HealthyCalorie.UserFood.Storage.Entities.UserFood UserFood { get; set; }
    }
}
