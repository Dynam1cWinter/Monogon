using System.Collections.Generic;

namespace Monogon.Engine;

public class SceneManager
{
    public List<Scene> Rooms = new List<Scene>();

    public int count
    {
        get
        {
            return Rooms.Count;
        }
    }

    public int selected;

    public void Update(float deltaTime, MonogonEngine monogon)
    {
        for (int i = 0; i < count; i++)
        {
            Scene room = Rooms[i];
            if (room.ID == selected)
                room.Update(deltaTime, monogon);
        }
    }

    public void Draw(MonogonEngine monogon)
    {
        for (int i = 0; i < count; i++)
        {
            Scene room = Rooms[i];
            if (room.ID == selected)
                room.Draw(monogon);
        }
    }

    public virtual void Set(int ID)
    {
        selected = ID;
    }

    public virtual void Set(Scene room)
    {
        selected = room.ID;
    }

    public void Add(Scene room, MonogonEngine monogon)
    {
        Rooms.Add(room);
        room.Awake(monogon);
    }

    public void Remove(Scene room)
    {
        Rooms.Remove(room);
    }

    public void Clear()
    {
        Rooms.Clear();
    }
}