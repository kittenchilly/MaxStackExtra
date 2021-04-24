using Terraria;
using Terraria.ModLoader;

namespace MaxStackExtra
{
    public class MaxStackExtraItem : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (!item.IsACoin)
            {
                if (item.maxStack > 1)
                {
                    if (item.createTile > -1)
                        item.maxStack = ModContent.GetInstance<MaxStackExtraConfig>().TileStackValue;
                    else
                        item.maxStack = ModContent.GetInstance<MaxStackExtraConfig>().ItemStackValue;
                }
                else if (item.accessory || item.defense > 0)
                    item.maxStack = ModContent.GetInstance<MaxStackExtraConfig>().EquipStackValue;
                else if (item.damage > 0)
                    item.maxStack = ModContent.GetInstance<MaxStackExtraConfig>().WeaponStackValue;
                else
                    item.maxStack = ModContent.GetInstance<MaxStackExtraConfig>().SpecialStackValue;
            }
            else
                base.SetDefaults(item);
        }
    }
}
