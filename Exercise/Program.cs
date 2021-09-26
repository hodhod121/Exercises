using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections;
using System.Xml.Linq;
using System.Reflection;

namespace FirstProject
{
    class Program
    {
 

        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine(" 0) Exit");
            Console.WriteLine(" 1) Variables");
            Console.WriteLine(" 2) Date time");
            Console.WriteLine(" 3) Firstname and lastname");
            Console.WriteLine(" 4) Using string manipulationmethods");
            Console.WriteLine(" 5) String manipulation");
            Console.WriteLine(" 6) Calculation");
            Console.WriteLine(" 7) Area & volume");
            Console.WriteLine(" 8) Math Pow");
            Console.WriteLine(" 9) Restaurant order");
            Console.WriteLine("10) Choose between 3 different options");
            Console.WriteLine("11) Get going with iterations");
            Console.WriteLine("12) Multiplication ");
            Console.WriteLine("13) Gues the number");
            Console.WriteLine("14) Keep asking the user to enter numbers, until he enters -1");
            Console.WriteLine("18) Integer arrays");
            Console.WriteLine("19) Calculate the change that the customer should get back");
            Console.WriteLine("21) Min, max and average values");
            Console.WriteLine("25) Division of two numbers");
            Console.WriteLine("26)  Print out the folder path");
            Console.WriteLine("27) Reading a file");
            Console.WriteLine("28) Writing to a file");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "0":
                    return false;
                case "1":
                    RunExerciseOne();
                    return true;
                case "2":
                    RunExerciseTwo();
                    return true;
                case "3":
                    RunExerciseThree();
                    return true;
                case "4":
                    RunExerciseFour();
                    return true;
                case "5":
                    RunExerciseFive();
                    return true;
                case "6":
                    RunExerciseSix();
                    return true;
                case "7":
                    RunExerciseSeven();
                    return true;
                case "8":
                    RunExerciseEight();
                    return true;
                case "9":
                    RunExerciseNine();
                    return true;
                case "10":
                    RunExerciseTen();
                    return true;
                case "11":
                    RunExerciseEleven();
                    return true;
                case "12":
                    RunExerciseTwelve();
                    return true;
                case "13":
                    RunExerciseThirteen();
                    return true;
                case "14":
                    RunExerciseFourteen();
                    return true;
                case "18":
                    RunExerciseEighteen();
                    return true;
                case "19":
                    RunExerciseNineteen();
                    return true;
                case "21":
                    RunExerciseTwentyOne();
                    return true;
                case "25":
                    RunExerciseTwentyFive();
                    return true;
                case "26":
                    RunExerciseTwentySix();
                    return true;
                case "27":
                    RunExerciseTwentySeven();
                    return true;
                case "28":
                    RunExerciseTwentyEight();
                    return true;

