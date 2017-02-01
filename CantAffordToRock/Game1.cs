using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CantAffordToRock
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private readonly List<GameObject> gameObjects = new List<GameObject>();
        private SpriteFont appFont;

        private bool buttonPressed = false;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
        }

        protected override void Initialize()
        {
            gameObjects.Add(new Button(this, "Images/button", new Vector2(100, 100), 0.2f, () =>
            {
                buttonPressed = true;
            }));

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            appFont = Content.Load<SpriteFont>("Content/Arial");
            gameObjects.ForEach(x => x.LoadContent());
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            gameObjects.ForEach(x => x.Update(gameTime));

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch.DrawString(appFont, "Hello World", Vector2.One, Color.Red);
            gameObjects.ForEach(x => x.Draw(spriteBatch));
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
