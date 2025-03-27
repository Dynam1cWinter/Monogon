using Microsoft.Xna.Framework.Input;

namespace Monogon.Engine.Struct;

public struct Keybind
{
    public Keys keyOne;
    public Keys keyTwo;

    public Keybind(Keys keyOne, Keys keyTwo = Keys.None)
    {
        this.keyOne = keyOne;
        this.keyTwo = keyTwo;
    }
}