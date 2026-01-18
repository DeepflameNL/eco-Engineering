using DF.Engineering;
using Eco.Gameplay.Items.Recipes;

namespace Eco.Mods.TechTree
{
    public partial class WoodenGearRecipe
    {
        partial void ModsPreInitialize()
        {
            DFEngineeringUtils.TryReplaceIngredient(this, "HewnLog", new IngredientElement(
                "HewnLog", 3, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)
            ));

            this.Recipes[0].Products.Add(
                new CraftingElement<WoodPulpItem>(3)
            );
        }
    }
}
