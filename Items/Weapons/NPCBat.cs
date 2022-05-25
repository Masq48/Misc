using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Misc.Items.Weapons
{

    public class NPCBat : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The B.A.T");
            Tooltip.SetDefault("Bother All Townsfolk");
        }

        public override void SetDefaults()
        {
            item.value = Item.sellPrice(silver: 50);
            item.useStyle = 1;
            item.useTurn = true;
            item.autoReuse = true;
            item.rare = ItemRarityID.Green;
            item.damage = 5;
            item.melee = true;
            item.crit = 10;
            item.questItem = true;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (!target.friendly)
            {
                crit = true;
            }
        }

    }
}