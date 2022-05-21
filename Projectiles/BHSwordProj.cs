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

        public override string Texture => "Terraria/Projectile_" + ProjectileID.Meowmere;
    }
}