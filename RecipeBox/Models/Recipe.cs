using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public Recipe()
    {
      this.JoinEntities = new HashSet<RecipeTag>();
    }
    public int RecipeId { get; set; }
    public string Name { get; set; }

    [StringLength(10000)]
    public string Instructions { get; set; }

    [StringLength(1000)]
    public string Ingredients { get; set; }

    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<RecipeTag> JoinEntities { get; set; }
  }
}