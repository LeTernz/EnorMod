using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Enor.Items.accessory
{
    public class ManaRose : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mana Rose");
            Tooltip.SetDefault(
                "8% reduced mana usage\n" +
                "You automatically use mana potions when needed\n" +
                "+ 20 max mana\n" +
                "+ 15% magic damage"
                );
            
        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(25);
            item.accessory = true;
            item.value = 1000;
            item.rare = ItemRarityID.Pink;
            
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.magicDamageMult += 0.15f;
            player.statManaMax2 += 20;
            player.manaFlower = true;
            player.manaCost -= 0.08f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ManaFlower, 1);
            recipe.AddIngredient(ItemID.JungleRose, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}