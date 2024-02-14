// sintaksis(){
// 
// }
// int a = 4;
// int b = 4;
// int c = 5;
// if (a >= b || c < a)
// {
//     Console.WriteLine("Duzdu");
// }else{
//     Console.WriteLine("Sehfdi");
// }
// Visual Studio => Ctrl + K + C => Ctrl + K + U
// Console.WriteLine("Balinizi daxil edin.");
// int studentPoint = Convert.ToInt32(Console.ReadLine());

// if (studentPoint > 51 && studentPoint <= 60)
// {
//     Console.WriteLine("E");
// }else if (studentPoint > 61 && studentPoint <= 70)
// {
//     Console.WriteLine("D");
// }else if (studentPoint > 71 && studentPoint <= 80)
// {
//     Console.WriteLine("C");
// }else if (studentPoint > 81 && studentPoint <= 90)
// {
//     Console.WriteLine("B");
// }else if (studentPoint > 91 && studentPoint <= 100)
// {
//     Console.WriteLine("A");
// }else{
//     Console.WriteLine("Kesildiniz.");
// }



// string email =  "test@compar.edu.az";
// string password = "123456";

// Console.WriteLine("Email daxil edin.");
// string userEmail = Console.ReadLine();
// Console.WriteLine("Sifre daxil edin.");
// string userPassword  = Console.ReadLine();

// if(userEmail == email && userPassword == password){
//     Console.WriteLine("Xos geldiniz " + email);
// }else{
//     Console.WriteLine("Email ve ya sifre sehfdi");
// }

// 000000 - 999999


// string? userInput = Console.ReadLine();


// true !true => false || false !false => true

// if (!string.IsNullOrWhiteSpace(userInput))
// {
//     Console.WriteLine("Correct.");
// }else{
//     Console.WriteLine("Text is empty.");
// }



// int a = 10;
// int b = 2;
// string c = "4";
// string firstName = "Huseyn";
// string lastName = "Memmedov";
// Console.WriteLine(a+b);
// Console.WriteLine(a-b);
// Console.WriteLine(a*b);
// Console.WriteLine(a/b);
// Console.WriteLine(a%b);
// template literals
// Console.WriteLine($"{firstName} {lastName}");


// Console.WriteLine("Dunyanin en hundur zirvesi hansidir? \n1. Test\n2. Bazaduzu\n3. Everest\n4. Elbrus");


// Console.ForegroundColor = ConsoleColor.DarkRed;
// Console.WriteLine(@"Lorem ipsum \");
// Console.WriteLine(@"Lorem ipsum \");
// Console.BackgroundColor = ConsoleColor.DarkYellow;
// Console.WriteLine(@"Lorem ipsum \");

// int input = 7;
// switch (input)
// {
//     case 1:
//         Console.WriteLine("Bazar ertesi");
//         break;
//     case 2:
//         Console.WriteLine("Cersenbe axsami");
//         break;
//     case 3:
//         Console.WriteLine("Cersenbe");
//         break;
//     case 4:
//         Console.WriteLine("Cume axsami");
//         break;
//     case 5:
//         Console.WriteLine("Cume ");
//         break;
//     case 6:
//         Console.WriteLine("Senbe");
//         break;
//     case 7:
//         Console.WriteLine("Bazar");
//         break;
//     default:
//         Console.WriteLine("Bele bir gun yoxdur.");
//         break;
// }

string number = "10";

int number2 = 3;

int result = Convert.ToInt32(number) + number2;
char letter = 'z';

string test = letter.ToString();
Console.WriteLine(test);