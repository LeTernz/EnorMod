using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Enor.Items.armor
{
	[AutoloadEquip(EquipType.Body)]
	public class SoulMeltedChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Soul Melted Chestplate");
			Tooltip.SetDefault("with the power of magic you can melt souls."
				+ "\n or with just a normal anvil..."
				);
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 110000;
			item.rare = ItemRarityID.LightRed;
			item.defense = 12;
		}

		public override void UpdateEquip(Player player)
		{


			player.magicCrit += 4;
			player.statManaMax2 += 50;
			
			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofLight, 3);
			recipe.AddIngredient(ItemID.SoulofNight, 5);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();

			
		}
		

	}
}
