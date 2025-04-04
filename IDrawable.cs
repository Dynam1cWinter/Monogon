namespace Monogon.Engine;

// Will likely be removed entirly as game logic and engine logic are similar enough to where this isn´t justified.
public interface IDrawable
{
    public void Draw(float deltaTime, MonogonEngine monogon);
}
