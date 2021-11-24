// Hello World!
namespace Hello World
{
    class hello {
        static void Main(string[] args)
        {
            System.Console.WriteLine('Hello world')
        }
    }
}


string characterName = 'john';
int characterAge; // int is used if you're trying to declare a number
characterAge = 35; // You don't need to assign the variable similar to the word (string) value

Console.writeLine('there was a man named' + characterName)  
Console.writeLine('He is'+ characterAge + 'years old')  // this is called concatnating the string due to adding the variable inbetween a string.
Console.writeLine('but he does not like being' + characterAge )
Console.writeLine('#')// write line is the product used to write a message on C#

Console.ReadLine();


static void Main(string[] args)
{
    string phrase = 'Giraffe Academy';
    char grade = 'B'; // with a character you can only put one(1) charcater e.g 'A' or 'U'
    int age = 30; //numebr dont need quotation marks 
    //float, double, decimal// if you need to be accurate you should use 'decimal' but use double if you want some accuracy.
    double gpa = 3.3;
    bool isMale = false // boolean can only have two values
    console.Readline();



}

namespace Giraffe 
{
    class Program 
    {
     static void Main (string[] args)
     {
         console.WriteLine('Giraffe Academy');

         console.Writeline('hello world');
     }
    }
}


// If statements

if (condition){
    //what happens when the condition is true
}



bool isMale = true;

if(isMale) 
{
    console.WriteLine('you are male') // this line of code can only be executed if the statement is true
} else
{
    console.WriteLine('you are not male') // this line gets executed only when the of statement is false
}


bool isTall = true;

if (isMale && is Tall)
{
    console.WriteLine('you are tall')
} else 
{
    console.WriteLine('you are not tall')
}



bool isMale = true 
bool isTall = true

if(isMale || isTall) // the double line represents 'or' function
{
    console.WriteLine('you are a tall male') 
} else
{
    console.WriteLine('you are not a tall male') 
}

if(isMale && isTall) // when you use '&&' both of the conditions have to be true 
{
    console.WriteLine('you are a tall male') 
} else
{
    console.WriteLine('you are not a tall male') 
}