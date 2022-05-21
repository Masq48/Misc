using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Misc.Items
{
    public class InfConf : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Infinite Confetti Gun");
            Tooltip.SetDefault("Infinite use Confetti Gun");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ConfettiGun);
            item.consumable = false;
            item.stack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ConfettiGun, 3001);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}