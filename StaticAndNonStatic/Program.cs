// See https://aka.ms/new-console-template for more information

/*
    Static and Non-Static Methods
    - Static methods are called on the class itself, not on instances of the class.
    - Non-static methods are called on instances of the class.
    - Static methods can only access static members of the class.
    - Non-static methods can access both static and non-static members of the class.
 */

static int sum(int a, int b)
{
    return a + b;
}

void callSum()
{
    int s = sum(5, 8);
}

double avarage(int a, int b)
{
    return (double)(a + b) / 2;
}

static void callAvarage()
{
    double av = avarage(5, 8); //Error because avarage is non-static method which mean it is not created
}
