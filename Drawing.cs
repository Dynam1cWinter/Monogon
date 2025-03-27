using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Monogon.Engine;

public static class Drawing
{
    private static Texture2D rect;

    public static void FillRect(Rectangle bounds, Color color, float depth, MonogonEngine monogon)
    {
        if (rect == null)
            rect = new Texture2D(monogon.GraphicsDevice, 1, 1);
        rect.SetData(new[] { Color.White });
        MonogonEngine.spriteBatch.Draw(rect, bounds, null, color, 0, new Vector2(0, 0), SpriteEffects.None, depth);
    }
}