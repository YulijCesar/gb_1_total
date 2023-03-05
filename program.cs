string[] ArrWithCondition(string[] srtrigsArray, int controlLength)
{
  int stringLength = 0;
  string newString = string.Empty;

  for (int i = 0; i < srtrigsArray.Length; i++)
  {
    stringLength = srtrigsArray[i].Length;
    if (stringLength <= controlLength)
    {
      if (newString == "") // чтобы не начинать newString с разделителя использовать проверку на первый элемент
      {
        newString = srtrigsArray[i];
      }
      else
      {
        newString = newString + "|" + srtrigsArray[i]; // можно "подобрать" уникальный разделитель при понимании с какими строками придется работать
      }
    }
  }
  string[] newArrWithCond = newString.Split('|');
  return newArrWithCond;
}


string[] srtrigsArray = new string[] {"hello",
                                        "2",
                                        "world",
                                        ";)",
                                        "1234",
                                        "1567",
                                        "-2",
                                        "computer science",
                                        "Russia",
                                        "Denmark",
                                        "Kazan"};
int controlStrLength = 3;

Console.WriteLine("исходный массив строк:");
Console.WriteLine("[" + String.Format("\"{0}\"", string.Join("\", \"", srtrigsArray)) + "]\n");

Console.WriteLine($"массив строк, длина которых меньше или равна {controlStrLength}:");
string[] arrWithCond = ArrWithCondition(srtrigsArray, controlStrLength);
Console.WriteLine("[" + String.Format("\"{0}\"", string.Join("\", \"", arrWithCond)) + "]\n");