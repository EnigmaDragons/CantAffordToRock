using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CantAffordToRock
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        private readonly List<GameObject> gameObjects = new List<GameObject>();
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private bool buttonPressed = false;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
        }

        protected override void Initialize()
        {
            gameObjects.Add(new Button(this, "Images/button", Vector2.One, () =>
            {
                buttonPressed = true;
            }));

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
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
            gameObjects.ForEach(x => x.Draw(spriteBatch));
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
