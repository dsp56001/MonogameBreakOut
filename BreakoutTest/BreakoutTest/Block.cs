﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoGameLibrary.Sprite;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BreakoutTest
{
    enum BlockState { Normal, Broken };

    class Block : DrawableSprite
    {
        protected BlockState _state;            //Private instance datamenber for block
        public BlockState State
        {
            get { return _state; }
            protected set
            {
                if (this._state != value)       //Change state if it is different than previous state                
                {
                    this._state = value;
                }
            }
        }

        public Block(Game game)
            : base(game)
        {
        }
        protected override void LoadContent()
        {
            this.spriteTexture = this.Game.Content.Load<Texture2D> ("block_blue");
            base.LoadContent();
        }

        /// <summary>
        /// Checks if ball is hit by block
        /// </summary>
        /// <param name="ball"></param>
        internal void HitByBall(Ball ball)
        {
            this.Enabled = false;
            this.Visible = false;
            this.State = BlockState.Broken;
        }
    }
}
