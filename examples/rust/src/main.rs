use std::convert::identity;

fn average_air_temperature_in_celsius(h: f32) -> f32 {
    15.0 - 0.0065 * h
}

fn celsius_to_fahrenheit(c: f32) -> f32 {
    c * 1.8 + 32.0
}

fn compose<A, B, C, GFunc, FFunc>(f: FFunc, g: GFunc) -> impl Fn(A) -> C
where
    FFunc: Fn(A) -> B,
    GFunc: Fn(B) -> C,
{
    move |x| g(f(x))
}

fn main() {
    let average_air_temperature_in_fahrenheit =
        compose(average_air_temperature_in_celsius, celsius_to_fahrenheit);
    
    println!("{}", average_air_temperature_in_fahrenheit(166.0)); // 57.0578
    println!("{}", compose(identity, average_air_temperature_in_fahrenheit)(166.0)); // 57.0578
}
