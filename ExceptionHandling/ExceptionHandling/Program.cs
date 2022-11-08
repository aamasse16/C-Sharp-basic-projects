using System;

    class Program
    {
        static void Main(string[] args)
        {

        try
        {
            Console.WriteLine("Pick a number.");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number.");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two.....");
            int numThree = numOne / numTwo;
            Console.WriteLine(numOne + " divided by " + numTwo + " equals " + numThree);
            Console.Read();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number.");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Plese dont divide by 0.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.Read();
        }
        Console.Read();
        }
    }
