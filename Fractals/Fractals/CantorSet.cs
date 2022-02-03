using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Fractals
{
    /// <summary>
    /// Класс множества Кантора.
    /// </summary>
    public class CantorSet : RealFractal
    {
        // Расстояние между отрезками.
        int Distance { get; set; }

        /// <summary>
        ///  Конструктор множества.
        /// </summary>
        /// <param name="steps"> Глубина рекурсии. </param>
        /// <param name="fractalBox"> PictureBox, на котором рисуется фрактал. </param>
        /// <param name="colors"> Список цветов, которые используются для каждой итерации.</param>
        /// <param name="distance"> Расстояние между отрезками. </param>
        public CantorSet(int steps, PictureBox fractalBox, List<Color> colors, int distance) : base(steps, fractalBox, colors)
        {
            MaxSteps = 6;
            // Проверка на корректность глубины рекурсии.
            if (MaxSteps < steps)
            {
                MessageBox.Show("Для выбранного фрактала максимальная глубина рекурсии равна 6. \nПопробуйте ввести еще раз.");
                return;
            }
            Steps = steps;
            Distance = distance;
            // Отрисовка фрактала. 
            PaintFractal();
        }

        /// <summary>
        /// Метод рисования фрактала.
        /// </summary>
        public override void PaintFractal()
        {
            base.PaintFractal();
            // Отрисовка первой линии (итерация 0).
            var firstLine = new RectangleF(5, FractalBox.Height / 15, FractalBox.Width - 10, 15);
            Graph.FillRectangle(new SolidBrush(Colors[0]), firstLine);
            // Вызов рекурсивного метода.
            DrawCantorSet(firstLine, Steps);
            // Отображение результата.
            FractalBox.Image = Fractal;

        }

        /// <summary>
        /// Рекурсивный метод рисования множества Кантора.
        /// </summary>
        /// <param name="line"> Линия, которая была уже отрисована. </param>
        /// <param name="i"> Номер шага рекурсии (сколько шагов осталось).</param>
        private void DrawCantorSet(RectangleF line, int i)
        {
            var leftLine = new RectangleF(line.Left, line.Bottom + Distance, line.Width / 3f, 15);
            var rightLine = new RectangleF(line.Left + 2 * line.Width / 3f, line.Bottom + Distance, line.Width / 3f, 15);
            Graph.FillRectangle(new SolidBrush(Colors[Steps - i]), leftLine);
            Graph.FillRectangle(new SolidBrush(Colors[Steps - i]), rightLine);
            if (i > 1)
            {
                i--;
                DrawCantorSet(leftLine, i);
                DrawCantorSet(rightLine, i);
            }
        }
    }
}
