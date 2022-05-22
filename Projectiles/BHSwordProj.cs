using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Misc.Projectiles
{
    public class BHSwordProj : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.FlamingJack);
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            Player p = Main.player[projectile.owner];
            int healAmount = damage / 5;
            p.statLife += healAmount;
            p.HealEffect(healAmount);
            if (Main.rand.Next(5) == 0)
            {
                target.AddBuff(BuffID.Frostburn, 60 * 10);
            }
        }

        public override string Texture => "Terraria/Projectile_" + ProjectileID.Meowmere;
    }
}