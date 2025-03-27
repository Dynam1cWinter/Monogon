using Microsoft.Xna.Framework.Input;
using Monogon.Engine.Struct;

namespace Monogon.Engine;

public static class Extension
{
    public static bool KeybindActive(this Keybind kb)
    {
        if (kb.keyTwo != null || kb.keyTwo != Keys.None)
            return (Keyboard.GetState().IsKeyDown(kb.keyOne) && Keyboard.GetState().IsKeyDown(kb.keyTwo));
        return Keyboard.GetState().IsKeyDown(kb.keyOne);
    }
}