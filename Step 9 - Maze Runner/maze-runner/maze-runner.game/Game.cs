using System.Numerics;

namespace maze_runner.game
{
    public class Game
    {
        public List<Sprite> Sprites = new List<Sprite>();

        private List<GameObject> _gameObjects = new List<GameObject>();
        private Sprite _blockSprite { get; set; }
        private Sprite _playerSprite { get; set; }
        private Sprite _erlichSprite { get; set; }
        private GameObject _player { get; set; }
        private float widthStep { get; set; }
        private float heightStep { get; set; }
        private IGameContext _context;

        private Vector2[] _maze;

        public Game(IGameContext context)
        {
            _context = context;
        }

        public void LoadContent()
        {
            _blockSprite = new Sprite
            {
                Source = "assets/block.png"
            };

            _playerSprite = new Sprite
            {
                Source = "assets/player.png"
            };

            _erlichSprite = new Sprite
            {
                Source = "assets/erlich.png"
            };

            Sprites.Add(_blockSprite);
            Sprites.Add(_playerSprite);
            Sprites.Add(_erlichSprite);
        }

        public void Initialize()
        {
            var widthRatio = (float)_context.Width / (float)(13 * 100);
            widthStep = 100 * widthRatio;
            var firstBlockWidth = widthStep / 2;

            var heightRatio = (float)_context.Height / (float)(8 * 100);
            heightStep = 100 * heightRatio;
            var firstBlockHeight = heightStep / 2;

            _maze = new Vector2[]
            {
                new Vector2(firstBlockWidth, firstBlockHeight),
                new Vector2(widthStep * 1 + firstBlockWidth, firstBlockHeight),
                new Vector2(widthStep * 2 + firstBlockWidth, firstBlockHeight),
                new Vector2(widthStep * 3 + firstBlockWidth, firstBlockHeight),
                new Vector2(widthStep * 4 + firstBlockWidth, firstBlockHeight),
                new Vector2(widthStep * 5 + firstBlockWidth, firstBlockHeight),
                new Vector2(widthStep * 6 + firstBlockWidth, firstBlockHeight),
                new Vector2(widthStep * 7 + firstBlockWidth, firstBlockHeight),
                new Vector2(widthStep * 8 + firstBlockWidth, firstBlockHeight),
                new Vector2(widthStep * 9 + firstBlockWidth, firstBlockHeight),
                new Vector2(widthStep * 10 + firstBlockWidth, firstBlockHeight),
                new Vector2(widthStep * 11 + firstBlockWidth, firstBlockHeight),
                new Vector2(widthStep * 12 + firstBlockWidth, firstBlockHeight),
                new Vector2(widthStep * 12 + firstBlockWidth, heightStep * 1 + firstBlockHeight),
                new Vector2(widthStep * 12 + firstBlockWidth, heightStep * 2 + firstBlockHeight),
                new Vector2(widthStep * 12 + firstBlockWidth, heightStep * 3 + firstBlockHeight),
                new Vector2(widthStep * 12 + firstBlockWidth, heightStep * 5 + firstBlockHeight),
                new Vector2(widthStep * 12 + firstBlockWidth, heightStep * 6 + firstBlockHeight),
                new Vector2(widthStep * 12 + firstBlockWidth, heightStep * 7 + firstBlockHeight),
                new Vector2(widthStep * 11 + firstBlockWidth, heightStep * 7 + firstBlockHeight),
                new Vector2(widthStep * 10 + firstBlockWidth, heightStep * 7 + firstBlockHeight),
                new Vector2(widthStep * 9 + firstBlockWidth, heightStep * 7 + firstBlockHeight),
                new Vector2(widthStep * 8 + firstBlockWidth, heightStep * 7 + firstBlockHeight),
                new Vector2(widthStep * 7 + firstBlockWidth, heightStep * 7 + firstBlockHeight),
                new Vector2(widthStep * 6 + firstBlockWidth, heightStep * 7 + firstBlockHeight),
                new Vector2(widthStep * 5 + firstBlockWidth, heightStep * 7 + firstBlockHeight),
                new Vector2(widthStep * 4 + firstBlockWidth, heightStep * 7 + firstBlockHeight),
                new Vector2(widthStep * 3 + firstBlockWidth, heightStep * 7 + firstBlockHeight),
                new Vector2(widthStep * 2 + firstBlockWidth, heightStep * 7 + firstBlockHeight),
                new Vector2(widthStep * 1 + firstBlockWidth, heightStep * 7 + firstBlockHeight),
                new Vector2(firstBlockWidth, heightStep * 7 + firstBlockHeight),
                new Vector2(firstBlockWidth, heightStep * 6 + firstBlockHeight),
                new Vector2(firstBlockWidth, heightStep * 5 + firstBlockHeight),
                new Vector2(firstBlockWidth, heightStep * 3 + firstBlockHeight),
                new Vector2(firstBlockWidth, heightStep * 2 + firstBlockHeight),
                new Vector2(firstBlockWidth, heightStep * 1 + firstBlockHeight),
                new Vector2(widthStep * 1 + firstBlockWidth, heightStep * 5 + firstBlockHeight),
                new Vector2(widthStep * 2 + firstBlockWidth, heightStep * 5 + firstBlockHeight),
                new Vector2(widthStep * 1 + firstBlockWidth, heightStep * 6 + firstBlockHeight),
                new Vector2(widthStep * 2 + firstBlockWidth, heightStep * 6 + firstBlockHeight),
                new Vector2(widthStep * 4 + firstBlockWidth, heightStep * 5 + firstBlockHeight),
                new Vector2(widthStep * 4 + firstBlockWidth, heightStep * 4 + firstBlockHeight),
                new Vector2(widthStep * 4 + firstBlockWidth, heightStep * 3 + firstBlockHeight),
                new Vector2(widthStep * 3 + firstBlockWidth, heightStep * 3 + firstBlockHeight),
                new Vector2(widthStep * 2 + firstBlockWidth, heightStep * 3 + firstBlockHeight),
                new Vector2(widthStep * 1 + firstBlockWidth, heightStep * 3 + firstBlockHeight),
                new Vector2(widthStep * 6 + firstBlockWidth, heightStep * 5 + firstBlockHeight),
                new Vector2(widthStep * 7 + firstBlockWidth, heightStep * 5 + firstBlockHeight),
                new Vector2(widthStep * 7 + firstBlockWidth, heightStep * 4 + firstBlockHeight),
                new Vector2(widthStep * 7 + firstBlockWidth, heightStep * 3 + firstBlockHeight),
                new Vector2(widthStep * 7 + firstBlockWidth, heightStep * 2 + firstBlockHeight),
                new Vector2(widthStep * 7 + firstBlockWidth, heightStep * 1 + firstBlockHeight),
                new Vector2(widthStep * 9 + firstBlockWidth, heightStep * 5 + firstBlockHeight),
                new Vector2(widthStep * 9 + firstBlockWidth, heightStep * 4 + firstBlockHeight),
                new Vector2(widthStep * 9 + firstBlockWidth, heightStep * 3 + firstBlockHeight),
                new Vector2(widthStep * 9 + firstBlockWidth, heightStep * 2 + firstBlockHeight),
                new Vector2(widthStep * 10 + firstBlockWidth, heightStep * 2 + firstBlockHeight),
                new Vector2(widthStep * 10 + firstBlockWidth, heightStep * 3 + firstBlockHeight),
                new Vector2(widthStep * 10 + firstBlockWidth, heightStep * 4 + firstBlockHeight),
                new Vector2(widthStep * 10 + firstBlockWidth, heightStep * 5 + firstBlockHeight),
                new Vector2(widthStep * 11 + firstBlockWidth, heightStep * 5 + firstBlockHeight),
                new Vector2(widthStep * 1 + firstBlockWidth, heightStep * 1 + firstBlockHeight),
                new Vector2(widthStep * 1 + firstBlockWidth, heightStep * 2 + firstBlockHeight),
                new Vector2(widthStep * 2 + firstBlockWidth, heightStep * 1 + firstBlockHeight),
                new Vector2(widthStep * 3 + firstBlockWidth, heightStep * 1 + firstBlockHeight),
                new Vector2(widthStep * 4 + firstBlockWidth, heightStep * 1 + firstBlockHeight),
                new Vector2(widthStep * 5 + firstBlockWidth, heightStep * 1 + firstBlockHeight),
                new Vector2(widthStep * 6 + firstBlockWidth, heightStep * 1 + firstBlockHeight),
                new Vector2(widthStep * 6 + firstBlockWidth, heightStep * 2 + firstBlockHeight),
                new Vector2(widthStep * 6 + firstBlockWidth, heightStep * 3 + firstBlockHeight),
                new Vector2(widthStep * 6 + firstBlockWidth, heightStep * 4 + firstBlockHeight),
            };

            _gameObjects = new List<GameObject>();

            foreach (var block in _maze)
            {
                _gameObjects.Add(new GameObject
                {
                    Sprite = _blockSprite,
                    Position = block,
                    Scale = new Vector2(widthRatio, heightRatio)
                });
            }

            _player = new GameObject
            {
                Sprite = _playerSprite,
                Position = new Vector2(firstBlockWidth, heightStep * 4 + firstBlockHeight),
                Scale = new Vector2(widthRatio, heightRatio)
            };

            _gameObjects.Add(new GameObject
            {
                Sprite = _erlichSprite,
                Position = new Vector2(widthStep * 12 + firstBlockWidth, heightStep * 4 + firstBlockHeight),
                Scale = new Vector2(widthRatio, heightRatio)
            });

            _gameObjects.Add(_player);
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
            if(keyCode == 39)
            {
                _player.Position = new Vector2(_player.Position.X + widthStep, _player.Position.Y);
                _player.Rotation = 0.0f;
            }
            else if(keyCode == 37)
            {
                _player.Position = new Vector2(_player.Position.X - widthStep, _player.Position.Y);
                _player.Rotation = 3.14f;
            }
            else if (keyCode == 40)
            {
                _player.Position = new Vector2(_player.Position.X, _player.Position.Y + heightStep);
                _player.Rotation = 1.57f;
            }
            else if (keyCode == 38)
            {
                _player.Position = new Vector2(_player.Position.X, _player.Position.Y - heightStep);
                _player.Rotation = -1.57f;
            }
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
