using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FourthHomework
{
    class CountOfAuto
    {
        public void CountOfCars(int count)
        {
            Auto[] auto = new Auto[count];
            for(int i = 0; i < count; i++)
            {
                auto[i] = new Auto();
                Write("Введите марку авто: ");
                auto[i].SetMark(ReadLine());
                Write("\nВведите модель авто: ");
                auto[i].SetModel(ReadLine());
                Write("\nВведите цвет авто: ");
                auto[i].SetColor(ReadLine());
                Write("\nВведите количество мест в авто: ");
                auto[i].SetCountOfSeats(Convert.ToInt32(ReadLine()));
                Write("\nВведите классификацию авто: ");
                auto[i].SetClassification(ReadLine());
                Write("\nВведите тип кузова: ");
                auto[i].SetСarBody(ReadLine());
                Clear();
                WriteLine("Марка: {0}\nМодель: {1}\nЦвет: {2}\nКоличество сидений: {3}\nКлассификация: {4}\nТип кузова: {5}", auto[i].GetMark(), auto[i].GetModel(), auto[i].GetColor(), auto[i].GetCountOfSeats(), auto[i].GetClassification(), auto[i].GetCarBody());
            }
        }
    }
}
