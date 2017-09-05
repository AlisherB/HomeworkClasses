using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FourthHomework
{
    //1.	Разработать один из классов, в соответствии с полученным вариантом.
    public partial class Auto
    {
        //2.	Реализовать не менее пяти закрытых полей (различных типов), представляющих основные характеристики рассматриваемого класса.
        private string mark;            //марка
        private string model;           //модель
        private string color;           //цвет
        private int countOfSeats;       //количество мест
        private string classification;  //классификация(легковой и т.д)
        private string carBody;         //кузов
        //5.	Создать не менее двух статических полей (различных типов),  представляющих общие характеристики объектов данного класса. 
        private static int minPrice;
        private static int maxSpeed;
        //3.    Методы доступа к его закрытым полям
        public void SetMark(string mark)
        {
            this.mark = mark;
        }
        public string GetMark()
        {
            return mark;
        }
        public void SetModel(string model)
        {
            this.model = model;
        }
        public string GetModel()
        {
            return model;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetCountOfSeats(int countOfSeats)
        {
            this.countOfSeats = countOfSeats;
        }
        public int GetCountOfSeats()
        {
            return countOfSeats;
        }
        public void SetClassification(string classification)
        {
            this.classification = classification;
        }
        public string GetClassification()
        {
            return classification;
        }
        public void SetСarBody(string carBody)
        {
            this.carBody = carBody;
        }
        public string GetCarBody()
        {
            return carBody;
        }
        //7.	Создать статический конструктор.
        static Auto()
        {
            minPrice = 10000;
            maxSpeed = 220;
        }
    }
}
