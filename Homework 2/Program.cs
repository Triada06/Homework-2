



using Homework_2;

Console.WriteLine("Choose one of the actions which are given below: ");
Console.WriteLine("1. Square\r\n2. Rectangular\r\n0. Quit");

RepeatCase: int action = int.Parse(Console.ReadLine());

switch (action)
{
    case 1:
        Console.WriteLine("Enter the side of the square");
    Repeat: Square square = new Square(float.Parse(Console.ReadLine()));

        if (square.Side < 0)
        {
            Console.WriteLine("Enter the side correctly! ");
            goto Repeat;
        }

        var answer = square.CalcArea();


        Console.WriteLine("Area of your figure is: " + answer);
        break;

    case 2:

        Console.WriteLine("Enter the length and th width of the rectangle");

        RepeatLine:  Rectangular rectangle = new Rectangular(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));

        if(rectangle.Length < 0 || rectangle.Width <  0) 
        { 
            Console.WriteLine("Enter sides correctcly! ");
            goto RepeatLine;
        }

        var ans = rectangle.CalcArea();
        Console.WriteLine("Area of your figure is: " + ans);
        break;

    case 0:
        break;

    default:
        Console.WriteLine("Please select one of the available options");
        goto RepeatCase;
}


