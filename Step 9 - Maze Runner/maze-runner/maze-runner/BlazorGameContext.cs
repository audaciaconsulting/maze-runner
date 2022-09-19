using Blazor.Extensions.Canvas.Canvas2D;
using maze_runner.game;
using Microsoft.AspNetCore.Components;
using System.ComponentModel;

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
            if (!gameObject.Enabled) return;

            await _context.SaveAsync();

            await _context.TranslateAsync(gameObject.Position.X, gameObject.Position.Y);
            await _context.RotateAsync(gameObject.Rotation);

            await _context.DrawImageAsync(
               gameObject.Sprite.Ref,
               0, 0,
               100,
               100,
               -50, -50,
               100,
               100);

            await _context.RestoreAsync();
        }
    }
}
