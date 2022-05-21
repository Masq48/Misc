using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Misc.Items
{

    public class HardPot : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hardmode potion");
            Tooltip.SetDefault("Releases or contains the spirts of light and dark");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 99;
            item.rare = 2;
            item.useTime = 30;
            item.useStyle = 4;
            item.useAnimation = 30;
            item.consumable = true;
        }

        public override bool UseItem(Player player)
        {
            Main.hardMode = !Main.hardMode;
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 30);
            recipe.AddIngredient(ItemID.NightsEdge, 1);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}