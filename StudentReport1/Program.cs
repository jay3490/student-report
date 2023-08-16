namespace StudentData
{
    class Program
    {
        public static void Main(string[] args)
        {


          
            // Student Id & Name
            List<Students> student = new List<Students>();
            student.Add(new Students(1, "Ahir Rishi", 22, "Anjar"));
            student.Add(new Students(2, "Ahir Jay", 23, "Anjar"));
            student.Add(new Students(3, "Arab Sahil ", 21, "Gandhidham"));
            student.Add(new Students(4, "Somaiya Neel", 22, "Khedoi"));

            // Subject Id & Name
            List<Subjects> subjects = new List<Subjects>();
            subjects.Add(new Subjects(101, "Physics"));
            subjects.Add(new Subjects(102, "Chemistry"));
            subjects.Add(new Subjects(103, "Maths"));

            // Student Id, Subject Code & Marks
            List<Marks> marks = new List<Marks>();
            marks.Add(new Marks(1, 102, 100));
            marks.Add(new Marks(1, 103, 100));
            marks.Add(new Marks(1, 101, 99));

            marks.Add(new Marks(2, 101, 62));
            marks.Add(new Marks(2, 102, 52));
            marks.Add(new Marks(2, 103, 99));

            marks.Add(new Marks(3, 101, 67));
            marks.Add(new Marks(3, 102, 99));
            marks.Add(new Marks(3, 103, 23));

            marks.Add(new Marks(4, 101, 22));
            marks.Add(new Marks(4, 102, 10));
            marks.Add(new Marks(4, 103, 36));

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("------- All Students Report Data -------");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
                    
            // Looping Student List & Marks List
            List <ReportCard> obj = new List<ReportCard>(); 
            obj.Add(new ReportCard());  
            obj.Add(new ReportCard());  
            obj.Add(new ReportCard());  
            obj.Add(new ReportCard());  

            for (int ID = 1; ID <= student.Count; ++ID)
            {
                // Student Name Output
                foreach (var j in student)
                {
                    if (j.StudentId == ID)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("      Student Name is: " + j.StudentName);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    obj[ID - 1].Name = student[ID - 1].StudentName;
                    obj[ID - 1].Age = student[ID - 1].StudentAge;
                    obj[ID - 1].City = student[ID - 1].StudentCity;
                }
                 
                // Total Marks Calculation
                decimal Total = 0;
                foreach (var i in marks)
                    if (ID == i.StudentId)
                    {
                        obj[ID-1].Total = obj[ID-1].Total + i.SubjectMarks;
                    }
                Console.WriteLine("      Students Total Marks are: " + obj[ID -1].Total);

                // Percentage Calculation
                obj[ID-1].Percentage = obj[ID-1].Total / 3;
                Console.WriteLine("      Students Percentage is: {0}% ", obj[ID - 1].Percentage);

                // Grade Calculation
                if (obj[ID - 1].Percentage >= 90)
                    Console.WriteLine("      Grade is: A+ (Distinction)");
                else if (obj[ID - 1].Percentage >= 80)
                    Console.WriteLine("      Grade is: A");
                else if (obj[ID - 1].Percentage >= 70)
                    Console.WriteLine("      Grade is: B");
                else if (obj[ID - 1].Percentage >= 60)
                    Console.WriteLine("      Grade is: C");
                else if (obj[ID - 1].Percentage >= 40)
                    Console.WriteLine("      Grade is: D");
                else
                    Console.WriteLine("      Grade is: E (Fail)");

                Console.WriteLine(); Console.WriteLine("--------------------------------------------"); Console.WriteLine();
                Total = 0;
            }

            // Starting of Nested Switch
            int tempExit = 0;
            while (tempExit == 0)
            {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;            
            Console.WriteLine("* Press A to by Sort Marks or Percentage *");
            Console.WriteLine("* Press B to by Filter Student Details by City or Age *");
            Console.WriteLine("* Press C to Exit *");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Select your Choice: ");
            Console.ForegroundColor = ConsoleColor.White;
            string tempChoice = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------");

           
                switch (tempChoice.ToUpper())
                {
                    // Super Option
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine("* Press 1 to Sort by Total Marks");
                        Console.WriteLine("* Press 2 to Sort by Percentage");
                        Console.WriteLine("* Press 3 to Exit *");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Select your Choice: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        int choice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------");
                        switch (choice)
                        {
                            // Sub Option for marks
                            case 1:
                                // Sorting by Total marks
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine();
                                Console.WriteLine("---- Sorted by Total Marks ----"); Console.ForegroundColor = ConsoleColor.White;
                                for (int i = 0; i < obj.Count; ++i)
                                {
                                    ReportCard temp = new ReportCard();
                                    for (int j = 0; j < obj.Count - 1; ++j)
                                    {
                                        if (obj[j].Total < obj[j + 1].Total)
                                        {
                                            temp = obj[j];
                                            obj[j] = obj[j + 1];
                                            obj[j + 1] = temp;
                                        }
                                    }
                                }
                                foreach (var item in obj)
                                {
                                    Console.WriteLine($"Total: {item.Total}, Student Name: {item.Name}, City: {item.City}, Age: {item.Age}");
                                }
                                break;

                            case 2:
                                // Sorting by Percentage
                                Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("---- Sorted by Percentage ----"); Console.ForegroundColor = ConsoleColor.White;
                                for (int i = 0; i < obj.Count; ++i)
                                {
                                    ReportCard temp = new ReportCard();
                                    for (int j = 0; j < obj.Count - 1; ++j)
                                    {
                                        if (obj[j].Percentage < obj[j + 1].Percentage)
                                        {
                                            temp = obj[j];
                                            obj[j] = obj[j + 1];
                                            obj[j + 1] = temp;
                                        }
                                    }
                                }
                                foreach (var item in obj)
                                {
                                    Console.WriteLine($"Percentage: {item.Percentage}%, Student Name: {item.Name}, City: {item.City}, Age: {item.Age}");
                                }
                                break;

                            case 3:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nThank you for using.");
                                break;

                        }
                        break;

                    // Super Option
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine("* Press 1 for Filtering by City");
                        Console.WriteLine("* Press 2 for Filtering by Age");
                        Console.WriteLine("* Press 3 to Exit *");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Select your Choice: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        int choice2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch (choice2)
                        {
                            // Sub Option for Filtering
                            case 1:
                                // Filter by City
                                Console.WriteLine("-----------------------------------------------------");
                                Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Enter City Name you want to Filter: "); Console.ForegroundColor = ConsoleColor.White;
                                string tempCity = Console.ReadLine();
                                int checkCity = 0;
                                foreach (var item in student)
                                {
                                    if (item.StudentCity == tempCity)
                                    {
                                        Console.WriteLine($"City: {item.StudentCity}, Name: {item.StudentName}, Age: {item.StudentAge}");
                                        checkCity++;
                                    }
                                }
                                if (checkCity == 0)
                                {
                                    Console.WriteLine("No Record Found! Please Try Again");
                                }
                                break;

                            case 2:
                                // Filter by Age
                                Console.WriteLine("-----------------------------------------------------"); Console.WriteLine();
                                Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Enter Age of Student you want to Filter by: "); Console.ForegroundColor = ConsoleColor.White;
                                int tempAge = Convert.ToInt32(Console.ReadLine());
                                int checkAge = 0;
                                foreach (var item in student)
                                {
                                    if (item.StudentAge == tempAge)
                                    {
                                        Console.WriteLine($"Age: {item.StudentAge}, Name: {item.StudentName}, City: {item.StudentCity}");
                                        checkAge++;
                                    }
                                }
                                if (checkAge == 0)
                                {
                                    Console.WriteLine("No Record Found! Please Try Again");
                                }

                                break;

                            case 3:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nThank you for using.");
                                break;

                        }

                        break;

                    // Exit case
                    case "C":
                        tempExit = 1;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nThank you for using.");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Invalid Input, try again.");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }
    }
}

