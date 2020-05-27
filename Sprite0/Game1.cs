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

        //执行命令的sprite
        public ISprite sprite; 
        //遥控器
        public IController GameKeyboard; 
        
        Vector2 Location; 
       


        //Constructor
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            Location = new Vector2(400, 200);
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
            // 初始化画笔
            spriteBatch = new SpriteBatch(GraphicsDevice);

            

            // Create four different texture2D for sprite / 四钟不同的sprite
            MarioStandRight = Content.Load<Texture2D>("Image/MarioStandRight");
            MarioRunRight = Content.Load<Texture2D>("Image/MarioRunRight");
            MarioStandLeft = Content.Load<Texture2D>("Image/MarioStandLeft");
            MarioRunLeft = Content.Load<Texture2D>("Image/MarioRunLeft");
            // Initialize sprite / sprite赋予初始值
            sprite = new SpriteStatic(MarioStandRight);

            // Initialize keyboardController and link <ControllerKeyboard, CommandObject>
            // 初始化键盘控制器 + 将键盘按键和命令对象联系起来
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

            GameKeyboard.Update();
            /// gameGamePad.Update();
            sprite.Update();

            base.Update(gameTime);

            //KeyboardState keyboardstate = Keyboard.GetState();
            //if (keyboardstate.IsKeyDown(Keys.D0))
               // Exit();

            // animatedSprite.Update();
            // staticSpriteUpdown.Update();
            // animatedSpriteLeftRight.Update();


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
            sprite.Draw(spriteBatch, Location);

            

            //spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
