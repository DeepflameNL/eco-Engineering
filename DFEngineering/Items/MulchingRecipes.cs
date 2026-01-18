namespace DF.Engineering
{
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using System.Collections.Generic;

    [RequiresSkill(typeof(BasicEngineeringSkill), 0)]
    public partial class MulchWoodenGearRecipe : RecipeFamily
    {
        public MulchWoodenGearRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "MulchWoodenGearRecipe",
                displayName: Localizer.DoStr("Mulch Wooden Gear Recipe"),

                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(WoodenGearItem), 1, typeof(BasicEngineeringSkill))
                },

                items: new List<CraftingElement>
                {
                    new CraftingElement<WoodPulpItem>(5)
                }
            );
            this.Recipes = new List<Recipe> { recipe };

            this.ExperienceOnCraft = 0.1f;
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(BasicEngineeringSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: this.GetType(), start: 0.2f, skillType: typeof(BasicEngineeringSkill), typeof(BasicEngineeringFocusedSpeedTalent), typeof(BasicEngineeringParallelSpeedTalent));

            this.ModsPreInitialize();
            this.Initialize(displayText: recipe.DisplayName, recipeType: this.GetType());
            this.ModsPostInitialize();

            CraftingComponent.AddRecipe(tableType: typeof(StampMillObject), recipeFamily: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(BasicEngineeringSkill), 0)]
    public partial class MulchWoodenGearboxRecipe : RecipeFamily
    {
        public MulchWoodenGearboxRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "MulchWoodenGearboxRecipe",
                displayName: Localizer.DoStr("Mulch Wooden Gearbox Recipe"),

                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(WoodenGearboxItem), 1, typeof(BasicEngineeringSkill))
                },

                items: new List<CraftingElement>
                {
                    new CraftingElement<WoodPulpItem>(20)
                }
            );
            this.Recipes = new List<Recipe> { recipe };

            this.ExperienceOnCraft = 0.1f;
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(BasicEngineeringSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: this.GetType(), start: 0.2f, skillType: typeof(BasicEngineeringSkill), typeof(BasicEngineeringFocusedSpeedTalent), typeof(BasicEngineeringParallelSpeedTalent));

            this.ModsPreInitialize();
            this.Initialize(displayText: recipe.DisplayName, recipeType: this.GetType());
            this.ModsPostInitialize();

            CraftingComponent.AddRecipe(tableType: typeof(StampMillObject), recipeFamily: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(BasicEngineeringSkill), 0)]
    public partial class MulchWoodenHullPlanksRecipe : RecipeFamily
    {
        public MulchWoodenHullPlanksRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "MulchWoodenHullPlanksRecipe",
                displayName: Localizer.DoStr("Mulch Wooden Hull Planks Recipe"),

                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(WoodenHullPlanksItem), 1, typeof(BasicEngineeringSkill))
                },

                items: new List<CraftingElement>
                {
                    new CraftingElement<WoodPulpItem>(10)
                }
            );
            this.Recipes = new List<Recipe> { recipe };

            this.ExperienceOnCraft = 0.1f;
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(BasicEngineeringSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: this.GetType(), start: 0.2f, skillType: typeof(BasicEngineeringSkill), typeof(BasicEngineeringFocusedSpeedTalent), typeof(BasicEngineeringParallelSpeedTalent));

            this.ModsPreInitialize();
            this.Initialize(displayText: recipe.DisplayName, recipeType: this.GetType());
            this.ModsPostInitialize();

            CraftingComponent.AddRecipe(tableType: typeof(StampMillObject), recipeFamily: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(BasicEngineeringSkill), 0)]
    public partial class MulchHewnLogsRecipe : RecipeFamily
    {
        public MulchHewnLogsRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "MulchHewnLogsRecipe",
                displayName: Localizer.DoStr("Mulch Hewn Logs Recipe"),

                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("HewnLog", 1, typeof(BasicEngineeringSkill))
                },

                items: new List<CraftingElement>
                {
                    new CraftingElement<WoodPulpItem>(7)
                }
            );
            this.Recipes = new List<Recipe> { recipe };

            this.ExperienceOnCraft = 0.1f;
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(BasicEngineeringSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: this.GetType(), start: 0.2f, skillType: typeof(BasicEngineeringSkill), typeof(BasicEngineeringFocusedSpeedTalent), typeof(BasicEngineeringParallelSpeedTalent));

            this.ModsPreInitialize();
            this.Initialize(displayText: recipe.DisplayName, recipeType: this.GetType());
            this.ModsPostInitialize();

            CraftingComponent.AddRecipe(tableType: typeof(StampMillObject), recipeFamily: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(BasicEngineeringSkill), 0)]
    public partial class MulchLumberRecipe : RecipeFamily
    {
        public MulchLumberRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "MulchLumberRecipe",
                displayName: Localizer.DoStr("Mulch Lumber Recipe"),

                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Lumber", 1, typeof(BasicEngineeringSkill))
                },

                items: new List<CraftingElement>
                {
                    new CraftingElement<WoodPulpItem>(5)
                }
            );
            this.Recipes = new List<Recipe> { recipe };

            this.ExperienceOnCraft = 0.1f;
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(BasicEngineeringSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: this.GetType(), start: 0.2f, skillType: typeof(BasicEngineeringSkill), typeof(BasicEngineeringFocusedSpeedTalent), typeof(BasicEngineeringParallelSpeedTalent));

            this.ModsPreInitialize();
            this.Initialize(displayText: recipe.DisplayName, recipeType: this.GetType());
            this.ModsPostInitialize();

            CraftingComponent.AddRecipe(tableType: typeof(StampMillObject), recipeFamily: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(BasicEngineeringSkill), 0)]
    public partial class MulchCompositeLumberRecipe : RecipeFamily
    {
        public MulchCompositeLumberRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "MulchCompositeLumberRecipe",
                displayName: Localizer.DoStr("Mulch Composite Lumber Recipe"),

                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("CompositeLumber", 1, typeof(BasicEngineeringSkill))
                },

                items: new List<CraftingElement>
                {
                    new CraftingElement<WoodPulpItem>(5)
                }
            );
            this.Recipes = new List<Recipe> { recipe };

            this.ExperienceOnCraft = 0.1f;
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(BasicEngineeringSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: this.GetType(), start: 0.2f, skillType: typeof(BasicEngineeringSkill), typeof(BasicEngineeringFocusedSpeedTalent), typeof(BasicEngineeringParallelSpeedTalent));

            this.ModsPreInitialize();
            this.Initialize(displayText: recipe.DisplayName, recipeType: this.GetType());
            this.ModsPostInitialize();

            CraftingComponent.AddRecipe(tableType: typeof(StampMillObject), recipeFamily: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
