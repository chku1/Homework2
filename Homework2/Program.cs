//1.
Console.WriteLine("Enter 10 numbers: ");
int[] arrayInt = new int[10];
//string[] arrayString = new string[10];

for (int i = 0; i < arrayInt.Length; i++)
{
    string n = Console.ReadLine();
    bool isNumber = int.TryParse(n, out arrayInt[i]);
    //arrayString[i] = Console.Readline();
}

for (int i = 0; i < arrayInt.Length; i++)
{
    Console.WriteLine(arrayInt[i]);
    //arrayString[i] = Console.Readline();
}

//2.
//Console.WriteLine("Enter how many numbers you want to print: ");
//string n = Console.ReadLine();
//bool isNumber = int.TryParse(n, out int num);

//int begin = 1;
//int counter = 1;

//if (isNumber)
//{
//    for (int i = 0; i < num; i++)
//    {
//        int x = begin;
//        for (; x < begin + counter; x++)
//        {
//            Console.Write(x);
//            if (x < begin + counter - 1) Console.Write(",");
//        }
//        Console.WriteLine();
//        counter++;
//        begin = x;
//    }
//}
//else
//{
//    Console.WriteLine($"{n} is not a number!");
//}

//3.
//Console.WriteLine("Enter a number: ");
//string n = Console.ReadLine();
//bool isNumber = int.TryParse(n, out int num);

//int oddSum = 0;
//int oddProduct = 1;


//if (isNumber)
//{
//    for(int i=1; i<num; i++)
//    {
//        if (i % 2 == 1)
//        {
//            oddSum += i;
//            oddProduct *= i;
//        }
//    }
//    Console.WriteLine($"sum of odd numbers between 1 and {num} is: {oddSum} and product of odd numbers in the same range is: {oddProduct}");
//}
//else
//{
//    Console.WriteLine($"{n} is not a number!");
//}

//4.
//Console.WriteLine("Enter a number: ");
//string n = Console.ReadLine();
//bool isNumber = int.TryParse(n, out int num);

//double squareSum = 0;

//if (isNumber)
//{
//    for (int i = 1; i <=num; i++)
//    {
//        squareSum = squareSum + Math.Pow(i,2);
//    }
//    Console.WriteLine($"sum of numbers to the power of two between 1 and {num} is: {squareSum}");
//}
//else
//{
//    Console.WriteLine($"{n} is not a number!");
//}

//5.
//Console.WriteLine("Enter a palindrome: ");
//string palindrome = Console.ReadLine();

//bool isPalindrome = true;

//if(palindrome != null)
//{
//    for (int i = 0; i < palindrome.Length; i++)
//    {
//        if (palindrome[i] != palindrome[palindrome.Length - i - 1]) 
//        { 
//            isPalindrome = false;
//            break;
//        }
//    }
//    if (isPalindrome)
//    {
//        Console.WriteLine($"{palindrome} is palindrome!");
//    }
//    else
//    {
//        Console.WriteLine($"{palindrome} is not a palindrome!");
//    }
//}
//else
//{
//    Console.WriteLine("You didn't enter a string!");
//}

//6.
//Console.WriteLine("Enter a number: ");
//string n = Console.ReadLine();
//bool isNumber = int.TryParse(n, out int num);

//int reversedNum = 0;
//int numUnchanged = num;

//if (isNumber)
//{
//    while (num > 0)
//    {
//        reversedNum = reversedNum * 10 + num % 10;
//        num = num / 10;
//    }
//    if(numUnchanged == reversedNum)
//    {
//        Console.WriteLine($"{numUnchanged} is a palindrome!");
//    }
//    else
//    {
//        Console.WriteLine($"{numUnchanged} is not a palindrome!");
//    }
//}
//else
//{
//    Console.WriteLine($"{n} is not a number!");
//}

//7.
//string[] arr = {"Mariam", "5", "hello", "5", "Mariam", "Nevermind" };
//Dictionary<string, int> map = new Dictionary<string, int>();

