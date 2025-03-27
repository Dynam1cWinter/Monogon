using Microsoft.Xna.Framework;

namespace Monogon.Engine.Object;

public abstract class GameObject
{
    // Dimensions
    public float x, y;
    public float xSpeed, ySpeed;
    public int width, height;

    public Vector2 position
    {
        get
        {
            return new Vector2(x, y);
        }
        set
        {
            x = value.X;
            y = value.Y;
        }
    }
    public Vector2 velocity
    {
        get
        {
            return new Vector2(xSpeed, ySpeed);
        }
        set
        {
            xSpeed = value.X;
            ySpeed = value.Y;
        }
    }
    public Vector2 size
    {
        get
        {
            return new Vector2(width, height);
        }
        set
        {
            width = (int)value.X;
            height = (int)value.Y;
        }
    }
    public Rectangle bounds;
    
    // Properties
    public int id;
    public string text, tag;
    public bool rendered, visible;
    public bool collision, hover;
    
    // Sprite
    public Vector2 spritePosition;

    public GameObject(int x, int y, int width, int height, int id)
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
        bounds = new Rectangle(x, y, width, height);
        
        this.id = id;
        rendered = true;
        visible = true;
        collision = false;
        hover = false;
        spritePosition = Vector2.Zero;
    }
    
    // Abstract
    public abstract void Awake(MonogonEngine monogon);
    public abstract void Destroy(MonogonEngine monogon);
    public abstract void Update(float deltaTime, MonogonEngine monogon);
    public abstract void Draw(MonogonEngine monogon);
    
    // Sets
    public void SetPosition(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public void SetVelocity(float xVel, float yVel)
    {
        this.xSpeed = xVel;
        this.ySpeed = yVel;
    }

    public void SetSize(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public void SetBounds(float x, float y, int width, int height)
    {
        this.bounds = new Rectangle((int)x, (int)y, width, height);
    }
    
    // Gets
    public int GetID()
    {
        return id;
    }

    public float DistanceTo(Vector2 pos)
    {
        return Vector2.Distance(position, pos);
    }

    public Vector2 GetPositionCentered()
    {
        return new Vector2(x + (width / 2), y + (height / 2));
    }
}