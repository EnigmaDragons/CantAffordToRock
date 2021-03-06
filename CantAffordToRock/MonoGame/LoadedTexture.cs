﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CantAffordToRock.MonoGame
{
    public class LoadedTexture
    {
        private readonly Game _game;
        private readonly string _textureName;

        public LoadedTexture(Game game, string textureName)
        {
            _game = game;
            _textureName = textureName;
        }

        public Texture2D Get()
        {
            return _game.Content.Load<Texture2D>(_textureName);
        }
    }
}
