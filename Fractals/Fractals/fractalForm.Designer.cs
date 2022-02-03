
namespace Fractals
{
    partial class fractalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.fractalPictureBox = new System.Windows.Forms.PictureBox();
            this.numberOfSteps = new System.Windows.Forms.TrackBar();
            this.numbersLabel = new System.Windows.Forms.Label();
            this.treeInfoLabel = new System.Windows.Forms.Label();
            this.coeffInfoLabel = new System.Windows.Forms.Label();
            this.firstAngleBox = new System.Windows.Forms.TextBox();
            this.firstCoeffBox = new System.Windows.Forms.TextBox();
            this.secondCoeffBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstAngleLabel = new System.Windows.Forms.Label();
            this.secondAngleLabel = new System.Windows.Forms.Label();
            this.secondAngleBox = new System.Windows.Forms.TextBox();
            this.cantorSetInfoLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.distanceBox = new System.Windows.Forms.TextBox();
            this.stepsLabel = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.listOfFractals = new System.Windows.Forms.ListBox();
            this.startColorDialog = new System.Windows.Forms.ColorDialog();
            this.startColorButton = new System.Windows.Forms.Button();
            this.endColorDialog = new System.Windows.Forms.ColorDialog();
            this.endColorButton = new System.Windows.Forms.Button();
            this.carpetColorButton = new System.Windows.Forms.Button();
            this.carpetColorDialog = new System.Windows.Forms.ColorDialog();
            this.carpetInfoLabel = new System.Windows.Forms.Label();
            this.carpetColorLabel = new System.Windows.Forms.Label();
            this.startColorLabel = new System.Windows.Forms.Label();
            this.endColorLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFractalDialog = new System.Windows.Forms.SaveFileDialog();
            this.fractalPanel = new System.Windows.Forms.Panel();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.numbers2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fractalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSteps)).BeginInit();
            this.fractalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // fractalPictureBox
            // 
            this.fractalPictureBox.BackColor = System.Drawing.Color.White;
            this.fractalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fractalPictureBox.Location = new System.Drawing.Point(0, 0);
            this.fractalPictureBox.Name = "fractalPictureBox";
            this.fractalPictureBox.Size = new System.Drawing.Size(631, 457);
            this.fractalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fractalPictureBox.TabIndex = 0;
            this.fractalPictureBox.TabStop = false;
            // 
            // numberOfSteps
            // 
            this.numberOfSteps.LargeChange = 3;
            this.numberOfSteps.Location = new System.Drawing.Point(525, 9);
            this.numberOfSteps.Maximum = 15;
            this.numberOfSteps.Minimum = 1;
            this.numberOfSteps.Name = "numberOfSteps";
            this.numberOfSteps.Size = new System.Drawing.Size(401, 56);
            this.numberOfSteps.TabIndex = 3;
            this.numberOfSteps.Tag = "";
            this.numberOfSteps.Value = 1;
            this.numberOfSteps.ValueChanged += new System.EventHandler(this.numberOfSteps_ValueChanged);
            // 
            // numbersLabel
            // 
            this.numbersLabel.AutoSize = true;
            this.numbersLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numbersLabel.Location = new System.Drawing.Point(525, 46);
            this.numbersLabel.Name = "numbersLabel";
            this.numbersLabel.Size = new System.Drawing.Size(397, 19);
            this.numbersLabel.TabIndex = 7;
            this.numbersLabel.Text = "  1     2    3     4     5    6     7    8    9    10   11   12  13   14  15";
            // 
            // treeInfoLabel
            // 
            this.treeInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.treeInfoLabel.AutoSize = true;
            this.treeInfoLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.treeInfoLabel.Location = new System.Drawing.Point(672, 182);
            this.treeInfoLabel.Name = "treeInfoLabel";
            this.treeInfoLabel.Size = new System.Drawing.Size(379, 19);
            this.treeInfoLabel.TabIndex = 8;
            this.treeInfoLabel.Text = "Дополнительные данные для фрактального дерева:";
            // 
            // coeffInfoLabel
            // 
            this.coeffInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coeffInfoLabel.AutoSize = true;
            this.coeffInfoLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coeffInfoLabel.Location = new System.Drawing.Point(683, 207);
            this.coeffInfoLabel.Name = "coeffInfoLabel";
            this.coeffInfoLabel.Size = new System.Drawing.Size(338, 57);
            this.coeffInfoLabel.TabIndex = 9;
            this.coeffInfoLabel.Text = "Отношение длины отрезка последующей итерации\r\nк отрезку текущей (например, 2 : 3)" +
    ":\r\n(соотношение должно быть меньше 0,7)";
            // 
            // firstAngleBox
            // 
            this.firstAngleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.firstAngleBox.Location = new System.Drawing.Point(1015, 267);
            this.firstAngleBox.Name = "firstAngleBox";
            this.firstAngleBox.Size = new System.Drawing.Size(35, 27);
            this.firstAngleBox.TabIndex = 10;
            this.firstAngleBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstAngleBox_KeyPress);
            // 
            // firstCoeffBox
            // 
            this.firstCoeffBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.firstCoeffBox.BackColor = System.Drawing.SystemColors.Window;
            this.firstCoeffBox.Location = new System.Drawing.Point(955, 234);
            this.firstCoeffBox.Name = "firstCoeffBox";
            this.firstCoeffBox.Size = new System.Drawing.Size(35, 27);
            this.firstCoeffBox.TabIndex = 11;
            this.firstCoeffBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstCoeffBox_KeyPress);
            // 
            // secondCoeffBox
            // 
            this.secondCoeffBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.secondCoeffBox.BackColor = System.Drawing.SystemColors.Window;
            this.secondCoeffBox.Location = new System.Drawing.Point(1015, 234);
            this.secondCoeffBox.Name = "secondCoeffBox";
            this.secondCoeffBox.Size = new System.Drawing.Size(35, 27);
            this.secondCoeffBox.TabIndex = 12;
            this.secondCoeffBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondCoeffBox_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(996, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = ":";
            // 
            // firstAngleLabel
            // 
            this.firstAngleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.firstAngleLabel.AutoSize = true;
            this.firstAngleLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstAngleLabel.Location = new System.Drawing.Point(683, 272);
            this.firstAngleLabel.Name = "firstAngleLabel";
            this.firstAngleLabel.Size = new System.Drawing.Size(290, 19);
            this.firstAngleLabel.TabIndex = 14;
            this.firstAngleLabel.Text = "Угол наклона первого отрезка (от 25 до 65):";
            // 
            // secondAngleLabel
            // 
            this.secondAngleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.secondAngleLabel.AutoSize = true;
            this.secondAngleLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondAngleLabel.Location = new System.Drawing.Point(683, 305);
            this.secondAngleLabel.Name = "secondAngleLabel";
            this.secondAngleLabel.Size = new System.Drawing.Size(289, 19);
            this.secondAngleLabel.TabIndex = 15;
            this.secondAngleLabel.Text = "Угол наклона второго отрезка (от 25 до 65):";
            // 
            // secondAngleBox
            // 
            this.secondAngleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.secondAngleBox.Location = new System.Drawing.Point(1015, 300);
            this.secondAngleBox.Name = "secondAngleBox";
            this.secondAngleBox.Size = new System.Drawing.Size(35, 27);
            this.secondAngleBox.TabIndex = 16;
            this.secondAngleBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondAngleBox_KeyPress);
            // 
            // cantorSetInfoLabel
            // 
            this.cantorSetInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cantorSetInfoLabel.AutoSize = true;
            this.cantorSetInfoLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cantorSetInfoLabel.Location = new System.Drawing.Point(672, 330);
            this.cantorSetInfoLabel.Name = "cantorSetInfoLabel";
            this.cantorSetInfoLabel.Size = new System.Drawing.Size(366, 19);
            this.cantorSetInfoLabel.TabIndex = 17;
            this.cantorSetInfoLabel.Text = "Дополнительные данные для множества Кантора:";
            // 
            // distanceLabel
            // 
            this.distanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.distanceLabel.Location = new System.Drawing.Point(683, 360);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(310, 38);
            this.distanceLabel.TabIndex = 18;
            this.distanceLabel.Text = "Расстояние между отрезками, отрисованными \r\nна разных итерациях (от 5 до 50):";
            // 
            // distanceBox
            // 
            this.distanceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.distanceBox.Location = new System.Drawing.Point(955, 382);
            this.distanceBox.Name = "distanceBox";
            this.distanceBox.Size = new System.Drawing.Size(35, 27);
            this.distanceBox.TabIndex = 19;
            this.distanceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.distanceBox_KeyPress);
            // 
            // stepsLabel
            // 
            this.stepsLabel.AutoSize = true;
            this.stepsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stepsLabel.Location = new System.Drawing.Point(379, 9);
            this.stepsLabel.Name = "stepsLabel";
            this.stepsLabel.Size = new System.Drawing.Size(143, 20);
            this.stepsLabel.TabIndex = 21;
            this.stepsLabel.Text = "Глубина рекурсии:";
            // 
            // drawButton
            // 
            this.drawButton.BackColor = System.Drawing.Color.Thistle;
            this.drawButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.drawButton.Location = new System.Drawing.Point(12, 128);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(250, 40);
            this.drawButton.TabIndex = 22;
            this.drawButton.Text = "Нарисовать фрактал";
            this.drawButton.UseVisualStyleBackColor = false;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // listOfFractals
            // 
            this.listOfFractals.BackColor = System.Drawing.Color.Lavender;
            this.listOfFractals.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listOfFractals.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listOfFractals.FormattingEnabled = true;
            this.listOfFractals.ItemHeight = 20;
            this.listOfFractals.Items.AddRange(new object[] {
            "Фрактальное дерево (15 вызовов)",
            "Кривая Коха (5 вызовов)",
            "Ковер Серпинского (5 вызовов)",
            "Треугольник Серпинского (7 вызовов)",
            "Множество Кантора (6 вызовов)"});
            this.listOfFractals.Location = new System.Drawing.Point(12, 13);
            this.listOfFractals.Name = "listOfFractals";
            this.listOfFractals.Size = new System.Drawing.Size(361, 104);
            this.listOfFractals.TabIndex = 24;
            // 
            // startColorButton
            // 
            this.startColorButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.startColorButton.Location = new System.Drawing.Point(525, 79);
            this.startColorButton.Name = "startColorButton";
            this.startColorButton.Size = new System.Drawing.Size(105, 40);
            this.startColorButton.TabIndex = 25;
            this.startColorButton.UseVisualStyleBackColor = false;
            this.startColorButton.Click += new System.EventHandler(this.startColorButton_Click_1);
            // 
            // endColorButton
            // 
            this.endColorButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.endColorButton.Location = new System.Drawing.Point(824, 77);
            this.endColorButton.Name = "endColorButton";
            this.endColorButton.Size = new System.Drawing.Size(105, 40);
            this.endColorButton.TabIndex = 26;
            this.endColorButton.UseVisualStyleBackColor = false;
            this.endColorButton.Click += new System.EventHandler(this.endColorButton_Click);
            // 
            // carpetColorButton
            // 
            this.carpetColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.carpetColorButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.carpetColorButton.Location = new System.Drawing.Point(956, 446);
            this.carpetColorButton.Name = "carpetColorButton";
            this.carpetColorButton.Size = new System.Drawing.Size(95, 35);
            this.carpetColorButton.TabIndex = 27;
            this.carpetColorButton.UseVisualStyleBackColor = false;
            this.carpetColorButton.Click += new System.EventHandler(this.carpetColorButton_Click);
            // 
            // carpetInfoLabel
            // 
            this.carpetInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.carpetInfoLabel.AutoSize = true;
            this.carpetInfoLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.carpetInfoLabel.Location = new System.Drawing.Point(672, 412);
            this.carpetInfoLabel.Name = "carpetInfoLabel";
            this.carpetInfoLabel.Size = new System.Drawing.Size(364, 19);
            this.carpetInfoLabel.TabIndex = 28;
            this.carpetInfoLabel.Text = "Дополнительные данные для ковра Серпинского:";
            // 
            // carpetColorLabel
            // 
            this.carpetColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.carpetColorLabel.AutoSize = true;
            this.carpetColorLabel.BackColor = System.Drawing.Color.Transparent;
            this.carpetColorLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.carpetColorLabel.Location = new System.Drawing.Point(683, 443);
            this.carpetColorLabel.Name = "carpetColorLabel";
            this.carpetColorLabel.Size = new System.Drawing.Size(272, 38);
            this.carpetColorLabel.TabIndex = 29;
            this.carpetColorLabel.Text = "Основной цвет заливки ковра (чтобы его\r\nизменить, кликните на сам цвет):";
            // 
            // startColorLabel
            // 
            this.startColorLabel.AutoSize = true;
            this.startColorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startColorLabel.Location = new System.Drawing.Point(379, 79);
            this.startColorLabel.Name = "startColorLabel";
            this.startColorLabel.Size = new System.Drawing.Size(139, 40);
            this.startColorLabel.TabIndex = 30;
            this.startColorLabel.Text = "Цвет отрисовки \r\nпервой итерации:";
            // 
            // endColorLabel
            // 
            this.endColorLabel.AutoSize = true;
            this.endColorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.endColorLabel.Location = new System.Drawing.Point(655, 77);
            this.endColorLabel.Name = "endColorLabel";
            this.endColorLabel.Size = new System.Drawing.Size(163, 40);
            this.endColorLabel.TabIndex = 31;
            this.endColorLabel.Text = "Цвет отрисовки\r\nпоследней итерации:";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightPink;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(272, 128);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(250, 40);
            this.saveButton.TabIndex = 32;
            this.saveButton.Text = "Сохранить фрактал";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveFractalDialog
            // 
            this.saveFractalDialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image " +
    "Files(*.PNG)|*.PNG|All files (*.*)|*.*";
            this.saveFractalDialog.ShowHelp = true;
            this.saveFractalDialog.Title = "Сохранить картинку как...";
            // 
            // fractalPanel
            // 
            this.fractalPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fractalPanel.AutoScroll = true;
            this.fractalPanel.BackColor = System.Drawing.Color.Transparent;
            this.fractalPanel.Controls.Add(this.fractalPictureBox);
            this.fractalPanel.Location = new System.Drawing.Point(12, 182);
            this.fractalPanel.Name = "fractalPanel";
            this.fractalPanel.Size = new System.Drawing.Size(631, 457);
            this.fractalPanel.TabIndex = 33;
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.LargeChange = 1;
            this.zoomTrackBar.Location = new System.Drawing.Point(824, 123);
            this.zoomTrackBar.Maximum = 5;
            this.zoomTrackBar.Minimum = 1;
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Size = new System.Drawing.Size(106, 56);
            this.zoomTrackBar.TabIndex = 1;
            this.zoomTrackBar.Value = 1;
            this.zoomTrackBar.ValueChanged += new System.EventHandler(this.zoomTrackBar_ValueChanged);
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scaleLabel.Location = new System.Drawing.Point(655, 128);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(152, 20);
            this.scaleLabel.TabIndex = 34;
            this.scaleLabel.Text = "Масштаб фрактала:";
            // 
            // numbers2
            // 
            this.numbers2.AutoSize = true;
            this.numbers2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numbers2.Location = new System.Drawing.Point(834, 153);
            this.numbers2.Name = "numbers2";
            this.numbers2.Size = new System.Drawing.Size(91, 15);
            this.numbers2.TabIndex = 35;
            this.numbers2.Text = "х1  х2  х3  х4  х5";
            // 
            // fractalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1067, 651);
            this.Controls.Add(this.numbers2);
            this.Controls.Add(this.scaleLabel);
            this.Controls.Add(this.carpetColorButton);
            this.Controls.Add(this.zoomTrackBar);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.endColorLabel);
            this.Controls.Add(this.startColorLabel);
            this.Controls.Add(this.carpetColorLabel);
            this.Controls.Add(this.carpetInfoLabel);
            this.Controls.Add(this.endColorButton);
            this.Controls.Add(this.startColorButton);
            this.Controls.Add(this.listOfFractals);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.stepsLabel);
            this.Controls.Add(this.distanceBox);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.cantorSetInfoLabel);
            this.Controls.Add(this.secondAngleBox);
            this.Controls.Add(this.secondAngleLabel);
            this.Controls.Add(this.firstAngleLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.secondCoeffBox);
            this.Controls.Add(this.firstCoeffBox);
            this.Controls.Add(this.firstAngleBox);
            this.Controls.Add(this.coeffInfoLabel);
            this.Controls.Add(this.treeInfoLabel);
            this.Controls.Add(this.numbersLabel);
            this.Controls.Add(this.numberOfSteps);
            this.Controls.Add(this.fractalPanel);
            this.MinimizeBox = false;
            this.Name = "fractalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добро пожаловать в программу \"Фрактал\"!";
            this.Resize += new System.EventHandler(this.Fractal_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.fractalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSteps)).EndInit();
            this.fractalPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private  System.Windows.Forms.PictureBox fractalPictureBox;
        private System.Windows.Forms.TrackBar numberOfSteps;
        private System.Windows.Forms.Label numbersLabel;
        private System.Windows.Forms.Label treeInfoLabel;
        private System.Windows.Forms.Label coeffInfoLabel;
        private System.Windows.Forms.TextBox firstAngleBox;
        private System.Windows.Forms.TextBox firstCoeffBox;
        private System.Windows.Forms.TextBox secondCoeffBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstAngle;
        private System.Windows.Forms.Label firstAngleLabel;
        private System.Windows.Forms.Label secondAngleLabel;
        private System.Windows.Forms.TextBox secondAngleBox;
        private System.Windows.Forms.Label cantorSetInfoLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.TextBox distanceBox;
        private System.Windows.Forms.Label stepsLabel;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.ListBox listOfFractals;
        private System.Windows.Forms.ColorDialog startColorDialog;
        private System.Windows.Forms.Button startColorButton;
        private System.Windows.Forms.ColorDialog endColorDialog;
        private System.Windows.Forms.Button endColorButton;
        private System.Windows.Forms.Button carpetColorButton;
        private System.Windows.Forms.ColorDialog carpetColorDialog;
        private System.Windows.Forms.Label carpetInfoLabel;
        private System.Windows.Forms.Label carpetColorLabel;
        private System.Windows.Forms.Label startColorLabel;
        private System.Windows.Forms.Label endColorLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFractalDialog;
        private System.Windows.Forms.Panel fractalPanel;
        private System.Windows.Forms.TrackBar zoomTrackBar;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.Label numbers2;
    }
}