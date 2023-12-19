Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")               //ToLower - переводит в нижний регистр и устраняет проблемы с написанием(маша, мАша, МаШа и тд)
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
