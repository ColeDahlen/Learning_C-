// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string letters = "hi";
int number = 1;
bool boolean = false;
Console.WriteLine(letters);
Console.WriteLine(boolean);
if(number > 0){
    Console.WriteLine("Number is bigger than 0");
};
switch (number){
    case 1:
        Console.WriteLine("Int is 1");
        break;
    case 2: 
        Console.WriteLine("Int is 2");
        break;
};
string[] crayons ={"Blue", "Green", "Red"};
string[] whatCrayonsDoIHave ={"Purple", "Red", "Blue"};
foreach(string i in crayons){
    Console.WriteLine(i);
};
for(int i = 0; i < crayons.Length; i++){
    Console.WriteLine(crayons[i]);
};
var myList = new List<string>(){
    "Item1",
    "Item2",
    "Item3"
};
foreach(string i in myList){
    Console.WriteLine(i);
}


Console.WriteLine(crayons[0]);
Console.WriteLine(whatCrayonsDoIHave[0]);
