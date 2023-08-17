let averageAirTemperatureInCelsius(h: float) =
    15.0 - 0.0065 * h

let celsiusToFahrenheit (c: float) =
    c * 1.8 + 32.0

let averageAirTemperatureInFahrenheit(h: float) =
    averageAirTemperatureInCelsius >> celsiusToFahrenheit <| h

averageAirTemperatureInFahrenheit >> printfn "%f" <| 166; // 57,0578
averageAirTemperatureInFahrenheit >> id >> printfn "%f" <| 166; // 57,0578