//for(int i = 0; i < arr.Length; i++)
//{
//    if(map.TryGetValue(arr[i], out int val))
//    {
//        map[arr[i]] = val+1;
//    }
//    else
//    {
//        map.Add(arr[i], 1); 
//    }  
//}

//foreach(var unique in map)
//{
//    Console.WriteLine("Variable in array = {0}, number of times in array = {1}", unique.Key, unique.Value);
//}

//8.
//int[] arr = { 1, 2, 15, 4, 20 };
//int min = int.MaxValue;
//int max = int.MinValue;
//int median;
//for (int i = 0; i < arr.Length; i++)
//{
//    if(arr[i] > max) max= arr[i];
//    if (arr[i] < min) min = arr[i];

//}
//if(arr.Length %2 == 0)
//{
//    median = (arr[arr.Length/2]+arr[arr.Length/2-1])/2;
//}
//else
//{
//    median = arr[arr.Length/2]; 
//}

//Console.WriteLine($"median of the arrray is: {median}, maximum number in the array is: {max} and minimum number in the array is: {min}");

//9.
//int[] arr = { 1, 2, 3, 4 };
//for(int i = arr.Length-1; i >=0; i--)
//{
//    Console.WriteLine(arr[i]);
//}

//10.
//int[] arr = { 1, 2, 3, 4,-5,6,-1 };
//int negativeNums = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] < 0) negativeNums++;
//}
//Console.WriteLine($"number of negative numbers in the array: {negativeNums}");

//11.
//int[] arr = { 1, 2, 3, 4, -5, 6, -1,05,4,10,2,3,4};
//Dictionary<int, int> map = new Dictionary<int, int>();

//for (int i = 0; i < arr.Length; i++)
//{
//    if (map.ContainsKey(arr[i])) continue;
//    map.Add(arr[i], 1);
//}

//Console.WriteLine("Unique values are: ");
//foreach (var unique in map)
//{
//    Console.Write($"{unique.Key} ");
//}

//12.
//int[] arr = { 1, 2, 3, 4, -5, 6, -1, 05, 4, 10, 2, 3, 4 };
//Dictionary<int, int> map = new Dictionary<int, int>();

//for (int i = 0; i < arr.Length; i++)
//{
//    if (map.TryGetValue(arr[i], out int val))
//    {
//        map[arr[i]] = val + 1;
//    }
//    else
//    {
//        map.Add(arr[i], 1);
//    }
//}

//Console.WriteLine("Only once in array: ");
//foreach (var unique in map)
//{
//    if(unique.Value == 1) Console.Write($"{unique.Key} ");
//}

//13.
//Console.WriteLine("Enter a text: ");
//string text = Console.ReadLine();

//int upperChar = 0;
//int lowerChar = 0;
//int punctuation = 0;

//string[] arrText = text.Split(' '); 

//for (int i = 0; i < text.Length; i++)
//{
//    if (char.IsUpper(text[i])) upperChar++;
//    if (char.IsLower(text[i])) lowerChar++;
//    if (char.IsPunctuation(text[i])) punctuation++;
//}

//Console.WriteLine($"there are {punctuation} punctuation, {upperChar} uppercase and {lowerChar} lowercase letters and {arrText.Length} words in {text}");

//14.
//Console.WriteLine("Enter a text: ");
//string text = Console.ReadLine();

//int vowels = 0;
//int consonants = 0;

//for (int i = 0; i < text.Length; i++)
//{
//    if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u')
//    {
//        vowels++;
//    }
//    else if(text[i] != ' ')
//    {
//        consonants++;
//    }
//}

//Console.WriteLine($"Number of vowels: {vowels} and Number of consonants: {consonants}");

//15.
//Console.WriteLine("Enter a text: ");
//string text = Console.ReadLine();
//Console.WriteLine("Enter a substring: ");
//string substr = Console.ReadLine();

