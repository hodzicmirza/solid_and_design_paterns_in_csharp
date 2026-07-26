namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Visitor;

public interface Visitor
{
    void VisitRetail(Retail retail);

    void VisitLaw(Law law);

    void VisitRestaurant(Restaurant restaurant);
}
