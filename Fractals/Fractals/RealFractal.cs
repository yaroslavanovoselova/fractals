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
    /// Класс-родитель всех фракталов.
    /// </summary>
    public abstract class RealFractal
    {
        public int MaxSteps { get; set; }
        public int Steps { get; set; }
        public Bitmap Fractal{ get; set; }
        public Graphics Graph { get; set; }
        public PictureBox FractalBox { get; set; }
        public List<Color> Colors { get; set; }

        /// <summary>
        /// Конструктор базового фрактала.
        /// </summary>
        /// <param name="steps"> Глубина рекурсии. </param>
        /// <param name="fractalBox"> PictureBox, на котором рисуется фрактал. </param>
        /// <param name="colors"> Список цветов, которые используются для каждой итерации. </param>
        public RealFractal(int steps, PictureBox fractalBox, List<Color> colors)
        {
            Steps = steps;
            FractalBox = fractalBox;
            Colors = colors;
        }

        /// <summary>
        /// Отрисовка фрактала. 
        /// </summary>
        public virtual void PaintFractal()
        {
            // Создание Bitmap для фрактала.
            Fractal= new Bitmap(FractalBox.Width, FractalBox.Height);
            // Создание нового объекта Grapihs из Bitmap.
            Graph = Graphics.FromImage(Fractal);
        }

    }
}
