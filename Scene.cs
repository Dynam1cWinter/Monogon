using Microsoft.Xna.Framework;

namespace Monogon.Engine;

public abstract class Scene
{
    public int ID;

    public Scene(int id)
    {
        this.ID = id;
    }

    public abstract void Awake(MonogonEngine monogon);
    public abstract void Update(float deltaTime, MonogonEngine monogon);
    public abstract void Draw(MonogonEngine monogon);
}