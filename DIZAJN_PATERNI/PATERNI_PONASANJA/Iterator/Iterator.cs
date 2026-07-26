namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Iterator;

public interface IIterator<T>
{
    void Next();
    T Current();
    bool HasNext();
}
