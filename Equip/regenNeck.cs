using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Misc.Equip
{
    public class regenNeck : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Regen Necklace");
            Tooltip.SetDefault("Gives regen if the users helth is below half\n"
            + "adds ten defence");
        }

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.accessory = true;
        }

        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (player.statLife < player.statLifeMax / 2)
            {
                player.AddBuff(BuffID.Regeneration, 1, true);
                player.statDefense += 10;
            }

            if (hideVisual)
            {
                player.AddBuff(BuffID.Invisibility, 1, true);
            }
        }
    }
}