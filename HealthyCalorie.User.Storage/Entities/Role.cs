using HealthyCalorie.Common.Storage.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.User.Storage.Entities
{
    [Table("Roles", Schema = "User")]
    public class Role : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
