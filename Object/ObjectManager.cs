using System.Collections.Generic;

namespace Monogon.Engine.Object;

public class ObjectManager
{
    public List<GameObject> objects = new List<GameObject>();

    public int count
    {
        get
        {
            return objects.Count;
        }
    }

    public ObjectManager()
    {
    }

    public void Update(float deltaTime, MonogonEngine monogon)
    {
        for (int i = 0; i < count; i++)
        {
            GameObject obj = objects[i];
            if (obj.rendered)
            {
                obj.SetBounds(obj.x, obj.y, obj.width, obj.height);
                obj.Update(deltaTime, monogon);
            }
        }
    }

    public void Draw(MonogonEngine monogon)
    {
        for (int i = 0; i < count; i++)
        {
            GameObject obj = objects[i];
            if (obj.rendered && obj.visible)
                obj.Draw(monogon);
        }
    }
    
    // Sets
    public void Add(GameObject obj, MonogonEngine monogon)
    {
        objects.Add(obj);
        obj.Awake(monogon);
    }
    public virtual void Remove(GameObject obj, MonogonEngine monogon)
    {
        obj.Destroy(monogon);
        objects.Remove(obj);
    }
    public virtual void Remove(int index, MonogonEngine monogon)
    {
        objects[index].Destroy(monogon);
        objects.Remove(objects[index]);
    }
    public void Clear()
    {
        objects.Clear();
    }
    
    // Gets
    public int GetCount()
    {
        return count;
    }
}