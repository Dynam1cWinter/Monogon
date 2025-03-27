using Microsoft.Xna.Framework;

namespace Monogon.Engine;

public interface IUpdatable
{
    public void Update(float deltaTime, MonogonEngine monogon);
}