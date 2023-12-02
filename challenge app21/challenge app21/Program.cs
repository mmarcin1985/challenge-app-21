int number = 15496224;

string numberInString = number.ToString();  // tworzy string z liczbt
char[] digitsInString = numberInString.ToArray();  // dzieli string na tablice znaków
int[] digitCount = new int[10];
int digitInNumber = 0; // zmienna użyta w pętli do indeksowania zliczanych cyf


foreach (var digit in digitsInString)    // zlicza wystąpienia każdej cyfry
{
    digitInNumber = int.Parse(digit.ToString());
    digitCount[digitInNumber] = digitCount[digitInNumber] + 1;
} 


for (var i = 0; i < 10; i++)
{
    Console.WriteLine(i + "Liczba wystąpień :" + digitCount[i]);
}

