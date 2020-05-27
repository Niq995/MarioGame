using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprite0.Sprite;

namespace Sprite0.Sprite
{
    class StaticSpriteUpdown : ISprite
    {
        public Texture2D Texture { get; set; } //表示该属性可以获取和设置
        public Vector2 location;
        int width;
        int height;



        //Constructor
        public StaticSpriteUpdown(Texture2D texture, Vector2 loc)
        {
            Texture = texture;
            location = loc;
            //w = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            height = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
        }
        public void Update()
        {
            location.Y--;
            if (this.location.Y < 0)
                this.location.Y = 300;

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 loca)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, this.location, Color.White);
            spriteBatch.End();
        }
    }

        
    
}
