using HealthyCalorie.Common.Storage.Entities;
using HealthyCalorie.User.Storage.Entities;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.Recipe.Storage.Entities
{
    [Table("Recipes", Schema = "Recipe")]
    public class Recipe : BaseEntity
    {
        public int UserId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Url { get; set; }

        public virtual HealthyCalorie.User.Storage.Entities.User User { get; set; }
        public virtual List<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
