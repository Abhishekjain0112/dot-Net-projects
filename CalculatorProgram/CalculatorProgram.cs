using System;
class Calculator
{
    public int Addition(int a,int b)
    {
        return a+b;
    }
    public int Subtraction(int a,int b)
    {
        return a-b;
    }
    public int Multiplication(int a,int b)
    {
        return a*b;
    }
    public double Division(int a,int b,out double remainder)
    {
        remainder=a%b;
        return a/b;
    }
}
public class Program
{
    public static void Main()
    {
        Calculator cal=new Calculator();
        Console.WriteLine("Enter the operator");
        char oper=char.Parse(Console.ReadLine());
        Console.WriteLine("Enter the operands");
        int op1=int.Parse(Console.ReadLine());
        int op2=int.Parse(Console.ReadLine());
        switch(oper)
        {
            case'+': Console.WriteLine("Result of {0} + {1} is {2}",op1,op2,cal.Addition(op1,op2));
            break;
            
            case'-': Console.WriteLine("Result of {0} - {1} is {2}",op1,op2,cal.Subtraction(op1,op2));
            break;
            case'*': Console.WriteLine("Result of {0} * {1} is {2}",op1,op2,cal.Multiplication(op1,op2));
            break;
            case'/': Console.WriteLine("Result of {0} + {1} is {2} \nRemainder ={3}",op1,op2,cal.Division(op1,op2,out double remainder),remainder);
            break;
            default: Console.WriteLine("Invalid Operator");
            break;
        }
    }
}