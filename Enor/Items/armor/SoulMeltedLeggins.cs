using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Enor.Items.armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class SoulMeltedLeggins : ModItem
	{
		
		
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("SwordSand"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("grants swiftness to user.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 11000;
			item.rare = ItemRarityID.LightRed;
			item.defense = 9;
		}

		public override void AddRecipes()
		{
			/*ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofLight, 20);
			recipe.AddIngredient(ItemID.SoulofNight, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
			*/
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofLight, 3);
			recipe.AddIngredient(ItemID.SoulofNight, 5);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
		public override void UpdateEquip(Player player)
		{
			
			player.AddBuff(BuffID.Swiftness, 100);
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			player.AddBuff(BuffID.Regeneration,200);
		}
	}
}