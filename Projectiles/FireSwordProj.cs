using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Misc.Projectiles
{
    public class FireSwordProj : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Arkhalis);
            projectile.height = 45;
            projectile.width = 45;
            projectile.penetrate = -1;
        }
        //FIXME: FireKahlis


        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 2 * 60, false);
        }

    }
}