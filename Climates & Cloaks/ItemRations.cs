// Project:         Filling Food mod for Daggerfall Unity (http://www.dfworkshop.net)
// Copyright:       Copyright (C) 2020 Ralzar
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Author:          Ralzar

using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;

namespace FillingFood
{
    public class ItemRations : AbstractItemFood
    {
        public const int templateIndex = 531;

        public ItemRations() : base(ItemGroups.UselessItems2, templateIndex)
        {
        }

        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(ItemRations).ToString();
            return data;
        }
    }
}
