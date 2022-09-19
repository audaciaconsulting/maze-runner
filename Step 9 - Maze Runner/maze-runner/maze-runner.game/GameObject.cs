using System.Numerics;

namespace maze_runner.game
{
    public class GameObject
    {
        public Sprite Sprite { get; set; }
        public Vector2 Position { get; set; } = Vector2.Zero;
        public Vector2 Scale { get; set; } = Vector2.One;
        public float Rotation { get; set; } = 0;
        public bool Enabled { get; set; } = true;
    }
}
