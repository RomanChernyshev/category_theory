static Func<A, C> Compose<A, B, C>(Func<A, B> first, Func<B, C> second) =>
    arg => second(first(arg));

static T Id<T>(T x) => x;

static float AverageAirTemperatureInCelsius(float h) => 15f - 0.0065f * h;

static float CelsiusToFahrenheit(float c) => c * 1.8f + 32f;

Func<float, float> averageAirTemperatureInFahrenheit = Compose<float, float, float>(AverageAirTemperatureInCelsius, CelsiusToFahrenheit);

Console.WriteLine(averageAirTemperatureInFahrenheit(166)); // 57,0578

averageAirTemperatureInFahrenheit = Compose(averageAirTemperatureInFahrenheit, Id);

Console.WriteLine(averageAirTemperatureInFahrenheit(166)); // 57,0578
