using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapScrollingTest.GameScreens
{
    using SFML.Graphics;
    using SFML.System;

    public class MapScreen
    {
        private const int TileSize = 32;
        private List<RectangleShape> tiles = new List<RectangleShape>();

        public MapScreen()
        {
            for(int i = 0; i < 10; i++)
            {
                var rekt = new RectangleShape();
                rekt.Position = GetRandomTilePosition();
                rekt.Size = new Vector2f(TileSize, TileSize);
                rekt.FillColor = Color.Green;
                this.tiles.Add(rekt);
            }
        }

        public void Draw(RenderTarget target)
        {
            foreach(var tile in this.tiles)
                target.Draw(tile);
        }

        private Vector2f GetRandomTilePosition()
        {
            Random rand = new Random();
            int x = rand.Next(640 / TileSize) * TileSize;
            int y = rand.Next(480 / TileSize) * TileSize;
            return new Vector2f(x, y);
        }
    }
}
