namespace skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Facade;

public class Inventory
{
    public bool CheckInventory(string itemId)
    {
        return true; // just return true to keep example simple
    }

    public void ReduceInventory(string itemId, int amount)
    {
        System.Console.WriteLine("Reducing inventory of " + itemId + " by " + amount);
    }
}
