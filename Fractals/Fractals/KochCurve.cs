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
    /// Класс кривой Коха.
    /// </summary>
    class KochCurve : RealFractal
    {
        /// <summary>
        /// Конструктор кривой.
        /// </summary>
        /// <param name="steps"> Глубина рекурсии. </param>
        /// <param name="fractalBox"> PictureBox, на котором рисуется фрактал. </param>
        /// <param name="colors"> Список цветов, которые используются для каждой итерации. </param>
        public KochCurve(int steps, PictureBox fractalBox, List<Color> colors) : base(steps, fractalBox, colors)
        {
            MaxSteps = 5;
            // Проверка на корректность глубины рекурсии.
            if (MaxSteps < steps)
            {
                MessageBox.Show("Для выбранного фрактала максимальная глубина рекурсии равна 5. \nПопробуйте ввести еще раз.");
                return;
            }
            Steps = steps;
            // Отрисовка фрактала.
            PaintFractal();
        }

        /// <summary>
        /// Метод рисования фрактала.
        /// </summary>
        public override void PaintFractal()
        {
            base.PaintFractal();
            DrawKochCurve(new PointF(5, 2 * FractalBox.Height / 3), new PointF(FractalBox.Width - 5, 2 * FractalBox.Height / 3), Steps, 0);
            // Отображение результата.
            FractalBox.Image = Fractal;
        }

        /// <summary>
        /// Рекурсивный метод рисования.
        /// </summary>
        /// <param name="leftPoint"> Левая вершина треугольника. </param>
        /// <param name="rightPoint"> Правая вершина треугольника. </param>
        /// <param name="i"> Номер шага рекурсии (сколько шагов осталось). </param>
        /// <param name="colorNumb"> Номер цвета, которым раскрашивается элемент. </param>
        private void DrawKochCurve(PointF leftPoint, PointF rightPoint, int i, int colorNumb)
        {
            // Считаем точки для кривой, которые потом треугольника образовывать будут.
            var p2 = new PointF((-leftPoint.X + rightPoint.X) / 3 + leftPoint.X, (-leftPoint.Y + rightPoint.Y) / 3 + leftPoint.Y);
            var p4 = new PointF(2 * (-leftPoint.X + rightPoint.X) / 3 + leftPoint.X, 2 * (-leftPoint.Y + rightPoint.Y) / 3 + leftPoint.Y);
            float middlePointX = (float)(p2.X + (p4.X - p2.X) * Math.Cos(Math.PI / 3) - (p4.Y - p2.Y) * Math.Sin(5 * Math.PI / 3));
            float middlePointY = (float)((p2.Y + (p4.X - p2.X) * Math.Sin(5 * Math.PI / 3) + (p4.Y - p2.Y) * Math.Cos(Math.PI / 3)));
            var middlePoint = new PointF(middlePointX, middlePointY);
            // Если первый шаг рекурсии, то рисуем всю кривую (потом только новые треугольники).
            if (i == Steps)
            {
                Graph.DrawLine(new Pen(Colors[colorNumb], 2), leftPoint, p2);
                Graph.DrawLine(new Pen(Colors[colorNumb], 2), p4, rightPoint);

            }
            Graph.DrawLine(new Pen(Colors[colorNumb], 2), p2, middlePoint);
            Graph.DrawLine(new Pen(Colors[colorNumb], 2), middlePoint, p4);
            // Закрашиваем ненужные линии. 
            Graph.DrawLine(new Pen(Color.White, 2), p2, p4);
            // Рекурсивно вызываем следующие итерации.
            if (i > 1)
            {
                i -= 1;
                colorNumb++;
                DrawKochCurve(leftPoint, p2, i, colorNumb);
                DrawKochCurve(p2, middlePoint, i, colorNumb);
                DrawKochCurve(middlePoint, p4, i, colorNumb);
                DrawKochCurve(p4, rightPoint, i, colorNumb);
            }
        }
    }
}
