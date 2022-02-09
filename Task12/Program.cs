//Удалить вторую цифру трёхзначного числа.

int a = new Random().Next(1, 999);
string b = a.ToString();
Console.WriteLine(b);
Console.WriteLine(b.Remove(1, 1));

