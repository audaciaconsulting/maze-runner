namespace maze_runner.game
{
    public interface IGameContext
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Draw(GameObject gameObject);
    }
}
