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
    /// Класс дерева Пифагора.
    /// </summary>
    class PythagorasTree : RealFractal
    {
        int FirstAngle { get; set; }
        int SecondAngle { get; set; }
        int FirstCoeff { get; set; }
        int SecondCoeff { get; set; }
        /// <summary>
        /// Конструктор дерева.
        /// </summary>
        /// <param name="steps"> Глубина рекурсии. </param>
        /// <param name="fractalBox"> PictureBox, на котором рисуется фрактал. </param>
        /// <param name="colors"> Список цветов, которые используются для каждой итерации. </param>
        /// <param name="firstAngle"> Угол наклона первой ветки. </param>
        /// <param name="secondAngle"> Угол наклона второй ветви. </param>
        /// <param name="firstCoeff"> Коэффицент отношения ветвей (последующая итерация). </param>
        /// <param name="secondCoeff"> Коэффицент отношения ветвей (текущая итерация).</param>
        public PythagorasTree(int steps, PictureBox fractalBox, List<Color> colors, int firstAngle, int secondAngle, int firstCoeff, int secondCoeff)
            : base(steps, fractalBox, colors)
        {
            FirstAngle = firstAngle;
            SecondAngle = secondAngle;
            FirstCoeff = firstCoeff;
            SecondCoeff = secondCoeff;
            MaxSteps = 15;
            PaintFractal();
        }

        /// <summary>
        /// Метод рисования фрактала.
        /// </summary>
        public override void PaintFractal()
        {
            base.PaintFractal();
            DrawPythagorasTree((float)(FractalBox.Width / 2.0), 10, (float)(FractalBox.Height / 3.5), 0, Steps);
            // Отображение результата.
            FractalBox.Image = Fractal;
        }

        /// <summary>
        /// Рекурсивный метод рисования множества.
        /// </summary>
        /// <param name="startX"> Координата начала ветки (по Х).</param>
        /// <param name="startY"> Координата начала ветки (по У).</param>
        /// <param name="len"> Длина ветви. </param>
        /// <param name="angle"> Угол наклона ветви. </param>
        /// <param name="i"> Номер шага рекурсии (сколько шагов осталось). </param>
        private void DrawPythagorasTree(float startX, float startY, float len, int angle, int i)
        {

            double secondPointX = startX + len * Math.Sin(angle * 2 * Math.PI / 360.0);
            double secondPointY = startY + len * Math.Cos(angle * 2 * Math.PI / 360.0);
            Graph.DrawLine(new Pen(Colors[Steps - i], (float)2.5), startX, FractalBox.Height - startY, (float)secondPointX, FractalBox.Height - (float)secondPointY);
            if (i > 1)
            {
                i -= 1;
                len = len * FirstCoeff / SecondCoeff;
                DrawPythagorasTree((float)secondPointX, (float)secondPointY, len, angle - SecondAngle, i);
                DrawPythagorasTree((float)secondPointX, (float)secondPointY, len, angle + FirstAngle, i);

            }
        }
    }
}
