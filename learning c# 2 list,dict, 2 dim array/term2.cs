// Basic code
static void Main(string[] args)
{
    Program myprogram = new Program();
    myprogram.start();
}

void start()
{


}

static Random rnd = new Random(); // if used outside of method Random rnd = new Random();
value = rnd.Next(1, 10); // is dus 1 tot 10 niet tot en met 10

classs blabla = new classs();

// for string builder
using System.Text;
StringBuilder s = new StringBuilder(guessedWord);
s.Remove(i, 1);
s.Insert(i, Char);

//enums and structs
public struct blabla
{
    public string blabla;
    public int 99;

}

public enum GenderType
{
    Male, female
}

// 2 dim arrays
const int nrOfRows = 5;
const int nrOfColumns = 5;

int[,] matrix = new int[nrOfRows, nrOfColumns];

int number = 1; // or use random

// init/ fill array.
void InitMatrix2D(int[,] matrix)
{
    int number = 1;// or use random
    for (int Rows = 0; Rows < matrix.GetLength(0); Rows++)
    {
        for (int Columns = 0; Columns < matrix.GetLength(1); Columns++)
        {
            matrix[Rows, Columns] = number;// or use Rnd.Next(1, 100);
            number++;
        }
    }
}

// display array
void DisplayMatrix(int[,] matrix)
{
    for (int Rows = 0; Rows < matrix.GetLength(0); Rows++)
    {
        for (int Columns = 0; Columns < matrix.GetLength(1); Columns++)
        {
            Console.Write("{0, 3}", matrix[Rows, Columns]);// use "{0:00} " for 04,06 ect.
        }
        Console.WriteLine();
    }
}

//lists and dictionaries
using System.Collections.Generic; // important

List<string> words = ListOfWords(); // dit of List<string> words = new List<string>();

List<string> ListOfWords()
{
    List<string> words = new List<string>();
    words.Add("airplane");
    words.Add("kitchen");
    words.Add("building");
    return words;
}
string selectWord = words[rnd.Next(0, 20)]; // pick random out of list

Dictionary<string, string> Dict = new Dictionary<string, string>();
Dict.Add(LineValue[0], LineValue[1]);//Dict.Add(word1, word2);

//file io stream reader and writher
using System.IO; // important

StreamWriter writer = new StreamWriter(FileName);
writer.WriteLine(name);
writer.Close();// !!!!!!!!!!!!!!!

if (File.Exists(FileName))
{
    Console.WriteLine();/ ofzo
}

StreamReader reader = new StreamReader(filename);
while (!reader.EndOfStream)
{
    string word = reader.ReadLine();
    words.Add(reader.ReadLine());
}
reader.Close();//!!!!!!!!

//error handeling
try
{
    // just do ur stuff here and catch it if it does not work. can be use in a loop(while) to keep trying}
}

catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(e.Message); Console.ResetColor();
    Console.WriteLine();
}

finally
{
    // stuf that needs to happen even if it fails happens after the try or catch. coeld be use in a loop to ask for new var,word,int ect prevents dupliate code.
}
    //basic tools
    public static int ReadInt(string vraag)
{
    Console.Write(vraag);
    int Value = int.Parse(Console.ReadLine());
    return Value;
}

public static int ReadInt(string question, int min, int max)
{
    Console.Write(question);
    int Age = int.Parse(Console.ReadLine());

    while (Age <= min || Age >= max)
    {
        Console.Write(question);
        Age = int.Parse(Console.ReadLine());
    }
    return Age;
}

public static string ReadString(string vraag)
{
    Console.Write(vraag);
    string String = Console.ReadLine();
    return String;
}