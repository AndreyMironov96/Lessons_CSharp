using System;

namespace Lessons_Interf
{
    /// <summary>
    /// Итерфейс реализующий стандартные функции утюга
    /// </summary>
   internal interface IIron
    {
        /// <summary>
        /// Количество воды в резервуаре утюга на данный момент
        /// </summary>
        double CountWater { get; set; }

       
        /// <summary>
        /// Температура наколения утюга.
        /// </summary>
        /// <param name="mode">Режим наколения.</param>
        /// <returns>Температура дна утюга.</returns>
        double Degree (int mode);

        /// <summary>
        /// Выход пара.
        /// </summary>
        /// <param name="press">Нажатие на кнопку.</param>
        /// <param name="isWater">Наличие воды для пара.</param>
        void Vapor(bool press);

        /// <summary>
        /// Наливание воды в утюг.
        /// </summary>
        /// <param name="CountWater">Количество воды.</param>
        void PourWater(double CountWater);

        /// <summary>
        /// Проверка количества воды в резервуаре утюга.
        /// </summary>
        /// <param name="CountWater"></param>
        /// <returns></returns>
        bool CheckWater();
    }
}
