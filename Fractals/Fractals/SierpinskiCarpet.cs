using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Fractals
{
    /// <summary>
    /// Класс ковра Серпинского.
    /// </summary>
    class SierpinskiCarpet : RealFractal
    {
        /// <summary>
        /// Цвет фона ковра.
        /// </summary>
        Color CarpetColor;

        /// <summary>
        /// Конструктор ковра.
        /// </summary>
        /// <param name="steps"> Глубина рекурсии. </param>
        /// <param name="fractalBox"> PictureBox, на котором рисуется фрактал.</param>
        /// <param name="colors"> Список цветов, которые используются для каждой итерации.</param>
        /// <param name="carpetColor"> Цвет фона ковра. </param>
        public SierpinskiCarpet(int steps, PictureBox fractalBox, List<Color> colors, Color carpetColor) : base(steps, fractalBox, colors)
        {
            MaxSteps = 5;
            // Проверка на корректность глубины рекурсии.
            if (MaxSteps < steps)
            {
                MessageBox.Show("Для выбранного фрактала максимальная глубина рекурсии равна 5. \nПопробуйте ввести еще раз.");
                return;
            }
            Steps = steps;
            CarpetColor = carpetColor;
            // Отрисовка фрактала.
            PaintFractal();
        }

        /// <summary>
        /// Метод рисования фрактала.
        /// </summary>
        public override void PaintFractal()
        {
            base.PaintFractal();
            // Определяем сторону ковра (наименьшая размерность PictureBox).
            var side = FractalBox.Width > FractalBox.Height ? FractalBox.Height : FractalBox.Width;
            // Создаем сам ковер.
            var firstSquare = new RectangleF(5, 5, side - 10, side - 10);
            Graph.FillRectangle(new SolidBrush(CarpetColor), firstSquare);
            DrawSierpinskiCarpet(firstSquare, Steps);
            // Отображение результата.
            FractalBox.Image = Fractal;
        }

        /// <summary>
        /// Элемент-квадрат ковра.
        /// </summary>
        /// <param name="rectangle"> Квадрат, который надо разделить на части. </param>
        /// <param name="i"> Номер шага рекурсии (сколько шагов осталось).</param>
        private void DrawSierpinskiCarpet(RectangleF rectangle, int i)
        {
            // Вычисление нового элемента-квадрата.
            var newSide = rectangle.Width / 3f;
            var x1 = rectangle.Left;
            var x2 = x1 + newSide;
            var x3 = x2 + newSide;
            var y1 = rectangle.Top;
            var y2 = y1 + newSide;
            var y3 = y2 + newSide;
            // Рисуем серединный элемент ковра.
            Graph.FillRectangle(new SolidBrush(Colors[Steps - i]), new RectangleF(x2, y2, newSide, newSide));
            // Рекурсивно вызываем тот же метод для каждого квадрата.
            if (i > 1)
            {
                i -= 1;
                DrawSierpinskiCarpet(new RectangleF(x1, y1, newSide, newSide), i);
                DrawSierpinskiCarpet(new RectangleF(x2, y1, newSide, newSide), i);
                DrawSierpinskiCarpet(new RectangleF(x3, y1, newSide, newSide), i);
                DrawSierpinskiCarpet(new RectangleF(x1, y2, newSide, newSide), i);
                DrawSierpinskiCarpet(new RectangleF(x3, y2, newSide, newSide), i);
                DrawSierpinskiCarpet(new RectangleF(x1, y3, newSide, newSide), i);
                DrawSierpinskiCarpet(new RectangleF(x2, y3, newSide, newSide), i);
                DrawSierpinskiCarpet(new RectangleF(x3, y3, newSide, newSide), i);
            }
        }
    }
}
