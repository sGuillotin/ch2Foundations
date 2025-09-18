using System.Formats.Asn1;

OperatorExamples();

void OperatorExamples()
{
    // This statement declares a variable and sets it to 3
    int width = 3;

    // The ++ operator increments a variable (add 1 to it)
    width++;

    // Declare two more int variables to hod numbers and
    // use the + and * operators to add and and multiply values
    int height = 2 + 4;
    int area = width * height;
    Console.WriteLine(area);


    while (area < 20)
    {
        height++;
        area = width * height;
    }
    do
    {
        width--;
        area = width * height;
    } while (area > 25);

    // The next two staatements declare string variables
    // and use the + operator to concatenate (join) them
    string result = "The area";
    result += " is " + area;
    Console.WriteLine(result);

    // A Boolean variable is either true or false
    bool truthValue = true;
    Console.WriteLine(truthValue);
}