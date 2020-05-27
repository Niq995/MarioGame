using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprite0.Sprite
{
    class SpriteAnimatedLeftRight : ISprite
    {
        public Texture2D Texture { get; set; }
        //the number of rows and columns in the texture atlas
        public int Rows { get; set; }
        public int Columns { get; set; }
        private int currentFrame;
        private int totalFrames;

        Vector2 location;
       // int width;

        //Constructor
        public SpriteAnimatedLeftRight(Texture2D texture, int rows, int columns, Vector2 loc)
        {
            Texture = texture;
            Rows = rows;
            Columns = columns;
            currentFrame = 0;
            totalFrames = Rows * Columns;
            location = loc;
        }

        public void Update()
        {
            location.X=location.X -2;
            if (location.X < 0)
                location.X = 500;

            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            int width = Texture.Width / Columns;
            int height = Texture.Height / Rows;
            int row = (int)((float)currentFrame / (float)Columns);
            int column = currentFrame % Columns;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, this.location, sourceRectangle, Color.White);
            spriteBatch.End();

        }
    }
}
