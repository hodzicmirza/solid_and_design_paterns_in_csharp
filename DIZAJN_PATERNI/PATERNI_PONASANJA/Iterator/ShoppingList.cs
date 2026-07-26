namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Iterator;

public class ShoppingList
{
    public List<string> _list = new List<string>();

    public void Push(string itemName)
    {
        _list.Add(itemName);
    }

    public string Pop()
    {
        var last = _list.Last();
        this._list.Remove(last);
        return last;
    }

    public List<string> GetList()
    {
        return this._list;
    }

    public IIterator<string> CreateIterator()
    {
        return new ListIterator(this);
    }

    private class ListIterator : IIterator<string> // ugnijezdena klasa zbog toga da moze samo ove elemente iterirari i da se me moze u ostalim dijelovima programa koristiti
    {
        private ShoppingList _shoppingList;

        private int _index;

        public ListIterator(ShoppingList shoppingList)
        {
            this._shoppingList = shoppingList;
        }

        public string Current()
        {
            return _shoppingList._list[_index];
        }

        public void Next()
        {
            this._index++;
        }

        public bool HasNext()
        {
            return _index < _shoppingList._list.Count;
        }
    }
}
