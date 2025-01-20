using System;
using System.Globalization;

//NUMBER 1
//class Program
//{
//    static void Main()
//    {
//        for (int i = 0; i <= 100; i++)
//        {
//            if (i % 3 == 0 && i % 5 == 0)
//            {
//                Console.WriteLine("FizzBuzz");
//            }
//            else if (i % 3 == 0)
//            {
//                Console.WriteLine("Fizz");
//            }
//            else if (i % 5 == 0)
//            {
//                Console.WriteLine("Buzz");
//            }
//            else
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}


//NUMBER 2
//class Program
//{
//    static void Main()
//    {
//        Console.Write("How many numbers do you want to process? ");
//        int count = int.Parse(Console.ReadLine()); //makes sure the stored input is an integer

//        int[] numbers = new int[count]; //creates an array named numbers and initializes a memory capacity using the value stored by int count

//        for (int i = 0; i < count; i++) //loop for the prompts depending on the desired number of inputs
//        {
//            Console.Write($"What is the number in {i + 1}?: ");
//            numbers[i] = int.Parse(Console.ReadLine());
//        }

//        int sum = 0; //initialize the value of sum to 0 and add each input values accordingly
//        int largest = numbers[0]; //initialize the first element in the array as largest and updates accordingly
//        int smallest = numbers[0]; //same function

//        foreach (int num in numbers) //go through the array to calculate sum, find largest and smallest
//        {
//            sum += num; // sum = sum + num

//            if (num > largest) //update largest
//                largest = num;

//            if (num < smallest) //update smallest
//                smallest = num;
//        }

//        Console.WriteLine($"\nThe sum of the array is: {sum}");
//        Console.WriteLine($"The largest number in the array is {largest}");
//        Console.WriteLine($"The smallest number in the array is {smallest}");
//    }
//}


//NUMBER 3
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter your password: ");
//        string password = Console.ReadLine();

//        // Check the strength of the password
//        bool strongPass = CheckPasswordStrength(password);

//        // display if password is strong or weak
//        if (strongPass)
//        {
//            Console.WriteLine("Your password is Strong.");
//        }
//        else
//        {
//            Console.WriteLine("Your password is Weak.");
//            Console.WriteLine("Password should have at least 8 characters and contains uppercase, lowercase, digits, and special characters.");
//        }
//    }

//    // Checks if password input satisfies the requirements.
//    static bool CheckPasswordStrength(string password)
//    {
//        // Check at least 8 characters
//        if (password.Length < 8)
//        {
//            return false; // returns false if the password is short
//        }

//        // Initialize flags to track characters
//        bool hasUpper = false;   // check for at least one uppercase letter
//        bool hasLower = false;   // check for at least one lowercase letter
//        bool hasDigit = false;   // check for at least one digit
//        bool hasSpecial = false; // check for at least one special character

//        // Loop through each character in the input password
//        foreach (char c in password)
//        {
//            if (char.IsUpper(c)) hasUpper = true;          // Check for uppercase letters and set flag "hasUpper" true
//            if (char.IsLower(c)) hasLower = true;          // Check for lowercase letters
//            if (char.IsDigit(c)) hasDigit = true;          // Check for digits
//            if (!char.IsLetterOrDigit(c)) hasSpecial = true; // Check for special characters by checking if char is letter or digit and negate the flag value

//            if (hasUpper && hasLower && hasDigit && hasSpecial)
//            {
//                return true;
//            }
//        }
//        return false;
//    }
//}


//NUMBER 4
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a number: ");
//        int number = int.Parse(Console.ReadLine());

//        // initialize result to 1
//        long result = 1;

//        // calculation of factorial
//        for (int i = 1; i <= number; i++)
//        {
//            result *= i; //result = result * i
//        }

//        Console.WriteLine($"The factorial of {number} is: {result}");
//    }
//}

