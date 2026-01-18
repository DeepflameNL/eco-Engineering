namespace DF.Engineering
{
    using Eco.Core.Plugins.Interfaces;

    public class DeepflameModInitializer : IModInit
    {
        public static ModRegistration Register()
        {
            return new ModRegistration()
            {
                ModName = "DF_Engineering",
                ModDescription =
                    "A mod that extends the Basic Engineering specialization.",
                ModDisplayName = "[DF] Engineering",
            };
        }
    }
}
