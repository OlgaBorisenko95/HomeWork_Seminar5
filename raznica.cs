int[]array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10);
}
Console.WriteLine($"[{string.Join(",",array)}]");

int max = array[0];
int min = array[0];
for(int i = 0; i < array.Length; i++)
    {
    if(max < array[i]){max = array[i];}
    if(min > array[i]){min = array[i];}
    }
int diff = max-min;
Console.Write($" -> {diff}  ");
