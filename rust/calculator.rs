

use std::ops::{Add, Mul, Sub, Div, Rem};
use std::fmt::Display;
use std::io::{self, Write};
use std::thread;
use std::time::Duration;

type Operator = fn(f64, f64) -> f64;

fn string_to_operator(string: &str) -> Option<Operator> {

    match string {

        "+" => Some(Add::add),
        "-" => Some(Sub::sub),
        "*" => Some(Mul::mul),
        "/" => Some(Div::div),
        "%" => Some(Rem::rem),

        _ => None
    }
}

fn string_to_operand(string: &str) -> Option<f64> { string.parse().ok() }

/// helper function to print to the console without skipping
/// a line because ['print!'] doesn't flush the buffer
fn print_then_flush(message: impl Display) -> io::Result<()> {
    print!("{}", message);
    io::stdout().flush()
}

/// Clears the given buffer, writes input to it
/// and returns a slice of it with whitespace removed
fn read_input(buffer: &mut String, txt: impl Display) -> io::Result<&str> {
    buffer.clear();
    print_then_flush(txt)?;
    io::stdin().read_line(buffer)?;
    Ok(buffer.trim())
}

/// Reads input using the provided buffer, attempts to parse it
/// using the provided function, and keeps retrying until it succeeds
fn get_input<T>(
    buffer: &mut String,
    process: impl Fn(&str) -> Option<T>,
    output_type: &str
) -> io::Result<T> {

    loop {

        let Some(x) = process(read_input(
            buffer,
            format!("Enter an {output_type}: ")
        )?) else {

            println!("Invalid {output_type}! Please try again.");
            continue;
        };
        return Ok(x);
    }
}

fn main() -> io::Result<()> {

    let mut buffer = String::new();

    loop {

        println!();

        let lhs = get_input(&mut buffer, string_to_operand, "operand")?;
        let op = get_input(&mut buffer, string_to_operator, "operator")?;
        let rhs = get_input(&mut buffer, string_to_operand, "operand")?;

        for txt in ["And the answer is", ".", ".", "."] {
            print_then_flush(txt)?;
            thread::sleep(Duration::from_millis(150));
        }
            
        println!(" {}", op(lhs, rhs));

        if read_input(&mut buffer, "Again (y / N) : ")? == "N" { break }
    }
    Ok(())
}
