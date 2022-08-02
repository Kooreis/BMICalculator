# Python Documentation

# BMI Calculator

This Python script is a simple Body Mass Index (BMI) calculator. The Body Mass Index is a measure that uses your height and weight to work out if your weight is healthy. The BMI calculation divides an adult's weight in kilograms by their height in meters squared.

## How it works

The script prompts the user to input their height (in meters) and weight (in kilograms). It then calculates the BMI using the formula `weight / (height ** 2)`. The result is then printed out to the console.

The script also categorizes the user's BMI into one of the following categories:

- Very severely underweight
- Severely underweight
- Underweight
- Normal (healthy weight)
- Overweight
- Moderately obese
- Severely obese
- Very severely obese

These categories are based on the standard BMI categories defined by the World Health Organization.

## Libraries

This script does not use any imported libraries. It only uses built-in Python functions.

## Usage

To use this script, simply run it in a Python environment. You will be prompted to enter your height and weight. After entering these values, the script will calculate and print out your BMI and its corresponding category.

```python
calculate_bmi()
```

Please note that this script is intended for educational purposes and should not be used as a substitute for professional medical advice.

---

# C# Documentation

# C# BMI Calculator

This is a simple console application written in C# that calculates the Body Mass Index (BMI) of a user. The user is prompted to input their weight (in kilograms) and height (in meters), and the program calculates their BMI and provides a health status based on the calculated BMI.

## Code Explanation

The script begins by importing the `System` namespace. This namespace contains fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions.

```csharp
using System;
```

The `Program` class is defined, which is the entry point of the application.

```csharp
class Program
```

The `Main` method is the entry point of the program. It is where the program control starts and ends. It is the most important method in a C# console application.

```csharp
static void Main(string[] args)
```

The user is prompted to enter their weight in kilograms and height in meters. The entered values are read from the console and converted to `double` data type.

```csharp
Console.Write("Enter weight in Kilograms: ");
double weight = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter height in Meters: ");
double height = Convert.ToDouble(Console.ReadLine());
```

The BMI is calculated using the formula `weight / height^2`.

```csharp
double bmi = weight / Math.Pow(height, 2);
```

The calculated BMI is then displayed on the console.

```csharp
Console.WriteLine("Your BMI is " + Math.Round(bmi, 2));
```

Finally, based on the calculated BMI, the health status of the user is determined and displayed on the console.

```csharp
if (bmi < 18.5)
{
    Console.WriteLine("You are underweight.");
}
else if (bmi < 24.9)
{
    Console.WriteLine("You are normal weight.");
}
else if (bmi < 29.9)
{
    Console.WriteLine("You are overweight.");
}
else
{
    Console.WriteLine("You are obese.");
}
```

## Libraries Used

- `System`: This is a built-in namespace in C#. It provides classes that are used for a wide variety of operations such as input/output via streams, string manipulation, exception handling, and more. In this script, it is used for console operations and mathematical calculations.

---

# Java Documentation

# Java BMI Calculator

This is a simple Java program that calculates the Body Mass Index (BMI) of a user. The user is prompted to input their weight (in kilograms) and height (in meters), and the program calculates their BMI and prints it out. It also provides a health status based on the calculated BMI.

## Code Explanation

The script is written in Java and uses the `java.util.Scanner` class for reading the user's input.

### Import Statement

```java
import java.util.Scanner;
```

The `java.util.Scanner` class is a simple text scanner which can parse primitive types and strings using regular expressions. It is used in this script to read the user's weight and height from the standard input.

### Main Method

The `main` method is the entry point for any Java application. The Java Virtual Machine (JVM) calls the `main` method when the program starts.

```java
public static void main(String[] args) {
```

### Scanner Object

A `Scanner` object is created to read the user's input.

```java
Scanner scanner = new Scanner(System.in);
```

### User Input

The user is prompted to enter their weight and height, which are read as `double` values.

```java
System.out.println("Enter your weight in kg: ");
double weight = scanner.nextDouble();

System.out.println("Enter your height in meters: ");
double height = scanner.nextDouble();
```

### BMI Calculation

The BMI is calculated using the formula `weight / (height * height)`.

```java
double bmi = weight / (height * height);
```

### BMI Output and Health Status

The calculated BMI is printed out, and a health status is provided based on the BMI value.

```java
System.out.println("Your BMI is: " + bmi);

if (bmi < 18.5) {
    System.out.println("You are underweight.");
} else if (bmi >= 18.5 && bmi < 24.9) {
    System.out.println("You are normal weight.");
} else if (bmi >= 25 && bmi < 29.9) {
    System.out.println("You are overweight.");
} else {
    System.out.println("You are obese.");
}
```

The health status is determined as follows:

- Underweight: BMI less than 18.5
- Normal weight: BMI between 18.5 and 24.9
- Overweight: BMI between 25 and 29.9
- Obese: BMI 30 or more

---
