using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_2___Assignment
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D whitewoodTexture, blackwoodTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 640;
            _graphics.PreferredBackBufferHeight = 640;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            blackwoodTexture = Content.Load<Texture2D>("blackwood");
            whitewoodTexture = Content.Load<Texture2D>("whitewood");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    _spriteBatch.Draw(whitewoodTexture, new Rectangle(0 + i * 160, 0 + j * 160, 80, 80), Color.White);
                    _spriteBatch.Draw(blackwoodTexture, new Rectangle(80 + i * 160, 0 + j * 160, 80, 80), Color.White);
                    _spriteBatch.Draw(whitewoodTexture, new Rectangle(80 + i * 160, 80 + j * 160, 80, 80), Color.White);
                    _spriteBatch.Draw(blackwoodTexture, new Rectangle(0 + i * 160, 80 + j * 160, 80, 80), Color.White);

                }
            }




                _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