                default:
                    return true;
            }
        }


      
        private static string RunExerciseOne()
        {
            Console.Clear();
            Console.WriteLine("Enter your firstname");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enteryour lastname");
            string lastname= Console.ReadLine();
           
            Console.WriteLine($"Hello {firstname} {lastname} !I’m glad to inform you that you are the test subject of my very first assignment!");

            Console.Write("\r\nPress Enter to return to Main Menu");

            return Console.ReadLine();
        }
        private static string RunExerciseTwo()
        {
            Console.Clear();
            var todaysDate=DateTime.Now;
            DateTime tomorrow = DateTime.Today.AddDays(1);
            DateTime yesterday = DateTime.Today.AddDays(-1);
            Console.WriteLine($"Todaysdate is {todaysDate}");
            Console.WriteLine($"Tomorrow's date is {tomorrow}");
            Console.WriteLine($"Yesterday's date is {yesterday}");

            Console.Write("\r\nPress Enter to return to Main Menu");

            return Console.ReadLine();
        }
        private static string RunExerciseThree()
        {
            Console.Clear();
            Console.WriteLine("Enter your firstname");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enteryour lastname");
            string lastname = Console.ReadLine();

            Console.WriteLine($"{firstname} {lastname}");

            Console.Write("\r\nPress Enter to return to Main Menu");

            return Console.ReadLine();
        }
        private static string RunExerciseFour()
        {
            Console.Clear();
            String str = "The quick fox Jumped Over the DOG";
            str=str.Replace("quick", "brown").Replace("Jumped Over", "Jumped Over".ToLower());
            str=str.Substring(0, str.Length - 3);
            str=str.Insert(str.Length-1," lazy dog");
            //str = "The brown fox jumped over the lazy dog";
            Console.WriteLine(str);
            
            Console.Write("\r\nPress Enter to return to Main Menu");

            return Console.ReadLine();
        }
        private static string RunExerciseFive()
        {
            Console.Clear();
            String str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            string result;
            string[] newStr = str.Split(":");
            string tempStr=newStr[1].Trim();
            string[] secondTemp=tempStr.Split(",");
            string textTemp = "";
            foreach(string str2 in secondTemp)
            {
                textTemp += str2.ToString();
            }
            StringBuilder sb = new StringBuilder(textTemp);
            StringBuilder sbTemp = new StringBuilder("6");
            sb.Remove(2, 2);
            for(int i = 7; i < 11; i++)
            {
                sbTemp.Append(","+i);
            }
            result = sb[0].ToString();
            for(int i = 1; i < sb.Length-1; i++)
            {
                result += sb[i] + ",";
            }
            result += sbTemp.ToString() +sb[sb.Length-1];
            Console.WriteLine(result);
            Console.Write("\r\nPress Enter to return to Main Menu");

            return Console.ReadLine();
        }
        private static string RunExerciseSix()
        {
            bool validity = true;
            Console.Clear();
            Console.WriteLine("Enter your firstnumber");         
            int input_1;          
            while (!int.TryParse(Console.ReadLine(), out input_1))
                {
                    Console.WriteLine("You need to enter valid integer number!");                                                   
                }
                Console.WriteLine("Enteryour secondnumber");             
                int input_2;
                while (!int.TryParse(Console.ReadLine(), out input_2))
                {
                    Console.WriteLine("You need to enter valid integer number!");                                       
                }

            int max = Math.Max(input_1, input_2);
            int min = Math.Min(input_1, input_2);
            Console.WriteLine($"{max} is the biggest number");
            Console.WriteLine($"{min} is the smallest number");
            Console.WriteLine($"Difference between the numbers is {max -min}");
            Console.WriteLine($"{max+min} is the sum of the two numbers");
            Console.WriteLine($"{max*min} is the product of two numbers");
            Console.WriteLine($"{(double)min/max} or {min}/{max} is the ratio of two numbers");


            Console.Write("\r\nPress Enter to return to Main Menu");

            return Console.ReadLine();
        }
        private static string RunExerciseSeven()
        {
            Console.Clear();
            Console.WriteLine("Enter the radios of a circle");
            double input_1;
            while (!double.TryParse(Console.ReadLine(), out input_1))
            {
                Console.WriteLine("You need to enter valid number!");
            }

            double area = Math.PI*Math.Pow(input_1,2);
            double volume=4/3*Math.PI*Math.Pow(input_1,3);
            Console.WriteLine($"{area} is the area");
            Console.WriteLine($"{volume} is the volume");
            Console.Write("\r\nPress Enter to return to Main Menu");

            return Console.ReadLine();
        }
        private static string RunExerciseEight()
        {
            Console.Clear();
            Console.WriteLine("Enter a number");
            decimal Input;
            while (!decimal.TryParse(Console.ReadLine(), out Input))
            {
                Console.WriteLine("You need to enter valid number!");
            }
            Console.WriteLine($"{Math.Sqrt((double)Input)} is the root of the number");          
            Console.WriteLine($"{Math.Pow((double)Input,2)} is the rised to 2 the number");          
            Console.WriteLine($"{Math.Pow((double)Input,10)} is the rised to 10 the number");

            return Console.ReadLine();
        }
        private static string RunExerciseNine()
        {
            Console.Clear();

            Console.WriteLine("What is your name");
            string username = Console.ReadLine();
            Console.WriteLine($"Hi {username} what is your birth year");

            int input_1;
            while (!int.TryParse(Console.ReadLine(), out input_1))
            {
                Console.WriteLine("You need to enter valid number!");
            }
            int year = DateTime.Now.Year;
            int age = year - input_1;
            string firstAnswer="";
            string secondAnswer = "";
            string thirdAnswer = "";
            if (age >= 18)
            {
                Console.WriteLine("Enter yes if you want order a beer and enter no if you don't want");
                firstAnswer = Console.ReadLine();


                if (!string.IsNullOrEmpty(firstAnswer) && (firstAnswer.ToLower() == "yes" || firstAnswer.ToLower() == "y"))
                {
                    Console.WriteLine("The order has been done!");
                }
                else
                {
                    Console.WriteLine("Enter yes if you want order a coke and enter no if you don't want");
                    secondAnswer = Console.ReadLine();
                    if (!string.IsNullOrEmpty(secondAnswer) && (secondAnswer.ToLower() == "yes" || secondAnswer.ToLower() == "y"))
                    {
                        Console.WriteLine("The coke has been served!");
                    }
                    else
                    {
                        Console.WriteLine("No order options are available");
                    }

                }
            }
            else
            {
                Console.WriteLine("Enter yes if you want order a coke and enter no if you don't want");
                thirdAnswer = Console.ReadLine();
                if (!string.IsNullOrEmpty(thirdAnswer) && (thirdAnswer.ToLower() == "yes" || thirdAnswer.ToLower() == "y"))
                {
                    Console.WriteLine("The coke has been served!");
                }
                else
                {
                    Console.WriteLine("No order options are available");
                }
            }
            
            Console.Write("\r\nPress Enter to return to Main Menu");

            return Console.ReadLine();
        }
        private static string ToggleColor()
        {
            Console.Clear();

            if (Console.ForegroundColor == ConsoleColor.Red)
            {
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }          


            Console.Write("\r\nPress Enter to return to Main Menu");
            return Console.ReadLine();
        }
        private static string RunExerciseTen()
        {
            Console.Clear();
            Console.WriteLine("Enter your choises 1 or 2 or 3");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    string output="";
                    Console.WriteLine("Enter your firstnumber");
                    double input_1;
                    while (!double.TryParse(Console.ReadLine(), out input_1))
                    {
                        Console.WriteLine("You need to enter valid integer number!");
                    }
                    Console.WriteLine("Enteryour secondnumber");
                    double input_2;
                    while (!double.TryParse(Console.ReadLine(), out input_2))
                    {
                        Console.WriteLine("You need to enter valid integer number!");
                    }
                    if (input_2 == 0)
                    {
                        output="It is impossible to get the answer, because your second number is 0";
                        Console.WriteLine(output);
                    }
                    else
                    {
                        output=$"{(input_1/input_2)}";
                        Console.WriteLine(output);
                    }
                    Console.Write("\r\nPress Enter to return to Main Menu");
                    Console.ReadLine();
                    return output;                   
                case "2":
                    
                    return RunExerciseFour();
                case "3":
                    
                    return ToggleColor();
                default:
                    Console.WriteLine("No choise has been made");
                    break;
                    //return "No choise has been made";
            }
           
            Console.Write("\r\nPress Enter to return to Main Menu");

            return Console.ReadLine();
        }
        private static string RunExerciseEleven()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter an integer number greater than zero ");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("You need to enter valid integer number!");
            }
            if (input <= 0)
            {
                Console.WriteLine("Your number is not greater than zero");
            }
            else
            {
                for (int i = 0; i <= input; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine(i);
                }
                Console.WriteLine("-----------------------------");
                for (int j = input; j >= 0; j--)
                {
                    if (j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine(j);
                }
                Console.ResetColor();

            }
            Console.Write("\r\nPress Enter to return to Main Menu");

            return Console.ReadLine();
        }
        private static string RunExerciseTwelve()
        {
            Console.Clear();
            Console.WriteLine();
            for (int x = 1; x <= 10; x++)
            {
                Console.Write("\t \t");
                for (int y = 1; y <= 10; y++)
                {

                    Console.Write($"{x * y} \t");
                }
                Console.WriteLine("\n \n");
            }
            Console.Write("\r\nPress Enter to return to Main Menu");
            return Console.ReadLine();
        }
        private static string RunExerciseThirteen()
        {
            Console.Clear();
            Random random = new Random();
            bool PlayAgain = true;
            int min = 1;
            int max = 500;
            int guess, number, guesses;
            string response;
            while (PlayAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, 1 + max);
                while (guess != number)
                {
                    Console.WriteLine($"Guess a number between {min} and {max} : ");
                    while (!int.TryParse(Console.ReadLine(), out guess))
                    {
                        Console.WriteLine("Enter a valid number!");
                    }


                    Console.WriteLine($"Guess: {guess}");
                    if (guess > number)
                    {
                        Console.WriteLine($"{guess} is too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine($"{guess} is too low");
                    }
                    guesses++;

                }
                Console.WriteLine($"Number is: {number}");
                Console.WriteLine("You won!");
                Console.WriteLine($"You found it after {guesses} guesses.");
                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();
                if (response == "Y" || response == "YES")
                {
                    PlayAgain = true;
                }
                else
                {
                    PlayAgain = false;
                    break;
                }

            }
            Console.Write("\r\nPress Enter to return to Main Menu");
            return Console.ReadLine();
        }
        private static string RunExerciseFourteen()
        {
            Console.Clear();          
            Console.WriteLine("Enter an integer number greater than zero ");
            int count = 0;
            double input_1=0;
            double imput_2=0;
            while (input_1 != -1) { 
                while (!double.TryParse(Console.ReadLine(), out input_1))
                {
                    Console.WriteLine("You need to enter valid integer number!");
                }
                if (input_1 != -1)
                {
                    imput_2 += input_1;
                    count++;
                }                
            }
            double avrage=imput_2/count;
            Console.WriteLine($"Sum of the numbers is {imput_2}");
            Console.WriteLine($"Average of the numbers is {avrage}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            return Console.ReadLine();
        }
        private static string RunExerciseEighteen()
        {
            Console.Clear();          
            Random rnd = new Random();
            double[] arr_1 = new double[10];
            for (int runs = 0; runs < 10; runs++)
            {
                arr_1[runs] = rnd.Next(1,100);
            }
            string[] arr_2 = new string[10];
            for (int runs = 0; runs < 10; runs++)
            {
                arr_2[runs] = $"1/{arr_1[runs]}";
            }
            foreach(double run in arr_1)
            {
                Console.WriteLine(run);
            }
            foreach(string run in arr_2)
            {
                Console.WriteLine(run);
            }
            Console.Write("\r\nPress Enter to return to Main Menu");

            return Console.ReadLine();
        }
        private static string RunExerciseNineteen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            int OneThousand, Fivehundred, Twohundred, Onehundred, Fifty, Twenty, Ten, Five, Two, One;
            Random rnd = new Random();
            int moneyToPay=rnd.Next(200,2000);
            Console.WriteLine($"You need to pay {moneyToPay} kr");
            Console.WriteLine("Enter the sum to pay");
            int input_1;
            int input_2 = 0;
            while (input_2 < moneyToPay)
            {
                while (!int.TryParse(Console.ReadLine(), out input_1))
                {
                    Console.WriteLine("You need to enter valid integer number!");
                }                
                    input_2 += input_1;
                if (input_2 < moneyToPay)
                {
                    Console.WriteLine("You need to pay more");
                    Console.WriteLine("Enter more money to pay");
                }
            }
            int CalculatedChange = input_2 - moneyToPay;
            Console.WriteLine($"Calculated change: {CalculatedChange}");

            OneThousand = CalculatedChange / 1000;
            Console.WriteLine($"1000 coins = {OneThousand}");
            int temp_1 = CalculatedChange - OneThousand * 1000;
            Fivehundred = (temp_1)/500;
            Console.WriteLine($"500 coins = {Fivehundred}");           

            int temp_3 = temp_1 - Fivehundred*500;
            Onehundred = (temp_3)/100;
            Console.WriteLine($"100 coins = {Onehundred}");

            int temp_4 = temp_3 - Onehundred * 100;
            Fifty = (temp_4)/50;
            Console.WriteLine($"50 coins = {Fifty}");

            int temp_5 = temp_4 - Fifty*50;
            Twenty= (temp_5)/20;
            Console.WriteLine($"20 coins = {Twenty}");

            int temp_6 = temp_5 - Twenty * 20;
            Ten= (temp_6)/10;
            Console.WriteLine($"10 coins = {Ten}");

            int temp_7 = temp_6 - Ten * 10;
            Five= (temp_7)/5;
            Console.WriteLine($"5 coins = {Five}");

            int temp_9 = temp_7 - Five * 5;           
            One = temp_9;
            Console.WriteLine($"1 coins = {One}");
           
            Console.ResetColor();
            Console.Write("\r\nPress Enter to return to Main Menu");
            return Console.ReadLine();
        }
        private static string RunExerciseTwentyOne()
        {
            Console.Clear();
            Console.WriteLine("Enter some numbers and enter comma between the numbers: ");
            int counts = 0;
            int Inputs;
            bool Validity = true;
            string TheNumber = Console.ReadLine();
            List<int> TempList = new List<int>();
            char last_char = TheNumber[TheNumber.Length - 1];
            while (last_char == '-' || last_char == '.' || last_char == ',' || last_char == ';')
            {
                Console.WriteLine("You don't have to write '-' or ',' or ';' after the last number");
                Validity = false;
                break;
            }
            var results = TheNumber.Split(',');
            foreach (var item in results)
            {
                while (!int.TryParse(item, out Inputs))
                {
                    if(counts == 0)
                    {
                        Console.WriteLine("You need to enter valid integer numbers and enter comma between them!");
                    }
                    counts++;
                    Validity = false;
                    break;
                }
            }

            results.Select(x => int.Parse(x.Trim()));

            if (Validity)
            {             
                int Addition = 0;
                foreach (var number in results)
                {
                    Addition += int.Parse(number);
                }
                for(int i = 0; i < results.Length; i++)
                {
                    TempList.Add(int.Parse(results[i])); 
                }
                Console.WriteLine($"Average of the numbers is {Addition / results.Count()}");
                Console.WriteLine($"The min number is {TempList.Min()}");
                Console.WriteLine($"The max number is {TempList.Max()}");
                Console.WriteLine();
            }
            Console.Write("\r\nPress Enter to return to Main Menu");
            return Console.ReadLine();
        }
        private static int IntegerOutput()
        {      
            int output;
            string v = Console.ReadLine();
            bool TryAgain = true;
                while (!int.TryParse(v, out output))
                {
                Console.WriteLine("Enter a valid integer number");
                v= Console.ReadLine();
                }
                return output;           
        
        }
        private static string RunExerciseTwentyFive()
        {           
            Console.Clear();
            string TempString = "";
            List<int> list = new List<int>();
            for(int i = 0; i < 2; i++)
            {
                TempString = i == 0 ? "first" : "second";
                Console.WriteLine($"Enter your {TempString} integer number");
                list.Add(IntegerOutput());
            }
            Console.WriteLine();
            int result = 0;
            try
            {
                result=list[0]/list[1];
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Write("\r\nPress Enter to return to Main Menu");
            return Console.ReadLine();
        }
        private static string RunExerciseTwentySix()
        {
            Console.Clear();
           
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            string path_1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path_2 = @"\MyTest.txt";
            string path = path_1+path_2;

            try
            {
                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }

                // Open the stream and read it back.
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    sr.Close();                  
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.Write("\r\nPress Enter to return to Main Menu");
            return Console.ReadLine();
        }
        private static string RunExerciseTwentySeven()
        {
            Console.Clear();
            var path = @"C:\Users\hodho\source\repos\Exercise\Exercise\TextFile1.txt";

            var enumLines = File.ReadLines(path, Encoding.UTF8);

            foreach (var line in enumLines)
            {
                Console.WriteLine(line);
            }

            Console.Write("\r\nPress Enter to return to Main Menu");
            return Console.ReadLine();
        }
        private static string RunExerciseTwentyEight()
        {
            Console.Clear();
            string[] FirstName = new string[] { "Ali", "Benjamin", "Billy", "Gholi", "Ghanbar" };
            string[] LastName = new string[] { "Ezad", "Ezadkhaha", "Bardhyll", "Gholizadeh", "Ghanbarzadeh" };
            string path= @"C:\Users\hodho\source\repos\Exercise\Exercise\TextFile1.txt";
            using (StreamWriter outputFile = new StreamWriter(path))
            {           
                foreach (string line in FirstName)
                    outputFile.WriteLine(line);
            outputFile.Close();
            }
            using (StreamWriter outputFile = new StreamWriter(path,true))
            {
                foreach (string line in LastName)
                    outputFile.WriteLine(line);
                outputFile.Close();
            }
            Console.Write("\r\nPress Enter to return to Main Menu");
            return Console.ReadLine();
        }

    }
}
