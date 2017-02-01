using CantAffordToRock.Engine;
using CantAffordToRock.MonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CantAffordToRock.Views
{
    public class MainMenu : IGameView
    {
        private readonly Game _game;
        private readonly INavigator _navigator;

        private Texture2D _logo;

        public MainMenu(Game game, INavigator navigator)
        {
            _game = game;
            _navigator = navigator;
        }

        public void LoadContent()
        {
            _logo = new LoadedTexture(_game, "rockband-logo.png").Get();
        }

        public void UnloadContent()
        {
            _logo?.Dispose();
        }

        public void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Start != ButtonState.Pressed && !Keyboard.GetState().IsKeyDown(Keys.Enter))
                return;

            _navigator.NavigateTo("Auction");
            UnloadContent();
        }

        public void Draw(SpriteBatch sprites)
        {
            sprites.GraphicsDevice.Clear(Color.FromNonPremultiplied(37, 37, 37, 255));
            new Centered(_game, _logo).Draw(sprites);
            sprites.DrawString(RockFont.Font, "Press ENTER to start", new Vector2(235, 420),
                Color.FromNonPremultiplied(237, 52, 52, 255));
        }
    }
}
