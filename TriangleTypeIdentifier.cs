using System;

class TriangleTypeIdentifier{

static void Main(){

Console.Write("[*] Enter the length of the First Side =>: ");
int sideLength1 = int.Parse(Console.ReadLine());

Console.Write("[*] Enter the length of the Second Side =>: ");
int sideLength2 = int.Parse(Console.ReadLine());

Console.Write("[*] Enter the length of the Third Side =>: ");
int sideLength3 = int.Parse(Console.ReadLine());

if(sideLength1 == sideLength2 && sideLength2 == sideLength3){
     Console.WriteLine("The triangle is Equilateral.");
}
else if(sideLength1 == sideLength2 || sideLength2 == sideLength3 || sideLength3 == sideLength1){
    Console.WriteLine("The triangle is Isosceles.");
}
else {
    Console.WriteLine("The triangle is Scalene.");
}





}



}