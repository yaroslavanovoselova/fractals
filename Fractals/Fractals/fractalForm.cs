using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fractals
{
    /// <summary>
    /// Класс формы, в котором рисуется фрактал.
    /// </summary>
    public partial class fractalForm : Form
    {
        // Индекс, раннее отрисованного фрактала.
        // Нужен для автоматической перерисовки фрактала при изменении глубины рекурсии. 
        int indexOfPreviosFractal;
        // Фрактал, который будет создан.
        RealFractal fractal;
        
        public fractalForm()
        {
            InitializeComponent();
            // Устанавливаем минимальный и максимальный размер формы.
            this.MaximumSize = SystemInformation.PrimaryMonitorSize;
            this.MinimumSize = SystemInformation.PrimaryMonitorSize/2;
            // Приветствие.
            MessageBox.Show("Добро пожаловать в программу!" +
                "\n\nЕй пользоваться достаточно просто: выбираете фрактал, выбираете глубину рекурсии " +
                "и вводите дополнительную информацию, если необходимо." +
                "\n\nПри изменении глубины рекурсии фрактал будет автоматически перерисован, " +
                "а если хотите нарисовать новый фрактал, то необходимо кликнуть на кнопку." +
                "\nТакже можете раскрашивать фрактал градиентом, для этого достаточно кликнуть на сам цвет и выбрать его." +
                "\nЕще можно изменять масштаб фрактала и сохранять его." +
                "\n\nНадеюсь, все понятно. До скорого!", "Информация о программе.");
        }

        /// <summary>
        /// Метод получения PictureBox.
        /// </summary>
        /// <returns> PictureBox, на котором рисуется фрактал. </returns>
        public PictureBox GetPictureBox()
        {
            return fractalPictureBox;
        }

        /// <summary>
        /// Заполнение TextBox коэффицентом (для дерева Пифогора).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"> Событие заполнения TextBox. </param>
        private void firstCoeffBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;
            // Переводим курсор на следующий TextBox.
            else if (e.KeyChar == (char)Keys.Enter)
                secondCoeffBox.Focus();
            // Запрещаем использовать что-то кроме цифр при заполнении.
            e.Handled = true;
        }

        /// <summary>
        /// Заполнение TextBox вторым коэффицентом (для дерева Пифогора).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"> Событие заполнения TextBox. </param>
        private void secondCoeffBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;
            // Переводим курсор на следующий TextBox.
            else if (e.KeyChar == (char)Keys.Enter)
                firstAngleBox.Focus();
            // Запрещаем использовать что-то кроме цифр при заполнении.
            e.Handled = true;
        }

        /// <summary>
        /// Заполнение TextBox первым углом (для дерева Пифогора).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"> Событие заполнения TextBox.</param>
        private void firstAngleBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;
            // Переводим курсор на следующий TextBox.
            else if (e.KeyChar == (char)Keys.Enter)
                secondAngleBox.Focus();
            // Запрещаем использовать что-то кроме цифр при заполнении.
            e.Handled = true;
        }

        /// <summary>
        /// Ввод информации о втором угле (для дерева Пифогора).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"> Событие заполнения TextBox.</param>
        private void secondAngleBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (e.KeyChar >= '0' && e.KeyChar <= '9' )
                return;
            // Переводим курсор на кнопку рисования.
            else if (e.KeyChar == (char)Keys.Enter)
                drawButton.Focus();
            // Запрещаем использовать что-то кроме цифр при заполнении.
            e.Handled = true;
        }

        /// <summary>
        /// Ввод информации о расстоянии между отрезками (для множества Кантора).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void distanceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (e.KeyChar >= '0' && e.KeyChar <= '9'  )
                return;
            else if (e.KeyChar == (char)Keys.Enter)
            {
                drawButton.Enabled = true;
                drawButton.Focus();
            }
            e.Handled = true;
        }

        /// <summary>
        /// Рисования фрактала при нажатии на кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"> Нажатие на кнопку. </param>
        private void drawButton_Click(object sender, EventArgs e)
        {
            try
            {
                // В зависимости от выбранного фрактала проверям данные и рисуем сам фрактал.
                switch (listOfFractals.SelectedIndex)
                {
                    case 0:
                        // Проверки на корректность введенных данных.
                        if (firstCoeffBox.Text == null || secondAngleBox.Text == null || firstAngleBox.Text == null || secondAngleBox.Text == null)
                        {
                            MessageBox.Show("Все дополнительные данные для Фрактального дерева должны быть введены.\nПопробуйте ввести данные еще раз.");
                            return;
                        }
                        if (!int.TryParse(firstAngleBox.Text, out var firstAngle) || !int.TryParse(secondAngleBox.Text, out var secondAngle)
                            || !int.TryParse(firstCoeffBox.Text, out var firstCoeff) || !int.TryParse(secondCoeffBox.Text, out var secondCoeff))
                        {
                            MessageBox.Show("Все данные о дереве должны быть натуральными числами. \nПопробуйте ввести еще раз.");
                            return;
                        }
                        if (firstCoeff == 0 || secondCoeff == 0)
                        {
                            MessageBox.Show("Отношение длин отрезков введено некорректно (что-то равно 0). \nПопробуйте ввести еще раз.");
                            return;
                        }
                        if (firstCoeff / (double)secondCoeff > 0.7)
                        {
                            MessageBox.Show("Отношение между отрезками должно быть меньше 0,7. \nПопробуйте ввести еще раз.");
                            return;
                        }
                        if (firstAngle < 25 || firstAngle > 65 || secondAngle < 25 || secondAngle > 65)
                        {
                            MessageBox.Show("Угол введен некорректно. \nПопробуйте ввести еще раз.");
                            return;
                        }
                        // Создаем фрактал-дерево и отрисовываем его.
                        fractal = new PythagorasTree(numberOfSteps.Value, GetPictureBox(), GetListOfColors(), firstAngle, secondAngle, firstCoeff, secondCoeff);
                        // Запоминаем тип отрисованного фрактала.
                        indexOfPreviosFractal = 0;
                        break;
                    case 1:
                        // Создаем фрактал-кривую и отрисовываем его.
                        fractal = new KochCurve(numberOfSteps.Value, GetPictureBox(), GetListOfColors());
                        // Запоминаем тип отрисованного фрактала.
                        indexOfPreviosFractal = 1;
                        break;
                    case 2:
                        // Создаем фрактал-ковер и отрисовываем его.
                        fractal = new SierpinskiCarpet(numberOfSteps.Value, GetPictureBox(), GetListOfColors(), carpetColor);
                        // Запоминаем тип отрисованного фрактала.
                        indexOfPreviosFractal = 2;
                        break;
                    case 3:
                        // Создаем фрактал-треугольник и отрисовываем его.
                        fractal = new SierpinskiTriangle(numberOfSteps.Value, GetPictureBox(), GetListOfColors());
                        // Запоминаем тип отрисованного фрактала.
                        indexOfPreviosFractal = 3;
                        break;
                    case 4:
                        // Проверки на корректность введенных данных.
                        if (distanceBox.Text == null)
                        {
                            MessageBox.Show("Все дополнительные данные для Множества Кантора должны быть введены. \nПопробуйте ввести данные еще раз.");
                            return;
                        }
                        if (!int.TryParse(distanceBox.Text, out var distance))
                        {
                            MessageBox.Show("Расстояние между отрезками -- натуральное число. \nПопробуйте ввести еще раз.");
                            return;
                        }
                        if (distance < 5 || distance > 50)
                        {
                            MessageBox.Show("Расстояние должно принадлежать от 5 до 50.\nПопробуйте ввести еще раз. ");
                            return;
                        }
                        // Создаем фрактал-множество и отрисовываем его.
                        fractal = new CantorSet(numberOfSteps.Value, GetPictureBox(), GetListOfColors(), distance);
                        // Запоминаем тип отрисованного фрактала.
                        indexOfPreviosFractal = 4;
                        break;
                    default:
                        MessageBox.Show("Вы пока не выбрали тип фрактала, поэтому он не может быть нарисован.\nНе забудьте это сделать в следующий раз. ");
                        break;
                }
                
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так, попробуйте еще раз.");
            }
        }

        /// <summary>
        /// Автоматически перерисовываем фрактал, если глубина рекурсии была изменена.
        /// </summary>
        private void numberOfSteps_ValueChanged(object sender, EventArgs e)
        {
            if (fractalPictureBox.Image!=null&& indexOfPreviosFractal == listOfFractals.SelectedIndex)
            {
                drawButton_Click(sender, e);
            }
        }

        /// <summary>
        /// Цвет первого шага рекурсии.
        /// </summary>
        Color startColor =  Color.MediumVioletRed;
        /// <summary>
        /// Цвет последнего шага рекурсии.
        /// </summary>
        Color endColor = Color.MediumVioletRed;
        /// <summary>
        /// Список цветов всех итераций.
        /// </summary>
        List<Color> colors;

        /// <summary>
        /// Устанавливаем цвет первого шага рекурсии.
        /// </summary>
        private void startColorButton_Click_1(object sender, EventArgs e)
        {
            if (startColorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            startColor = startColorDialog.Color;
            startColorButton.BackColor = startColor;
        }

        /// <summary>
        /// Устанавливаем цвет последнего шага рекурсии.
        /// </summary>
        private void endColorButton_Click(object sender, EventArgs e)
        {
            if (endColorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            endColor = endColorDialog.Color;
            endColorButton.BackColor = endColor;
        }

        /// <summary>
        /// Вычисляем промежуточные цвета.
        /// </summary>
        /// <returns> Список цветов для каждой итерации. </returns>
        private List<Color> GetListOfColors()
        {
            colors =  new List<Color>();
            if (numberOfSteps.Value == 1)
            {
                colors.Add(startColor);
                colors.Add(endColor);
            }
            else
            {
                // Определяем "шаг" по каждому из параметров цвета.
                int stepR = ((endColor.R - startColor.R) / (numberOfSteps.Value - 1));
                int stepG = ((endColor.G - startColor.G) / (numberOfSteps.Value - 1));
                int stepB = ((endColor.B - startColor.B) / (numberOfSteps.Value - 1));
                // Добавляем цвет в массив.
                for (int i = 0; i < numberOfSteps.Value; i++)
                {
                    colors.Add(Color.FromArgb(startColor.R + (stepR * i), startColor.G + (stepG * i), startColor.B + (stepB * i)));
                }
            }
            return colors;
        }

        /// <summary>
        /// Цвет фона ковра Серпинского.
        /// </summary>
        Color carpetColor = Color.LightSteelBlue;
        /// <summary>
        /// Выбор цвета фона ковра.
        /// </summary>
        private void carpetColorButton_Click(object sender, EventArgs e)
        {
            if (carpetColorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            carpetColor = carpetColorDialog.Color;
            carpetColorButton.BackColor = carpetColor;
        }

        /// <summary>
        /// Метод перерисовки фрактала при изменении размера форма.
        /// </summary>
        private void Fractal_Resize(object sender, EventArgs e)
        {
            // Задаем новый размер для PictureBox (панель изменяется автоматически).
            fractalPictureBox.Size = fractalPanel.Size*zoomTrackBar.Value;
            // Перерисовываем прежний фрактал.
            if (fractalPictureBox.Image != null && fractal!=null)
            {
                fractal.PaintFractal();
            }
        }

        /// <summary>
        /// Сохранения фрактала.
        /// </summary>
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Проверка, что фрактал был нарисован.
            if (fractalPictureBox.Image == null)
                MessageBox.Show("Фрактал еще не был нарисован, поэтому нам нечего сохранять. " +
                    "\nСоздайте фрактал и потом нажмите на эту кнопку еще раз.");
            else
            {
                if (saveFractalDialog.ShowDialog() == DialogResult.Cancel) 
                    return;
                else
                {
                    try
                    {
                        // Сохранение фрактала.
                        fractalPictureBox.Image.Save(saveFractalDialog.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        /// <summary>
        /// Метод масштабирования фрактала.
        /// </summary>
        private void zoomTrackBar_ValueChanged(object sender, EventArgs e)
        {
            // Проверяем, что фрактал был уже нарисован.
            if (fractalPictureBox.Image != null && fractal != null)
            {
                // Задаем новый размер для PictureBox (панель изменяется автоматически).
                fractalPictureBox.Size  = fractalPanel.Size*zoomTrackBar.Value;
                // Перерисовываем прежний фрактал.
                fractal.PaintFractal();
                //drawButton_Click(sender, e);
            }
        }

        
    }
}


