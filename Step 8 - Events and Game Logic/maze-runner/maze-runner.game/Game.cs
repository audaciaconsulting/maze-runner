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
                Source = "assets/block.png"
            };

            Sprites.Add(_block);

            _gameObjects.Add(new GameObject
            {
                Sprite = _block,
                Position = new Vector2(50, 50)
            });
            _gameObjects.Add(new GameObject
            {
                Sprite = _block,
                Position = new Vector2(250, 50)
            });
        }

        public void Update()
        {

        }

        public void OnKeyUp(int keyCode)
        {
            // Up - 38
            // Down - 40
            // Right - 39
            // Left - 37
            _gameObjects[1].Rotation += 0.3f;
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
