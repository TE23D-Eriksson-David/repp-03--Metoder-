using SC = System.Console;
using S = System;


SC.ReadLine();

Hello32();

SC.ReadLine();

Fraktion(3);

SC.ReadLine();

float returnerat_värde = Multi(1.5f, 1.3f);

SC.ReadLine();

double returnerat_värde2 = RightTriangleArea(1.5, 2.5);

SC.ReadLine();

CirkleArea(2.5f);

SC.ReadLine();

int returnerat_värde3 = GetNumberInput();

SC.ReadLine();

string Returningstr = "";
string Astring = "a";
string Bstring = "b";
string Cstring = "c";

string returnerat_värde4 = GetChoice(Astring, Bstring, Cstring);


SC.ReadLine();

string[] InputArray3 = ["A", "B", "C"];
string[] InputArray5 = ["D", "E", "F", "G", "H"];

int returnerat_värde5 = GetChoiceArray(InputArray3);



















int intiger;

void Hello32()
{
    for (int i = 0; i < 32; i++)
    {
        SC.WriteLine("Hello world!");
    }
}

void Fraktion(int intiger)
{
    S.Math.Sqrt(intiger);
    SC.WriteLine($"{intiger}");
}

float Multi(float floatMulti1, float floatMulti2)
{
    float Product = floatMulti1 * floatMulti2;
    SC.WriteLine($"{floatMulti1}*{floatMulti2}={Product}");
    return Product;
}

double RightTriangleArea(double a, double b)
{
    double Result = a * b / 2;
    SC.WriteLine($"{a}*{b}/2 ={Result}");
    return Result;
}

float CirkleArea(float r)
{
    float Result = r * r * float.Pi;
    SC.WriteLine($"{r}*{r}*{float.Pi} ={Result}");
    return Result;
}

int Value;

int GetNumberInput()
{
    while (true)
    {
        string strInput = SC.ReadLine().ToLower();
        bool lyckad = int.TryParse(strInput, out Value);
        if (lyckad)
        {
            break;
        }
        SC.WriteLine("Try Again, The expresion only accepts numbers");
    }
    return Value;
}


int choiceint;

string GetChoice(string Astring, string Bstring, string Cstring)
{
    while (true)
    {
        SC.WriteLine($@"coresponding number choice
    {Astring}   1
    {Bstring}   2
    {Cstring}   3");

        string choice = SC.ReadLine();
        int.TryParse(choice, out choiceint);
        if (choiceint == 1 || choiceint == 2 || choiceint == 3)
        {
            break;
        }
        else
        {
            SC.WriteLine("Try writning 1, 2 or 3");
        }

    }
    switch ((int)(choiceint))
    {
        case (int)(1):
            Returningstr = Astring;
            break;
        case (int)(2):
            Returningstr = Bstring;
            break;
        case (int)(3):
            Returningstr = Cstring;
            break;
    }

    return Returningstr;
}




int GetChoiceArray(string[] inputstring)
{
    int ChoiceNumber;

    for (int i = 0; i < inputstring.Length; i++)
    {
        SC.WriteLine(@$"  {i},   {inputstring[i]}  ");
    }

    while (true)
    {
        SC.WriteLine("Chose one of the strings, the first one is 1 and so on");
        string Choice = SC.ReadLine();
        bool lyckad = int.TryParse(Choice, out ChoiceNumber);
        if (lyckad)
        {
            break;
        }
        else
        {
            SC.WriteLine("Try, only using numbers");
        }
    }

    return ChoiceNumber;

}



SC.ReadLine();