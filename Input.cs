using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;
using Monogon.Engine.Struct;

namespace Monogon.Engine;

public static class Input
{
// Outdated, being reworked from the ground-up for 3D rather then 2D.
    
    public static class Bindings
    {
        public enum BindableActions
        {
            // Top-down only
            MoveForward,
            MoveBackward,
            
            MoveLeft,
            MoveRight,

            FaceForward,
            FaceBackward,
            FaceLeft,
            FaceRight,

            Jump,
            
            OpenMenu,
            Interact,
            Confirm,
        }
        
        // W, A, S, D movement.
        public static Keybind moveForwardKey = new Keybind(Keys.W);
        public static Keybind moveBackwardKey = new Keybind(Keys.S);
        public static Keybind moveLeftKey = new Keybind(Keys.A);
        public static Keybind moveRightKey = new Keybind(Keys.D);
        
        // QoL feature to elt the user orient the player without actually changing its position.
        public static Keybind faceForwardKey = new Keybind(Keys.Up);
        public static Keybind faceBackwardKey = new Keybind(Keys.Down);
        public static Keybind faceLeftKey = new Keybind(Keys.Left);
        public static Keybind faceRightKey = new Keybind(Keys.Right);
        
        // Open Esc manu, Interaction, Menu Confirmation.
        // For QoL reasons interaction and confirmation will always activate each other uness specified by code, this can be disabled.
        public static Keybind openMenuKey = new Keybind(Keys.Escape);
        public static Keybind interactKey = new Keybind(Keys.E);
        public static Keybind confirmKey = new Keybind(Keys.Enter);

        // List of all bindable actions and if they're active or not.
        // May move this logic into the actual Keybind struct later.
        public static Dictionary<BindableActions, bool> activeBindings = new Dictionary<BindableActions, bool>()
        {
            { BindableActions.MoveForward, false},
            { BindableActions.MoveBackward, false},
            { BindableActions.MoveLeft, false},
            { BindableActions.MoveRight, false},
            
            { BindableActions.FaceForward, false},
            { BindableActions.FaceBackward, false},
            { BindableActions.FaceLeft, false},
            { BindableActions.FaceRight, false},
            
            { BindableActions.OpenMenu, false},
            { BindableActions.Interact, false},
            { BindableActions.Confirm, false},
        };

        /// <summary>
        /// Clears the players saved keybinds and resets them to defaults, also clears the Keybinding section of the userPref file.
        /// </summary>
        public static void ResetBindings()
        { 
            moveForwardKey = new Keybind(Keys.W);
            moveBackwardKey = new Keybind(Keys.S);
            moveLeftKey = new Keybind(Keys.A);
            moveRightKey = new Keybind(Keys.D);
            
            faceForwardKey = new Keybind(Keys.Up);
            faceBackwardKey = new Keybind(Keys.Down);
            faceLeftKey = new Keybind(Keys.Left);
            faceRightKey = new Keybind(Keys.Right);
            
            openMenuKey = new Keybind(Keys.Escape);
            interactKey = new Keybind(Keys.E);
            confirmKey = new Keybind(Keys.Enter);
        }
    }
    
    public static int horizontal;
    public static int vertical;

    public static void Update()
    {
        if (Bindings.activeBindings[Bindings.BindableActions.MoveForward])
            vertical = 1;
        else if (Bindings.activeBindings[Bindings.BindableActions.MoveForward])
            vertical = -1;
        else 
            vertical = 0;
        
        if (Bindings.activeBindings[Bindings.BindableActions.MoveRight])
            horizontal = 1;
        else if (Bindings.activeBindings[Bindings.BindableActions.MoveLeft])
            horizontal = -1;
        else 
            horizontal = 0;
    }
}
