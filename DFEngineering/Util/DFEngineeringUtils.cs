using Eco.Gameplay.Items;
using Eco.Gameplay.Items.Recipes;
using Eco.Shared.Utils;

namespace DF.Engineering
{
    public static class DFEngineeringUtils
    {
        public static bool TryReplaceIngredient(RecipeFamily recipe, Item item, IngredientElement newIngredient)
        {
            int index = recipe.Ingredients.IndexOf(ingredientElement => ingredientElement.Item == item);
            if (index != -1)
            {
                recipe.Ingredients[index] = newIngredient;
                return true;
            }
            return false;
        }

        public static bool TryReplaceIngredient(RecipeFamily recipe, string tag, IngredientElement newIngredient)
        {
            int index = recipe.Ingredients.IndexOf(ingredientElement => ingredientElement.Tag.Name == tag);
            if (index != -1)
            {
                recipe.Ingredients[index] = newIngredient;
                return true;
            }
            return false;
        }
    }
}
