// See https://aka.ms/new-console-template for more information
List<int> arr;
int[] arr1, arr2;

string inputContent = File.ReadAllText("C:\\Users\\AVEPIPEL\\source\\AdventOfCode2024\\AdventCodeDay1\\input.txt");
char[] delimiters = { '\n', ' ' };
var temp = inputContent.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
arr = temp.Select(x => int.Parse(x)).ToList();

int arrLength = arr.ToArray().Length;
arr1 = new int[arrLength / 2];
arr2 = new int[arrLength / 2];

for (int i = 0; i < arrLength; i += 2)
{
    arr1[i / 2] = arr[i];
    arr2[i / 2] = arr[i + 1];
}

Array.Sort(arr1);
Array.Sort(arr2);

int[] arr3 = new int[arrLength / 2];
for (int i = 0, j = arr3.Length; i < j; i++)
{
    arr3[i] = Math.Abs(arr1[i] - arr2[i]);
}

int arr3Sum = arr3.Sum();

//Console.WriteLine("The sum is: " + arr3Sum);

