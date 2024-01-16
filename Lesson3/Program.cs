// Functions 

// Example of function
// Square - name of function , value - parametr of function (type of variable)
// int (type of variable) - in beggining of function is a type of returned variable

int Square(int value)
{
    int result = value * value;
    return result;
}

// Example of function - 2

int Multiply(int value1, int value2)
{
    int result = value1 * value2;
    return result;
}

// !!! If the function does not return anything, we are indicate type of variable - void !!!
// Types of function

// First type - without parametrs and does not return value

void ShowHelloMessage()
{
    Console.WriteLine("Hello World!"); // Side effect of function 
}

// Second type - without parametrs and returned value

double GetPi()
{
    return 3.14159;
}

// Third type - With parametrs and does not return value

void ShowHelloMessage(string message)
{
    Console.WriteLine(message);
}

// Four type - With parametrs and returned value

int AddValues(int a,int b)
{
    int result = a + b;
    return result;
}
