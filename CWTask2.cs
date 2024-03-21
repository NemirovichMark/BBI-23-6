using System;

public abstract class Embrasure
{
    public string Name { get; set; }
    public double Width { get; set; }
    public double Length { get; set; }
    public double Height { get; set; }
    public double Rasch { get; set; }
    public Embrasure(string  name, double width, double length, double height, double rasch)
    {
        Name = name; Width = width; Length = length; Height = height; Rasch = rasch;
    }

    public abstract double Price();
}

public class Window : Embrasure
{
    public Window(string name, double width, double length, double height, double rasch) : base(name, width, length, height, rasch)
    {
        Name = name; Width = width; Length = length; Height = height; Rasch = rasch;
    }
    public int Layers { get; set; }

    public override double Price()
    {
        return Layers * 50 + Width * Length * 0.02;
    }
}

public class Door : Embrasure
{
    public bool Pattern { get; set; }
    public bool Glass { get; set; }
    public Door(string name, double width, double length, double height, double rasch) : base(name, width, length, height, rasch)
    {
        Name = name; Width = width; Length = length; Height = height; Rasch = rasch;
    }

    public override double Price()
    {
        double price = Width * Length * 1;
        if (Pattern)
        {
            price += 100;
        }
        if (Glass)
        {
            price += 150;
        }
        return price;
    }
}

class Program
{
    static void Main()
    {
        Window[] windows = new Window[5];
        windows[0] = new Window("Window", 3, 7, 0.5, 1320);
        windows[1] = new Window("Ddsd", 4, 95, 34, 1230);
        windows[2] = new Window("Eergffd", 6, 29, 23, 1435);
        windows[3] = new Window("Wbghgrf", 43, 35, 34, 980);
        windows[4] = new Window("Tdsd", 12, 100, 45, 3456);
        Console.WriteLine(windows[0].Name + " " + windows[0].Width + " " + windows[0].Length + " " + windows[0].Height+ " " + windows[0].Price());
        Door[] doors = new Door[5];
        doors[0] = new Door("Door", 34, 21, 53, 34);
        doors[1] = new Door("Sadde", 34, 21, 53, 34);
        doors[2] = new Door("WEFDsd", 34, 21, 53, 34);
        doors[3] = new Door("Sdfvd", 34, 21, 53, 34);
        doors[4] = new Door("DgVrr", 34, 21, 53, 34);
        //for (int i = 0; i < 5; i++)
        //{
        //    windows[i] = new Window { Name = "Window", Width = 1.2 + i, Length = 1.5 + i, Rasch = 0.1, Layers = 2 + i };
        //    doors[i] = new Door { Name = "Door", Width = 0.9 + i, Length = 2.0 + i, Rasch = 0.15, Pattern = i % 2 == 0, Glass = i % 3 == 0 };
        //}
    }
}