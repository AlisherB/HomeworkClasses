using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthHomework
{
    //9.	Создать дополнительный метод для данного класса в другом файле, используя ключевое слово partial. 
    public partial class Auto
    {
        /*
        6.	Обязательным требованием является реализация нескольких перегруженных конструкторов, 
        аргументы которых определяются студентом, исходя из специфики реализуемого класса, 
        а так же реализация конструктора по умолчанию.
        */
        public Auto()
        {
            mark = null;
            model = null;
            color = null;
            countOfSeats = 0;
            classification = null;
            carBody = null;
        }
        public Auto(string mark, string model, string classification)
        {
            this.mark = mark;
            this.model = model;
            this.classification = classification;
        }
        public Auto(string mark, string model, string color, int countOfSeats, string classification, string carBody)
        {
            this.mark = mark;
            this.model = model;
            this.color = color;
            this.countOfSeats = countOfSeats;
            this.classification = classification;
            this.carBody = carBody;
        }
        
    }
}