//if (text.Contains(substr))
//{
//    Console.WriteLine($"{text} contains {substr}");
//}
//else
//{
//    Console.WriteLine($"{text} does not contain {substr}");
//}

//16.
//Console.WriteLine("Enter number of words you want to input: ");
//string n = Console.ReadLine();
//bool isNumber = int.TryParse(n, out int num);

//string[] arr = new string[100];

//if (isNumber)
//{
//    for(int i = 0; i <num; i++)
//    {
//        string s = Console.ReadLine();
//        if(s.Length > 10)
//        {
//            string str = s[0] + (s.Length-2).ToString() + s[s.Length - 1];
//            arr[i]=str; 
//        }
//        else
//        {
//            arr[i] = s;
//        }
//    }

//    for(int i = 0; i < num; i++)
//    {
//        Console.WriteLine(arr[i]);
//    }
//}
//else
//{
//    Console.WriteLine($"{n} is not a number!");
//}

//17.
//Console.WriteLine("Enter a calculation: ");
//string calc = Console.ReadLine();

//string[] arrCalc = calc.Split("+");

//int[] intArr = Array.ConvertAll(arrCalc, s=>int.Parse(s));

//Array.Sort(intArr);

//for(int i = 0; i < intArr.Length; i++)
//{
//    if (i < intArr.Length - 1)
//    {
//        Console.Write($"{intArr[i]}+");
//    }
//    else
//    {
//        Console.Write(intArr[i]);
//    }
//}

//18.
//Console.WriteLine("Enter a string: ");
//string str = Console.ReadLine();

//string s = "";

//for(int i =0;i<str.Length; i++)
//{
//    if (str[i] != 'a' && str[i] != 'e' && str[i] != 'i' && str[i] != 'o' && str[i] != 'u' && str[i] != 'A' && str[i] != 'E' && str[i] != 'I' && str[i] != 'O' && str[i] != 'U')
//    {
//        s = s + "."+ char.ToLower(str[i]);
//    }
//}
//Console.WriteLine(s);

//19.
//Console.WriteLine("Enter a username: ");
//string s = Console.ReadLine();
//Dictionary<char, int> map = new Dictionary<char, int>();

//for (int i = 0; i < s.Length; i++)
//{
//    if (map.ContainsKey(s[i])) continue;
//    map.Add(s[i], 1);
//}

//int sumUnique = 0;

//foreach (var unique in map)
//{
//    sumUnique+=unique.Value;
//}

//if (sumUnique % 2 == 0)
//{
//    Console.WriteLine("CHAT WITH HER!");
//}
//else
//{
//    Console.WriteLine("IGNORE HIM!");
//}

//20.
//Console.WriteLine("Enter a string: ");
//string s=Console.ReadLine();

//int upperChar = 0;
//int lowerChar = 0;
//string result = "";

//for(int i = 0; i < s.Length; i++)
//{
//    if (char.IsUpper(s[i])) upperChar++;
//    if (char.IsLower(s[i])) lowerChar++;
//}

//if (upperChar > lowerChar)
//{
//    for(int i = 0; i < s.Length; i++)
//    {
//        result += char.ToUpper(s[i]);
//    }
//}
//else
//{
//    for (int i = 0; i < s.Length; i++)
//    {
//        result += char.ToLower(s[i]);
//    }
//}

//Console.WriteLine(result);

//21.
//Console.WriteLine("Enter a string: ");
//string s = Console.ReadLine();

//int upperCase = 0;
//string result = "";

//for(int i = 0; i < s.Length; i++)
//{
//    if (char.IsUpper(s[i])) upperCase++;
//}

//if(upperCase == s.Length || (upperCase==s.Length-1 && char.IsLower(s[0])) || (s.Length==1 && char.IsLower(s[0])))
//{
//    result += char.ToUpper(s[0]);
//    for(int i = 1; i < s.Length; i++)
//    {
//        result += char.ToLower(s[i]);
//    }
//    Console.WriteLine(result);
//}
//else
//{
//    Console.WriteLine(s);
//}
