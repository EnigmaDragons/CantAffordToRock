using System.Collections.Generic;
using CantAffordToRock.CoreGame;
using CantAffordToRock.Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CantAffordToRock.Views
{
    public class AuctionView : IGameView
    {
        private readonly Game _game;
        private readonly AuctionBoard _board;
        private readonly List<RockerCard> _availableCards = new List<RockerCard>();

        public AuctionView(Game game, AuctionBoard board)
        {
            _game = game;
            _board = board;
        }

        public void LoadContent()
        {
            _board.DrawRockers();
            _board.AvailableRockers.ForEach(x => _availableCards.Add(new RockerCard(_game, x)));
        }

        public void UnloadContent()
        {
        }

        public void Update(GameTime deltaTime)
        {
        }

        public void Draw(SpriteBatch sprites)
        {
            sprites.GraphicsDevice.Clear(Color.FromNonPremultiplied(37, 37, 37, 255));
            _availableCards[0].Draw(sprites, new Vector2(0, 0));
        }
    }
}
