//Показать вторую цифру трёхзначного числа.

int a = new Random().Next(1, 999);
string b = a.ToString();
Console.WriteLine($"Вторая цифра числа {a} это {b[1]}");
