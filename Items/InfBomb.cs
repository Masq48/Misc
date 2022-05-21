using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Misc.Items
{
    public class InfBomb : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Infinite Bomb");
            Tooltip.SetDefault("Infinite use bomb");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Bomb);
            item.consumable = false;
            item.stack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Bomb, 301);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}