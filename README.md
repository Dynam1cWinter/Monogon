```cs

using Microsoft.Xna.Framework.Input;
using Monogon.Engine.Struct;

namespace Monogon.Engine;

public static class Input
{
    public static class Bindings
    {
        public enum BindableActions
        {
            MoveUp,
            MoveDown,
            MoveLeft,
            MoveRight,
            
            FaceUp,
            FaceDown,
            FaceLeft,
            FaceRight,
            
            Confirm,
            OpenInventory,
            OpenMenu,
            Interact,
            EquipLantern,
            QuickShutdown,
            DeveloperToggle,
            
            // Internal feature to address EVERY keybind rather than just one.
            All
        }

        // Movement keys, these are responsible for moving the players transform.
        public static Keybind moveUp = new Keybind(Keys.W);
        public static Keybind moveDown = new Keybind(Keys.S);
        public static Keybind moveLeft = new Keybind(Keys.A);
        public static Keybind moveRight = new Keybind(Keys.D);
        
        // Direction keys, these aren't required to move the player, rather a QoL mechanic to change the players
        // -sprite direction without actually changing the players position.
        public static Keybind faceUp = new Keybind(Keys.Up);
        public static Keybind faceDown = new Keybind(Keys.Down);
        public static Keybind faceLeft = new Keybind(Keys.Left);
        public static Keybind faceRight = new Keybind(Keys.Right);
        
        // Actions bindings, these are things such as opening the pause menu and whatnot.
        public static Keybind confirm = new Keybind(Keys.Enter);
        public static Keybind openInventory = new Keybind(Keys.Tab);
        public static Keybind openMenu = new Keybind(Keys.Escape);
        public static Keybind interact = new Keybind(Keys.E);
        public static Keybind equipLantern = new Keybind(Keys.LeftShift);
        public static Keybind quickShutdown = new Keybind(Keys.OemTilde, Keys.Escape);
        public static Keybind developerToggle = new Keybind(Keys.OemTilde, Keys.F1);
        
        // If the screws up their keybinds pressing this key will forcefully reset them all.
        public static Keybind resetKeybinds = new Keybind(Keys.F2);

        // TODO: Make sure F2 can NOT be rebound.
        public static void SetBinding(BindableActions target, Keys value)
        {
            switch (target)
            {
                case BindableActions.MoveUp:
                    moveUp = new Keybind(value);
                    break;
                case BindableActions.MoveDown:
                    moveDown = new Keybind(value);
                    break;
                case BindableActions.MoveLeft:
                    moveLeft = new Keybind(value);
                    break;
                case BindableActions.MoveRight:
                    moveRight = new Keybind(value);
                    break;
                
                case BindableActions.FaceUp:
                    faceUp = new Keybind(value);
                    break;
                case BindableActions.FaceDown:
                    faceDown = new Keybind(value);
                    break;
                case BindableActions.FaceLeft:
                    faceLeft = new Keybind(value);
                    break;
                case BindableActions.FaceRight:
                    faceRight = new Keybind(value);
                    break;
                
                case BindableActions.Confirm:
                    confirm = new Keybind(value);
                    break;
                case BindableActions.OpenInventory:
                    openInventory = new Keybind(value);
                    break;
                case BindableActions.OpenMenu:
                    openMenu = new Keybind(value);
                    break;
                case BindableActions.Interact:
                    interact = new Keybind(value);
                    break;
                case BindableActions.EquipLantern:
                    equipLantern = new Keybind(value);
                    break;
                
            }
        }

        // Resets all keybinds to their default values.
        public static void ResetBinding(BindableActions target)
        {
            
        }
    }

    public static class GamepadBindings
    {
        // I don't even know where to start here...
    }
}

```
