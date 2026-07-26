namespace skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Composite;

public class Box : Item
{
    private List<Item> items = new List<Item>();

    public void Add(Item item)
    {
        items.Add(item);
    }

    public float GetPrice()
    {
        float total = 0f;
        foreach (var item in items)
        {
            total += item.GetPrice();
        }
        return total;
    }
}
