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
    /// Класс треугольника Серпинского.
    /// </summary>
    class SierpinskiTriangle : RealFractal
    {
        /// <summary>
        /// Конструктор треугольника.
        /// </summary>
        /// <param name="steps"> Глубина рекурсии. </param>
        /// <param name="fractalBox"> PictureBox, на котором рисуется фрактал. </param>
        /// <param name="colors"> Список цветов, которые используются для каждой итерации. </param>
        public SierpinskiTriangle(int steps, PictureBox fractalBox, List<Color> colors) : base(steps, fractalBox, colors)
        {
            MaxSteps = 7;
            // Проверка на корректность глубины рекурсии.
            if (MaxSteps < steps)
            {
                MessageBox.Show("Для выбранного фрактала максимальная глубина рекурсии равна 7. \nПопробуйте ввести еще раз.");
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
            // Вычисляем высоту треугольника.
            var h = FractalBox.Width > FractalBox.Height ? FractalBox.Height - 10 : FractalBox.Width - 10;
            // Сторона треугольника.
            var side = (float)(2 * h / Math.Sqrt(3));
            var pen = new Pen(Colors[0], (float)2.5);
            PointF topPoint = new PointF(5 + (float)(side / 2.0), 5);
            PointF leftPoint = new PointF(5, 5 + h);
            PointF rightPoint = new PointF(5 + side, 5 + h);
            // Рисуем первый треугольник (итерация 0).
            Graph.DrawLine(pen, rightPoint, leftPoint);
            Graph.DrawLine(pen, topPoint, leftPoint);
            Graph.DrawLine(pen, rightPoint, topPoint);
            DrawSierpinskiTriangle(leftPoint, topPoint, rightPoint, Steps);
            // Отображение результата.
            FractalBox.Image = Fractal;
        }

        /// <summary>
        /// Рекурсивный метод рисования.
        /// </summary>
        /// <param name="leftPoint"> Левая вершина треугольника. </param>
        /// <param name="topPoint"> Верхняя вершина треугольника. </param>
        /// <param name="rightPoint"> Правая вершина треугольника. </param>
        /// <param name="i"> Номер шага рекурсии (сколько шагов осталось). </param>
        private void DrawSierpinskiTriangle(PointF leftPoint, PointF topPoint, PointF rightPoint, int i)
        {
            var midLeft = MidPoint(leftPoint, topPoint);
            var midTop = MidPoint(leftPoint, rightPoint);
            var midRight = MidPoint(topPoint, rightPoint);
            Graph.DrawLine(new Pen(Colors[Steps - i], 2), midLeft, midTop);
            Graph.DrawLine(new Pen(Colors[Steps - i], 2), midLeft, midRight);
            Graph.DrawLine(new Pen(Colors[Steps - i], 2), midRight, midTop);
            if (i > 1)
            {
                i--;
                DrawSierpinskiTriangle(leftPoint, midLeft, midTop, i);
                DrawSierpinskiTriangle(midLeft, topPoint, midRight, i);
                DrawSierpinskiTriangle(midTop, midRight, rightPoint, i);
            }
        }

        /// <summary>
        /// Метод определения середины отрезка.
        /// </summary>
        /// <param name="p1"> Первая точка. </param>
        /// <param name="p2"> Вторая точка. </param>
        /// <returns> Точка середины отрезка. </returns>
        private PointF MidPoint(PointF p1, PointF p2) => new PointF((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
    }
}
