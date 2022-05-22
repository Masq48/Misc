using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Misc.Items.Weapons
{
    public class BHSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Catsmen's Blade");
            Tooltip.SetDefault("Also known as The HorseMere\n"
            + "Spawns Flying Meowmere heads");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.TheHorsemansBlade);
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            pumpkinSword(player, target.whoAmI, damage, knockBack);
        }

        private void pumpkinSword(Player player, int i, int dmg, float kb)
        {
            int num = Main.rand.Next(100, 300);
            int num2 = Main.rand.Next(100, 300);
            if (Main.rand.Next(2) == 0)
            {
                num -= Main.maxScreenW / 2 + num;
            }
            else
            {
                num += Main.maxScreenW / 2 - num;
            }
            if (Main.rand.Next(2) == 0)
            {
                num2 -= Main.maxScreenH / 2 + num2;
            }
            else
            {
                num2 += Main.maxScreenH / 2 - num2;
            }
            num += (int)player.position.X;
            num2 += (int)player.position.Y;
            float num3 = 8f;
            Vector2 vector = new Vector2((float)num, (float)num2);
            float num4 = Main.npc[i].position.X - vector.X * 20;
            float num5 = Main.npc[i].position.Y - vector.Y * 20;
            float num6 = (float)System.Math.Sqrt((double)(num4 * num4 + num5 * num5));
            num6 = num3 / num6;
            num4 *= num6;
            num5 *= num6;
            Projectile.NewProjectile((float)num / 2, (float)num2 / 2, num4, num5, ModContent.ProjectileType<Projectiles.BHSwordProj>(), dmg, kb, player.whoAmI, (float)i, 0f);
        }
    }
}