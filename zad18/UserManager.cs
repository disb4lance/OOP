namespace zad18
{
    public class UserManager : IUserManager
    {


        public WeatherForecast add(WeatherForecast x) {
            WeatherForecast a = new WeatherForecast();
            a.id = x.id;
            a.name = x.name;
            return a;
        }
    }
}
