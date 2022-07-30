def calculate_bmi():
    height = float(input("Enter your height in meters: "))
    weight = float(input("Enter your weight in kg: "))
    bmi = weight / (height ** 2)
    print("Your BMI is: {0} and you are: ".format(bmi), end='')

    if bmi < 15:
        print("Very severely underweight")
    elif 15 <= bmi < 16:
        print("Severely underweight")
    elif 16 <= bmi < 18.5:
        print("Underweight")
    elif 18.5 <= bmi < 25:
        print("Normal (healthy weight)")
    elif 25 <= bmi < 30:
        print("Overweight")
    elif 30 <= bmi < 35:
        print("Moderately obese")
    elif 35 <= bmi < 40:
        print("Severely obese")
    else:
        print("Very severely obese")

calculate_bmi()