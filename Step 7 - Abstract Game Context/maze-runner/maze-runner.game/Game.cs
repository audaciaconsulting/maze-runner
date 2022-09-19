using System.Numerics;

namespace maze_runner.game
{
    public class Game
    {
        public List<Sprite> Sprites = new List<Sprite>();

        private List<GameObject> _gameObjects = new List<GameObject>();
        private Sprite _block { get; set; }
        private IGameContext _context;

        public Game(IGameContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            _block = new Sprite
            {
                Source = "assets/whiteblock.png"
            };

            Sprites.Add(_block);

            _gameObjects.Add(new GameObject { Sprite = _block, Colour = "red" });
            _gameObjects.Add(new GameObject { Sprite = _block, Position = new Vector2(200, 0), Colour = "blue" });
        }

        public void Update()
        {

        }

        public void Draw()
        {
            foreach (var gameObject in _gameObjects)
            {
                _context.Draw(gameObject);
            }
        }
    }
}
