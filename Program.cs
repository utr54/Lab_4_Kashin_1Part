using Lab_4_Kashin_1Part;

Point point = new Point(0, 0);
Point secondPoint = new Point(5, 0);
Segment sideSegment = new Segment(point, secondPoint);
Square square = new Square(point, sideSegment);
Square square2 = new Square(point, sideSegment);

Figure figureRef = square;
Console.WriteLine($"\nВиклик через посилання Figure:");
figureRef.Rotate(10);
Console.WriteLine();
Console.WriteLine(figureRef.ToString());

Console.WriteLine();
Console.WriteLine(square.ToString());

Console.WriteLine();
Console.WriteLine(square.Equals(square2));

Console.WriteLine();
square.SetDimensions();
square.SetDimensions(7);
square.Stretch(1.5);
square.Stretch(-1.5);
square.Compress(0.8);
square.Compress(0);
square.Rotate(45);
square.ChangeColor();
square.ChangeColor("Червоний");  

Console.WriteLine();
Console.WriteLine(square.ToString());

Console.WriteLine();
Console.WriteLine(sideSegment.ToString());

Console.WriteLine();
Console.WriteLine(point.ToString());
Console.WriteLine(secondPoint.ToString());

Console.WriteLine();
Console.WriteLine(square.Equals(square2));

Console.ReadKey();