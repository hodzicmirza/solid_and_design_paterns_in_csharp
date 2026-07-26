namespace skyline_talent_program.DIZAJN_PATERNI.KREACIJSKI_PATERNI.Builder;

public interface IBuilder
{
    void Reset();
    IBuilder SetCarType(CarType type);
    IBuilder SetSeats(int seats);
    IBuilder IsConvertible(bool isConvertible);
    IBuilder SetEngine(Engine engine);
    IBuilder SetWheels(Wheels wheels);
    IBuilder SetDashboard(Dashboard dashboard);
    IBuilder SetGPSNavigator(GPSNavigator gpsNavigator);
}
