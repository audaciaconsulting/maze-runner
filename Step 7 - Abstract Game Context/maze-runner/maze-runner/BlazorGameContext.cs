using Blazor.Extensions.Canvas.Canvas2D;
using maze_runner.game;

namespace maze_runner
{
    public class BlazorGameContext : IGameContext
    {
        private readonly Canvas2DContext _context;

        public BlazorGameContext(Canvas2DContext context)
        {
            _context = context;
        }

        public async void Draw(GameObject gameObject)
        {
            await _context.SaveAsync();

            await _context.DrawImageAsync(
               gameObject.Sprite.Ref,
               gameObject.Position.X, gameObject.Position.Y);

            await _context.RestoreAsync();

            await _context.SetFillStyleAsync(gameObject.Colour);
            await _context.FillRectAsync(gameObject.Position.X, gameObject.Position.Y, 100, 100);
        }
    }
}
