string fullNameInput;
string firstName; string lastName;
string studentUsername;
string firstNameInitials; string lastNameInitials;
string fullNameSpacesTrimmed;

System.Console.WriteLine("What is your full name?");
fullNameInput = System.Console.ReadLine();
fullNameSpacesTrimmed = fullNameInput.Trim();

int indexOfFirstSpace = fullNameSpacesTrimmed.IndexOf(" ");
lastName = fullNameSpacesTrimmed.Substring(indexOfFirstSpace); lastName = lastName.Trim();
firstName = fullNameSpacesTrimmed.Substring(0, indexOfFirstSpace); firstName = firstName.Trim();

firstNameInitials = firstName.Substring(0,1);
lastNameInitials = lastName.Substring(0,1);

studentUsername = firstNameInitials + lastName;

System.Console.WriteLine($"Name on badge: {firstName.ToUpper()} {lastName.ToUpper()}");
System.Console.WriteLine($"Username: {studentUsername.ToLower()}");
System.Console.WriteLine($"Initials: {firstNameInitials.ToUpper()}.{lastNameInitials.ToUpper()}.");
System.Console.WriteLine($"Letters in last name: {lastName.Length}");

//randomly gen. the locker num and studentID
Random numberGeneration = new Random();

int studentLockerNumber;
int studentID;

studentLockerNumber = numberGeneration.Next(1, 501);
studentID = numberGeneration.Next(100000, 909999);
System.Console.WriteLine($"Student ID: {studentID}");
System.Console.WriteLine($"Locker: {studentLockerNumber}");