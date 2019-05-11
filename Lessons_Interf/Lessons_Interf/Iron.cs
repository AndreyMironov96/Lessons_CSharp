using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Interf
{
    class Iron : IIron
    {
       private double countWater;
        /// <summary>
        /// Количество воды в утюге на данный момент
        /// </summary>
        public double CountWater
        {
            get { return countWater; }
          
            set
            {
                if (value < 0)
                    value = 0;
                countWater = value;
              
            }
        } 


        /// <summary>
        /// Проверка количества воды в резервуаре утюга
        /// </summary>
        /// <returns>Возращает результат проверки воды</returns>
        public bool CheckWater()
        {
            if (CountWater > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Температура утюжного дна.
        /// </summary>
        /// <param name="mode">режим от 1-7</param>
        /// <returns></returns>
        public double Degree(int mode)
        {
            return mode * 20;
        }

        /// <summary>
        /// Добавление воды в резервуар утюга
        /// </summary>
        /// <param name="countWater">Количество воды</param>
        public void PourWater(double countWater)
        {
            if (countWater > 0)
               CountWater += countWater;
            else
                throw new ArgumentException("Не возможно налить пустое количество воды", nameof(countWater));
        }

        /// <summary>
        /// Функция пара
        /// </summary>
        /// <param name="press">Активация функции пара</param>
        public void Vapor(bool press)
        {
            if (CountWater > 0.5f)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ПЫШ ПЫШ");
                CountWater -= 100f;
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
                Console.WriteLine("Резервур пуст, ПЫШ ПЫШ не получится... добавте воды");
        }


    }
}
