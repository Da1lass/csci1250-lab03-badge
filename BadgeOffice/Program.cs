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



//the Walk.
int dormXPosition; int dormYPosition;
int classroomXPosition; int classroomYPosition;
int studentWalkSpeed;
decimal distance;
int minutesForWalk; int secondsForWalk;

// a whole lotta printing shall be done
System.Console.Write("Dorm X position: ");
dormXPosition = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Dorm Y position: ");
dormYPosition = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Classroom X position: ");
classroomXPosition = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Classroom Y position: ");
classroomYPosition = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Student walking speed: ");
studentWalkSpeed = Convert.ToInt32(System.Console.ReadLine());

distance = (decimal)Math.Sqrt(Math.Pow(dormXPosition - classroomXPosition, 2) + Math.Pow(dormYPosition - classroomYPosition, 2));

minutesForWalk = (int)distance / studentWalkSpeed;
secondsForWalk = (int)distance % studentWalkSpeed;

System.Console.WriteLine($"Distance {distance.ToString("F1")} feet");
System.Console.WriteLine($"Walk time: {minutesForWalk} minutes {secondsForWalk} seconds");

//badge creation !

string studentIDDidgitCheck = studentID + "-" + Convert.ToString(studentID % 9);
string studentLockerNumberStringed = Convert.ToString(studentLockerNumber);

string badgeBars = "==================================";
string badgeTitle = "ETSU STUDENT BADGE";
string badgeWalkTime = $"{minutesForWalk} mins + {secondsForWalk} sec";
string fullNameSpacesTrimmedUppercase = fullNameSpacesTrimmed.ToUpper();

System.Console.WriteLine(badgeBars);
System.Console.WriteLine(badgeTitle.PadLeft(27));
System.Console.WriteLine(badgeBars);
System.Console.WriteLine($"NAME {fullNameSpacesTrimmedUppercase.PadLeft(fullNameSpacesTrimmedUppercase.Length + 5)}"); //use the var.length to get the length of the var, and then the +X tells how many more characters are needed to allign it properly
System.Console.WriteLine($"USERNAME {studentUsername.PadLeft(studentUsername.Length + 1)}");
System.Console.WriteLine($"ID {studentIDDidgitCheck.PadLeft(studentIDDidgitCheck.Length + 7)}");
System.Console.WriteLine($"LOCKER {studentLockerNumberStringed.PadLeft(studentLockerNumberStringed.Length + 3)}");
System.Console.WriteLine($"WALK {badgeWalkTime.PadLeft(badgeWalkTime.Length + 5)}");
System.Console.WriteLine(badgeBars);