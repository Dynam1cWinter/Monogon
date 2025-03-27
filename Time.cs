using Microsoft.Xna.Framework;

namespace Monogon.Engine;

public class Time
{
    public static float deltaTime;

    public static void Update(GameTime gameTime)
    {
        deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
    }
}