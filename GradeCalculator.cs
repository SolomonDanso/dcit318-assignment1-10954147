using System;

class GradeCalculator{

static void Main(){

Console.Write("Enter a numerical grade value between 0 and 100 =>: ");
int studentGrade = int.Parse(Console.ReadLine());

if(studentGrade>=90){
    Console.WriteLine("A");
}
else if (studentGrade>=80 && studentGrade<=89){
    Console.WriteLine("B");
}
else if (studentGrade>=70 && studentGrade<=79){
    Console.WriteLine("C");
}
else if (studentGrade>=60 && studentGrade<=69){
    Console.WriteLine("D");
}
else{
    Console.WriteLine("F");
}

 


}








}


