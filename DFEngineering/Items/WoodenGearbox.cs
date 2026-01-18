namespace DF.Engineering
{
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using System.Collections.Generic;

    /// <summary>
    /// <para>Server side item definition for the "WoodenGearbox" item.</para>
    /// </summary>
    [Serialized]
    [LocDisplayName("Wooden Gearbox")]
    [Weight(10000)]
    [MaxStackSize(10)]
    [RepairRequiresSkill(typeof(BasicEngineeringSkill), 1)]
    [Ecopedia("Items", "Products", createAsSubPage: true)]
    [LocDescription("A more complex mechanical assembly made out of wood.\nUsed in various mechanical constructions.")]
    public partial class WoodenGearboxItem : PartItem
    {
        private static SkillModifiedValue skilledRepairCost = new SkillModifiedValue(2, BasicEngineeringSkill.MultiplicativeStrategy, typeof(BasicEngineeringSkill), typeof(WoodenGearboxItem), Localizer.DoStr("repair cost"), DynamicValueType.Efficiency);
        public override IDynamicValue SkilledRepairCost => skilledRepairCost;
        public override int FullRepairAmount => 2;
        public float ReduceMaxDurabilityByPercent => 0.05f;
        public override IEnumerable<RepairingItem> RepairItems
        {
            get
            {
                yield return new() { Item = Item.Get("WoodenGearItem"), MaterialMult = 2 };
            }
        }

        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Wooden Gearboxes"); } }
        public override float OriginalMaxDurability => 80;
    }

    [RequiresSkill(typeof(BasicEngineeringSkill), 1)]
    public partial class WoodenGearboxRecipe : RecipeFamily
    {
        public WoodenGearboxRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "WoodenGearbox",
                displayName: Localizer.DoStr("Wooden Gearbox"),

                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(WoodenGearItem), 3, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)),
                    new IngredientElement("HewnLog", 2, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)),
                    new IngredientElement(typeof(LubricantItem), 1, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent))
                },

                items: new List<CraftingElement>
                {
                    new CraftingElement<WoodenGearboxItem>(1),
                    new CraftingElement<WoodPulpItem>(2)
                }
            );
            this.Recipes = new List<Recipe> { recipe };

            this.ExperienceOnCraft = 1;
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(BasicEngineeringSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: this.GetType(), start: 1.2f, skillType: typeof(BasicEngineeringSkill), typeof(BasicEngineeringFocusedSpeedTalent), typeof(BasicEngineeringParallelSpeedTalent));

            this.ModsPreInitialize();
            this.Initialize(displayText: recipe.DisplayName, recipeType: this.GetType());
            this.ModsPostInitialize();

            CraftingComponent.AddRecipe(tableType: typeof(CarpentryTableObject), recipeFamily: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
