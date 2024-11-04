// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//NUMBER 1
//Integer variable
//int age = 25;
//Console.WriteLine(age.GetType());

//Double variable
//double height = 5.9;
//Console.WriteLine(height.GetType());

//Character variable
//char grade = 'A';
//Console.WriteLine(grade.GetType());

//String variable
//string name = "Alice";
//Console.WriteLine(name.GetType());

//Boolean variable
//bool isStudent = true;
//Console.WriteLine(isStudent.GetType());

//NUMBER 2
//Console.Write("Please enter your age: ");
//string ageInput = Console.ReadLine();

//int age = int.Parse(ageInput);
//Console.WriteLine(age);

//Console.Write("Please enter your height: ");
//string heightInput = Console.ReadLine();

//double height = double.Parse(heightInput);
//Console.WriteLine(height);

//bool isAdult = age >= 18;

//if (isAdult)
//{
//    Console.WriteLine("You are an adult");
//}
//else
//{
//    Console.WriteLine("You are not an adult");
//}

//NUMBER 3
//const double Pi = 3.14159;
//Console.Write("Enter Radius: ");
//string radInput = Console.ReadLine();

//double rad = double.Parse(radInput);
//double area = Math.PI * rad * rad;

//Console.WriteLine("Area of circle is: " + area);

//Console.Write("Enter Radius: ");
//double rad = Convert.ToDouble(Console.ReadLine());
//double area = Math.PI * rad * rad;
//Console.WriteLine("Area of circle is: " + area); 

//NUMBER 4

//int a = 5;
//int b = 3;
//double c;
//c = a * b;
//Console.WriteLine("Product of {0} and {1} is {2}", a, b, c);

//In the program, a and b are int variables that contain the
//values 5 and 3 respectively. They are multiplied and the
//resultant value in stored in c which is of type double.
//This shows implicit type conversion. Then the values of
//a, b and c are displayed. 

//double a = 7.5;
//double b = 3.5;
//double c;
//int d;
//c = a * b;
//d = (int)c;
//Console.WriteLine("Product of {0} and {1} is {2}", a, b, c);
//Console.WriteLine("Value after Explicit Type Conversion is {0}", d);

//In the program, a and b are double variables that contain the values
//7.5 and 3.5 respectively. They are multiplied and the resultant value
//in stored in c which is also of type double. Then the value of c is stored
//in d using explicit type casting as d is of type int.

// Step 1: Define a double variable with a decimal value
//double originalValue = 9.99;

// Step 2: Implicit conversion to int (requires explicit cast in this case)
//int implicitConversion = (int)originalValue; // Explicit cast from double to int

// Step 3: Explicit conversion back to double
//double explicitConversion = implicitConversion;

// Step 4: Print the results
//Console.WriteLine($"Original double value: {originalValue}");
//Console.WriteLine($"After explicit conversion to int: {implicitConversion} (Data loss occurred: {originalValue - implicitConversion})");
//Console.WriteLine($"Explicitly cast back to double: {explicitConversion}");


//NUMBER 2 PART TWO
//int i = 20;

//double d = i;
//Console.WriteLine( i.GetType());
//Console.WriteLine( d.GetType() );


//NUMBER 3 PART TWO
//double d = 7.65;

//int i = (int)d;
//Console.WriteLine(d);
//Console.WriteLine(i);
//Console.WriteLine("There was a data loss of .65 while the double was cast to an int");

//Console.Write("Enter a double value: ");

//double userInput = double.Parse(Console.ReadLine());

//int i = (int)userInput;

//Console.WriteLine(userInput);
//Console.WriteLine(i);
//The decimal is removed from the double because it is 
// from a double to an int.