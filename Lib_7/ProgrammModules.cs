using System;

namespace Lib_7
{
    //Название класса без класса
    public class ProgrammModules
    {
        //Изменить название метода
        //Изменить название аргументов
        public static void SumHalfNumbers(int inputValue, out int result, out string numberList)
        {
            numberList = "";
            result = 0;
            //Сокращения и аббровеатуры недопустимы
            Random randomNumber = new Random();
            for (int i = 0; i < inputValue; i++)
            {
                int randNumber = randomNumber.Next(0, inputValue/2);
                result += randNumber;
                numberList += randNumber.ToString() + " ";
            }
        }
    }
}
