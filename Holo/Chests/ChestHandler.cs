using System.Collections.Concurrent;

namespace Holo.Chest;

public static class ChestHandler
{
    public static readonly ConcurrentDictionary<int, Chest> Chests = [];

    public static void AddChest(int id, float posX, float posY, String name)
    {
        Chest c = new(id, posX, posY, name);
        Chests.AddOrUpdate(id, c, (_, _) => c);
    }

    public static void RemoveChest(int id)
    {
        Chests.TryRemove(id, out _);
    }

    public static void Reset()
    {
        Chests.Clear();
    }
}
