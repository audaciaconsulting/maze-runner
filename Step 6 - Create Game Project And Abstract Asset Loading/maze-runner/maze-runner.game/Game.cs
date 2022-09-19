using System.Numerics;

namespace maze_runner.game
{
    public class Game
    {
        public List<Sprite> Sprites = new List<Sprite>();
        public List<GameObject> GameObjects = new List<GameObject>();
        private Sprite _block { get; set; }

        public void Initialize()
        {
            _block = new Sprite
            {
                Source = "assets/whiteblock.png"
            };

            Sprites.Add(_block);

            GameObjects.Add(new GameObject { Sprite = _block, Colour = "red" });
            GameObjects.Add(new GameObject { Sprite = _block, Position = new Vector2(200, 0), Colour = "blue" });
        }
    }
}
