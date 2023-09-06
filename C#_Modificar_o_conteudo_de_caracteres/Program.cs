/*string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

string messageSpan = "What is the value <span>between the tags </span>?";

int openingPositionSpan = messageSpan.IndexOf("<span>");
int closingPositionSpan = messageSpan.IndexOf("</span>");

openingPositionSpan += 6;

int lengthSpan = closingPositionSpan - openingPositionSpan;
Console.WriteLine(messageSpan.Substring(openingPositionSpan, lengthSpan));

// Melhorando o codigo  

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPositionSpan1 = messageSpan.IndexOf(openSpan);
int closingPositionSpan1 = messageSpan.IndexOf(closeSpan);

openingPositionSpan1 += openSpan.Length;
int lengthSpan1 = closingPositionSpan1 - openingPositionSpan1;

Console.WriteLine(messageSpan.Substring(openingPositionSpan1, lengthSpan1));

string myString = "C# Time";
int posicaoMyString = myString.IndexOf('C');
Console.WriteLine(posicaoMyString);

string message1 = "(What if) I am (only interested) in the last (set of parentheses)?";
/*int openingPosition1 = message1.LastIndexOf('(');

openingPosition1 += 1;
int closingPosition1 = message1.LastIndexOf(')');
int length1 = closingPosition1 - openingPosition1;
Console.WriteLine(message1.Substring(openingPosition1, length1));
*/
string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}
/*

string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);


Console.WriteLine(updatedData);

string messageReplace = "This--is--ex-amp-le--da-ta";
messageReplace = messageReplace.Replace("--", " ");
messageReplace = messageReplace.Replace("-", "");
Console.WriteLine(messageReplace);

messageReplace = "Big Dog";

messageReplace = messageReplace.Replace("B", "D");

Console.WriteLine(messageReplace);

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

int quantityStart = input.IndexOf("<span>");
int quantityEnd = input.IndexOf("</span>");
quantityStart += "<span>".Length;
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

output = input.Replace("&trade;", "&reg");

int divStart = input.IndexOf("<div>");
int divLength ="<div>".Length;
output = output.Remove(divStart, divLength);

int divCloseStart = input.IndexOf("</div>");
int divCloseLength ="</div>".Length;
output = output.Remove(divStart, divLength);
output = $"Output: {output}";

// Your work here
Console.WriteLine(input);
Console.WriteLine(quantity);
Console.WriteLine(output);

string a = "asdasd";
Console.WriteLine(a.Length);
a = $"mostrar o teste de caso {a} ";
Console.WriteLine(a);
Console.WriteLine(a.Length);
a += a;

Console.WriteLine(a);
*/