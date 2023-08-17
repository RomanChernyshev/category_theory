main :: IO ()

averageAirTemperatureInCelsius :: Float -> Float
averageAirTemperatureInCelsius h = 15.0 - 0.0065 * h

celsiusToFahrenheit :: Float -> Float
celsiusToFahrenheit c = c * 1.8 + 32.0

averageAirTemperatureInFahrenheit :: Float -> Float
averageAirTemperatureInFahrenheit =  celsiusToFahrenheit . averageAirTemperatureInCelsius

main = do
    print . averageAirTemperatureInFahrenheit $ 166 --57.0578
    print . averageAirTemperatureInFahrenheit . id $ 166 --57.0578