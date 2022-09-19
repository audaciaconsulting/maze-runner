using System.Numerics;

namespace maze_runner.game
{
    public class GameObject
    {
        public Sprite Sprite { get; set; }
        public Vector2 Position { get; set; } = Vector2.Zero;
        public string Colour { get; set; }
    }
}
