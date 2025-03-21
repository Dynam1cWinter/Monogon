# Monogon

using System;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Monogon.Engine;

[assembly: AssemblyVersion("1.0.*")]
public abstract class MonogonEngine : Game
{
    // Engine
    public static GraphicsDeviceManager graphics { get; private set; }
    public static SpriteBatch spriteBatch { get; private set; }
    
    public static Color clearColor = Color.Gray;
    
    public bool developerMode { get; set; } = false;
    
    public static Version version = Assembly.GetExecutingAssembly().GetName().Version;
    
    // Window
    public string windowTitle = $"Monogon Engine, Ver: {version.Major}.{version.Minor}.{version.Build}";
    
    public int width;
    public int height;

    public int windowWidth
    {
        get
        {
            return width;
        }
    }
    public int windowHeight
    {
        get
        {
            return height;
        }
    }
    
    public bool fullscreen;
    public bool vSync;
    
    protected MonogonEngine(int width, int height, bool fullscreen, bool vSync)
    {
        this.width = width;
        this.height = height;
        this.fullscreen = fullscreen;
        this.vSync = vSync;
        graphics = new GraphicsDeviceManager(this);
    }

    protected sealed override void Initialize()
    {
        graphics.PreferredBackBufferWidth = windowWidth;
        graphics.PreferredBackBufferHeight = windowHeight;
        graphics.IsFullScreen = fullscreen;
        graphics.SynchronizeWithVerticalRetrace = vSync;
        graphics.ApplyChanges();
        
        // Call GameInitialize AFTER all Monogon initialization logic has been completed.
        GameInitialize();
    }

    protected sealed override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);
        
        // Call GameLoad AFTER all Monogon loading logic has been completed.
        GameLoad();
    }

    protected sealed override void Update(GameTime gameTime)
    {
        
        // Call GameUpdate AFTER all Monogon update logic has been completed.
        GameUpdate(Time.deltaTime);
    }

    //TODO: If DeveloperMode is enabled, draw some extra UI with useful information
    protected sealed override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(clearColor);
        
        // Call GameDraw AFTER all Monogon drawing logic has been completed.
        GameDraw(Time.deltaTime);
    }
    
    protected abstract void GameInitialize();
    protected abstract void GameUpdate(float deltaTIme);
    protected abstract void GameLoad();
    protected abstract void GameDraw(float deltaTIme);
}
