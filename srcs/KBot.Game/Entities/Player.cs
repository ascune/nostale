﻿using KBot.Game.Enum;
using PropertyChanged;

namespace KBot.Game.Entities
{
    [AddINotifyPropertyChangedInterface]
    public class Player : LivingEntity
    {
        public Gender Gender { get; set; }
        public Job Job { get; set; }

        public Player()
        {
            EntityType = EntityType.Player;
        }
    }
}