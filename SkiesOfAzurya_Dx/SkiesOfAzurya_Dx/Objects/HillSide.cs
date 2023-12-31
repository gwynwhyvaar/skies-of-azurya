﻿using System;
//using System.Linq;
using Microsoft.Xna.Framework;

namespace Gwynwhyvaar.SkiesOfAzurya.WinDx.Objects
{
    [Serializable]
    public struct HillSide
    {
        public Boolean IsActive;

        public Vector3 Position;
        public Vector3 Direction;

        public float Speed;

        public void Update(float delta)
        {
            GameConstants gameConstant = new GameConstants();

            Position += Direction * Speed * gameConstant.SpeedAdjustment * delta;

            if (Position.X > gameConstant.PlayFieldSizeX)
            {
                Position.X -= 2 * gameConstant.PlayFieldSizeX;
            }
            if (Position.X < -gameConstant.PlayFieldSizeX)
            {
                Position.X += 2 * gameConstant.PlayFieldSizeX;
            }
            if (Position.Y > gameConstant.PlayFieldSizeY)
            {
                Position.Y -= 2 * gameConstant.PlayFieldSizeY;
            }
            if (Position.Y < -gameConstant.PlayFieldSizeY)
            {
                Position.Y += 2 * gameConstant.PlayFieldSizeY;
            }
        }
    }
}
