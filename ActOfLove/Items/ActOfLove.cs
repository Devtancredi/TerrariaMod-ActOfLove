using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ActOfLove.Items
{
	public class ActOfLove : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("ActOfLove"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Lay down your life for a friend");
		}

		public override void SetDefaults() 
		{
			item.damage = 1;
			item.magic = true;
			item.noMelee = true;
			item.width = 10;
			item.height = 10;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 0;
			item.shootSpeed = 10f;
			item.mana = 200;
			item.value = 10000;
			item.rare = 4;
			item.shoot = mod.ProjectileType("HeartProjectile");
			item.UseSound = SoundID.Item9;
			item.autoReuse = false;
		}

		public override void OnConsumeMana(Player player, int manaConsumed)
		{
			player.statLife = 0; //The player is killed on use
			player.KillMe(PlayerDeathReason.
			player.KillMe(PlayerDeathReason.ByCustomReason(player.name + " sacrificed themself to save a friend"), 5000, 1);
			
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LifeCrystal, 10);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddIngredient(ItemID.RichGravestone3, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}