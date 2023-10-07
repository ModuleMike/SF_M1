
double radius, pie;

Console.Write("Enter a radius: ");

radius = double.Parse(Console.ReadLine());

pie = Math.PI;

Console.WriteLine("A circle with radius " + radius + " has an area of " + (pie * (radius * radius)) + ".");
