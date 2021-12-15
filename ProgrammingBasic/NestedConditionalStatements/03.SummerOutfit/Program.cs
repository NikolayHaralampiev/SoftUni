﻿// See https://aka.ms/new-console-template for more information

//Градусите - цяло число в интервала [10…42]
//Текст, време от денонощието - с възможности - "Morning", "Afternoon", "Evening"
//Да се отпечата на конзолата на един ред: "It's {градуси} degrees, get your {облекло} and {обувки}."


int degrees = int.Parse(Console.ReadLine());
string time = Console.ReadLine();
string outfit = "";
string shoes = "";

if (degrees >= 10 && degrees <= 18)
{
    if (time == "Morning")
    {
        outfit = "Sweatshirt";
        shoes = "Sneakers";
    }
    else if (time == "Afternoon" || time == "Evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
}

if (degrees >= 18 && degrees <= 24)
{
    if (time == "Morning")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else if (time == "Afternoon")
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
    else
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }

}

if (degrees >= 25)
{
    if ((time == "Morning"))
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
    else if (time == "Afternoon")
    {
        outfit = "Swim Suit";
        shoes = "Barefoot";
    }
    else
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
}

Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
