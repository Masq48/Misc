using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Misc.Items.Weapons
{
    public class FireSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Firekalis"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Set enemys on fire");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Arkhalis);
            item.damage = 50;
            item.value = Item.sellPrice(gold: 7);
            item.shoot = mod.ProjectileType("FireSwordProj");
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 5 * 60, true);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Arkhalis, 1);
            recipe.AddIngredient(ItemID.HellstoneBar, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}