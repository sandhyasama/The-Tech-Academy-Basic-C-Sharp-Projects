//write college name to console
Console.WriteLine("Academy of Learning Career College\n");

//write student daily report name to console
Console.WriteLine("Student Daily Report\n");


//ask student for their name and store it in a string variable
Console.WriteLine("What is your name?\n");
string studentName = Console.ReadLine();

//ask student for their course name and store it in a string variable
Console.WriteLine("What course are you on?\n");
string courseName = Console.ReadLine();

//ask student for the page number they are on and store it in a byte variable
Console.WriteLine("What page number?\n");

//casting is needed since from readline returns a string and we need to convert it to a byte
byte onPageNumber = Convert.ToByte(Console.ReadLine());

//ask student if they need help and store it in a boolean variable
Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"\n");
//casting is needed since from readline returns a string and we need to convert it to a boolean
bool isStudentNeedingHelp = Convert.ToBoolean(Console.ReadLine());

//ask the student for any positive experiences they would like to share and store it in a string variable
Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.\n");
string positiveExperiences = Console.ReadLine();

//ask the student for any other feedback they would like to provide and store it in a string variable
Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.\n");
string otherFeedback = Console.ReadLine();

//ask the student how many hours they studied today and store it in a byte variable
Console.WriteLine("How many hours did you study today?\n");
byte hoursStudiedToday = Convert.ToByte(Console.ReadLine());

//finally, thank the student for their answers and let them know an instructor will respond to their feedback
Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");

