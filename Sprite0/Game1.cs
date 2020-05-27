using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprite0.Sprite;
using System;

namespace Sprite0
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        // your link to the graphics device (which lets you set various settings for how things should be drawn, etc
        GraphicsDeviceManager graphics;
        // a tool that we'll use when we want to draw sprites to the screen
        SpriteBatch spriteBatch;

        //4个不同的sprite
        public Texture2D MarioStandRight;
        public Texture2D MarioRunRight;
        public Texture2D MarioStandLeft;
        public Texture2D MarioRunLeft;


        public ISprite sprite; //执行命令的sprite

        public IController GameKeyboard; //遥控器
        


        //public StaticSprite staticSprite;
        //public AnimatedSprite animatedSprite;
       // public StaticSpriteUpdown staticSpriteUpdown;
       // public AnimatedSpriteLeftRight animatedSpriteLeftRight;

        Vector2 leftRightSpriteLocation; 
       


        //Constructor
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            leftRightSpriteLocation = new Vector2(400, 200);
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            //Custom game resolution
            //graphics.PreferredBackBufferWidth = 200;
            //graphics.PreferredBackBufferHeight = 100;
            //graphics.ApplyChanges();
            //this.TargetElapsedTime = TimeSpan.FromSeconds(1.0f / 5.0f);

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //给四个texture2D初始赋值
            MarioStandRight = Content.Load<Texture2D>("Image/MarioStandRight");
            MarioRunRight = Content.Load<Texture2D>("Image/MarioRunRight");
            MarioStandLeft = Content.Load<Texture2D>("Image/MarioStandLeft");
            MarioRunLeft = Content.Load<Texture2D>("Image/MarioRunLeft");
            //sprite赋予初始值
            sprite = new StaticSprite(MarioStandRight);

            //键盘遥控器初始化+link commands into dictionary
            GameKeyboard = new ControllerKeyboard();
            GameKeyboard.SetCommand(this);
            
            
            //动态右跑的mario
            // animatedSprite = new AnimatedSprite(Content.Load<Texture2D>("Image/MarioRunRight"),4,4);
            // staticSpriteUpdown = new StaticSpriteUpdown(Content.Load<Texture2D>("Image/MarioStandLeft"), new Vector2(400,200));
            // animatedSpriteLeftRight = new AnimatedSpriteLeftRight(Content.Load<Texture2D>("Image/MarioRunLeft"),4,4, new Vector2(400, 200));
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);

            KeyboardState keyboardstate = Keyboard.GetState();
            if (keyboardstate.IsKeyDown(Keys.D0))
                Exit();

            GameKeyboard.Update();
           /// gameGamePad.Update();
            sprite.Update();


            // animatedSprite.Update();
            // staticSpriteUpdown.Update();
            //  animatedSpriteLeftRight.Update();


            //if (keyboardstate.IsKeyDown(Keys.D1))
            //     sprite = staticSprite;
            //if (keyboardstate.IsKeyDown(Keys.D2))
            //     sprite = animatedSprite;
            // if (keyboardstate.IsKeyDown(Keys.D3))
            //     sprite = staticSpriteUpdown;
            // if (keyboardstate.IsKeyDown(Keys.D4))
            //     sprite = animatedSpriteLeftRight;


        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            //spriteBatch.Begin();

            //spriteBatch.Draw(background, new Vector2(450, 240), Color.White);
            sprite.Draw(spriteBatch, leftRightSpriteLocation);

            //spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
