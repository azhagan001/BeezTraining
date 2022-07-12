using System;
class Per
{
    public static void Main(string[] args)
    {
        int loop = 0;
        string Description;
        char Grade;
        do
        {

            Console.WriteLine(" E : Excellent");
            Console.WriteLine(" V : Very Good");
            Console.WriteLine(" G : Good");
            Console.WriteLine(" A : Average");
            Console.WriteLine(" F : Fail");
            Console.WriteLine("Grade ?");
            Grade = Convert.ToChar(Console.ReadLine());
            switch (Grade)
            {
                case 'E':
                    Description = " Excellent";
                    break;
                case 'V':
                    Description = " Very Good";
                    break;
                case 'G':
                    Description = " Good ";
                    break;
                case 'A':
                    Description = " Average";
                    break;
                case 'F':
                    Description = " Fail";
                    break;
                default:
                    Description = "Nothing";
                    break;
            }
            Console.WriteLine("The Grade Is =" + Description);
            Console.WriteLine("Do you want to continue press 1");
            loop = Convert.ToInt32(Console.ReadLine());

        } while (loop == 1);
    }
        
    }

