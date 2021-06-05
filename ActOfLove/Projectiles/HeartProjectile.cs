using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ActOfLove.Projectiles
{
	public class HeartProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("English Display Name Here");
		}

		public override void SetDefaults()
		{
			projectile.maxPenetrate = 1;
			projectile.magic = true;
			projectile.light = 0.8F;
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = false;
			projectile.hostile = true;
			aiType = ProjectileID.MagicMissile;
		}

		public override void Kill(int timeLeft)
		{
			Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
			Main.PlaySound(SoundID.Item10, projectile.position);
		}

		public override void OnHitPlayer(Player target, int damage, bool crit) {
			//Main.myPlayer.statLife = 0;
			target.statLife = target.statLifeMax; //Sets target's life to max
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.life = target.lifeMax;
		}

			/*player.immuneTime      //would love to add immunity frames to the affected player in future)*/

			// Additional hooks/methods here.
	}
}