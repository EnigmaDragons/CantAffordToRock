using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace CantAffordToRock
{
    public class Button : GameObject
    {
        private Action onClick;

        private bool pressed = false;

        public Button(Microsoft.Xna.Framework.Game game, string name, Vector2 position, float scale, Action onClick) : base(game)
        {
            Name = name;
            Position = position;
            Scale = scale;
            this.onClick = onClick;
        }

        public override void Update(GameTime gameTime)
        {
            if (Mouse.GetState().LeftButton == ButtonState.Pressed && Texture.Bounds.Contains(Mouse.GetState().Position))
                pressed = true;
            else if (pressed && Mouse.GetState().LeftButton == ButtonState.Released && Texture.Bounds.Contains(Mouse.GetState().Position))
                onClick();
            else
                pressed = false;
        }
    }
}
