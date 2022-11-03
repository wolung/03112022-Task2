Console.WriteLine("Celsius, Fahrenheit, Kelvin converter.");
Console.WriteLine("What do you want to do?");
Console.WriteLine("1 - Convert Celsius to Fahrenheit");
Console.WriteLine("2 - Convert Fahrenheit to Celsius");
Console.WriteLine("3 - Convert Celsius to Kelvin");
int menu = Convert.ToInt32(Console.ReadLine());

if (menu == 1)
{

    Console.WriteLine("Enter the amount of Celsius: ");
    double cel = Convert.ToDouble(Console.ReadLine());
    double far = cel*18/10+32;
    Console.WriteLine("Fahrenheit = " +far);

}
else
{

if (menu == 2)
{
    Console.WriteLine("Enter the amount of Fahrenheit: ");
    double far = Convert.ToDouble(Console.ReadLine());
    double cel = (far-32)*10/18;
    Console.WriteLine("Celsius = "+cel);
}
else
{
if (menu == 3)
{
    Console.WriteLine("Enter the amount of Celsius: ");
    double kel = Convert.ToDouble(Console.ReadLine());
    double cel = kel+273.15;
    Console.WriteLine("Kelvin = "+cel);
}
else
{
   Console.WriteLine("Wrong choice"); 
}
}
}


Console.ReadKey();
