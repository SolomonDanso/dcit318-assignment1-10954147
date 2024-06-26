using System;

class TicketPriceCalculator{

static void Main(){

int originalPrice = 10;
int discountedPrice = 7;
Console.Write("[*] Enter Your Age Here =>: ");

int age = int.Parse(Console.ReadLine());

if (age>=65 || age<=12){
    Console.WriteLine("Your ticket price is GHC "+discountedPrice);
}
else{
    Console.WriteLine("Your ticket price is GHC "+originalPrice);
}




}


}