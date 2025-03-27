using System;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Monogon.GameContent.Scenes;

namespace Monogon.Engine;

public class MonogonEngine : Game
{
    // Engine
    public static GraphicsDeviceManager graphics { get; private set; }
    public static SpriteBatch spriteBatch { get; private set; }
    private SceneManager sceneManager = new SceneManager();
    public static MonogonEngine instance { get; private set; }
    private Debug_01 debug_01 = new Debug_01();
    
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
    
    public MonogonEngine(int width, int height, bool fullscreen, bool vSync)
    {
        instance = this;
        base.Window.Title = windowTitle;
        IsMouseVisible = true;
        this.width = width;
        this.height = height;
        this.fullscreen = fullscreen;
        this.vSync = vSync;
        Content.RootDirectory = "Content";
        graphics = new GraphicsDeviceManager(this);
        graphics.DeviceReset += OnDeviceReset;
        graphics.DeviceCreated += OnDeviceCreated;
        base.Window.ClientSizeChanged += OnClientSizeChanged;
    }

    protected sealed override void Initialize()
    {
        if (fullscreen)
        {
            graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            graphics.IsFullScreen = true;
        }
        else
        {
            graphics.PreferredBackBufferWidth = windowWidth;
            graphics.PreferredBackBufferHeight = windowHeight;
            graphics.IsFullScreen = false;
        }
        graphics.SynchronizeWithVerticalRetrace = vSync;
        graphics.ApplyChanges();
        
        sceneManager.Add(debug_01, this);
        sceneManager.Set(debug_01);
        
        // Call GameInitialize AFTER all Monogon initialization logic has been completed.
        //GameInitialize();
    }

    protected sealed override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);
        
        // Call GameLoad AFTER all Monogon loading logic has been completed.
        //GameLoad();
    }

    protected sealed override void Update(GameTime gameTime)
    {
        Time.Update(gameTime);
        
        // Don't give the SceneManager IUpdatable because it has to be updated BEFORE everything else.
        sceneManager.Update(Time.deltaTime, this);
        
        // Call GameUpdate AFTER all Monogon update logic has been completed.
        //GameUpdate(Time.deltaTime);
    }

    //TODO: If DeveloperMode is enabled, draw some extra UI with useful information
    protected sealed override void Draw(GameTime gameTime)
    {
        sceneManager.Draw(this);
        
        // Call GameDraw AFTER all Monogon drawing logic has been completed.
        //GameDraw(Time.deltaTime);
    }
    
    /*
    protected abstract void GameInitialize();
    protected abstract void GameUpdate(float deltaTIme);
    protected abstract void GameLoad();
    protected abstract void GameDraw(float deltaTIme);
    */

    private protected void OnDeviceReset(object sender, EventArgs e)
    {
        
    }

    private protected void OnDeviceCreated(object sender, EventArgs e)
    {
        
    }

    private protected void OnClientSizeChanged(object sender, EventArgs e)
    {
        
    }
}