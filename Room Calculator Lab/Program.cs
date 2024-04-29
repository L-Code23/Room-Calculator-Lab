// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");



Console.WriteLine(" Welcome to the Grand Circus Room Calculator.");
Console.WriteLine("What is the length of your room?");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("What is the width of your room?");
double width = double.Parse(Console.ReadLine());
double perimiter = (length + width) *2;
Console.WriteLine(" The perimiter of your room is " + perimiter + " feet.");
double area = length * width;
Console.WriteLine("The area of your room is " + area + " square feet.");

if( area <= 250)
{
    Console.WriteLine("Your room is small.");
}
else if(area >= 250 && area <= 650){
    Console.WriteLine("Your room is medium sized.");
}
else if(area >= 650)
{
    Console.WriteLine("Your room is large.");
}


Console.WriteLine("What is the height of your room?");
double height = double.Parse(Console.ReadLine());
double volume = width * height * length;
Console.WriteLine("The volume of your room is " + volume + " cubic feet.");

double surfaceArea = 2* (length * height) + 2* (width * height) + 2*(length * width);
Console.WriteLine("The surface area of your room is " + surfaceArea + " square feet.");