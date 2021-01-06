
namespace Project6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Axes = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ZTrText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.YTrText = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTrZ = new System.Windows.Forms.TrackBar();
            this.XTrText = new System.Windows.Forms.Label();
            this.tbTrY = new System.Windows.Forms.TrackBar();
            this.tbTrX = new System.Windows.Forms.TrackBar();
            this.Light = new System.Windows.Forms.CheckBox();
            this.Wire = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ZRtText = new System.Windows.Forms.Label();
            this.YRtText = new System.Windows.Forms.Label();
            this.XRtText = new System.Windows.Forms.Label();
            this.chBRotZ = new System.Windows.Forms.CheckBox();
            this.chBRotY = new System.Windows.Forms.CheckBox();
            this.chBRotX = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRotZ = new System.Windows.Forms.TrackBar();
            this.tbRotY = new System.Windows.Forms.TrackBar();
            this.tbRotX = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrX)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotX)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGLControl1
            // 
            this.openGLControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openGLControl1.DrawFPS = false;
            this.openGLControl1.Location = new System.Drawing.Point(1, 0);
            this.openGLControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(791, 654);
            this.openGLControl1.TabIndex = 0;
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl1_OpenGLDraw);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Куб",
            "Пирамида",
            "Сфера",
            "Чайник",
            "Конус",
            "Цилиндр",
            "Тор",
            "Икосаэдр",
            "Октаэдр",
            "Тетраэдр",
            "Додeкаэдр"});
            this.comboBox1.Location = new System.Drawing.Point(153, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите фигуру";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(7, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 54);
            this.panel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(788, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(355, 654);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Axes);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.Light);
            this.tabPage1.Controls.Add(this.Wire);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(347, 625);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "3D";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Axes
            // 
            this.Axes.AutoSize = true;
            this.Axes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Axes.Location = new System.Drawing.Point(160, 219);
            this.Axes.Name = "Axes";
            this.Axes.Size = new System.Drawing.Size(56, 21);
            this.Axes.TabIndex = 13;
            this.Axes.Text = "Оси";
            this.Axes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ZTrText);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.YTrText);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbTrZ);
            this.groupBox2.Controls.Add(this.XTrText);
            this.groupBox2.Controls.Add(this.tbTrY);
            this.groupBox2.Controls.Add(this.tbTrX);
            this.groupBox2.Location = new System.Drawing.Point(17, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 136);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Перенос";
            // 
            // ZTrText
            // 
            this.ZTrText.AutoSize = true;
            this.ZTrText.Location = new System.Drawing.Point(30, 92);
            this.ZTrText.Name = "ZTrText";
            this.ZTrText.Size = new System.Drawing.Size(16, 17);
            this.ZTrText.TabIndex = 14;
            this.ZTrText.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Z:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Y:";
            // 
            // YTrText
            // 
            this.YTrText.AutoSize = true;
            this.YTrText.Location = new System.Drawing.Point(30, 58);
            this.YTrText.Name = "YTrText";
            this.YTrText.Size = new System.Drawing.Size(16, 17);
            this.YTrText.TabIndex = 13;
            this.YTrText.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "X:";
            // 
            // tbTrZ
            // 
            this.tbTrZ.AutoSize = false;
            this.tbTrZ.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbTrZ.Location = new System.Drawing.Point(52, 87);
            this.tbTrZ.Maximum = 30;
            this.tbTrZ.Minimum = -30;
            this.tbTrZ.Name = "tbTrZ";
            this.tbTrZ.Size = new System.Drawing.Size(254, 30);
            this.tbTrZ.TabIndex = 2;
            this.tbTrZ.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // XTrText
            // 
            this.XTrText.AutoSize = true;
            this.XTrText.Location = new System.Drawing.Point(30, 25);
            this.XTrText.Name = "XTrText";
            this.XTrText.Size = new System.Drawing.Size(16, 17);
            this.XTrText.TabIndex = 12;
            this.XTrText.Text = "0";
            // 
            // tbTrY
            // 
            this.tbTrY.AutoSize = false;
            this.tbTrY.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbTrY.Location = new System.Drawing.Point(52, 51);
            this.tbTrY.Maximum = 20;
            this.tbTrY.Minimum = -20;
            this.tbTrY.Name = "tbTrY";
            this.tbTrY.Size = new System.Drawing.Size(254, 30);
            this.tbTrY.TabIndex = 1;
            this.tbTrY.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbTrX
            // 
            this.tbTrX.AutoSize = false;
            this.tbTrX.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbTrX.Location = new System.Drawing.Point(52, 21);
            this.tbTrX.Maximum = 20;
            this.tbTrX.Minimum = -20;
            this.tbTrX.Name = "tbTrX";
            this.tbTrX.Size = new System.Drawing.Size(254, 30);
            this.tbTrX.TabIndex = 0;
            this.tbTrX.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // Light
            // 
            this.Light.AutoSize = true;
            this.Light.Checked = true;
            this.Light.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Light.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Light.Location = new System.Drawing.Point(25, 246);
            this.Light.Name = "Light";
            this.Light.Size = new System.Drawing.Size(106, 21);
            this.Light.TabIndex = 6;
            this.Light.Text = "Освещение";
            this.Light.UseVisualStyleBackColor = true;
            // 
            // Wire
            // 
            this.Wire.AutoSize = true;
            this.Wire.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Wire.Location = new System.Drawing.Point(25, 219);
            this.Wire.Name = "Wire";
            this.Wire.Size = new System.Drawing.Size(69, 21);
            this.Wire.TabIndex = 5;
            this.Wire.Text = "Сетка";
            this.Wire.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ZRtText);
            this.groupBox1.Controls.Add(this.YRtText);
            this.groupBox1.Controls.Add(this.XRtText);
            this.groupBox1.Controls.Add(this.chBRotZ);
            this.groupBox1.Controls.Add(this.chBRotY);
            this.groupBox1.Controls.Add(this.chBRotX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbRotZ);
            this.groupBox1.Controls.Add(this.tbRotY);
            this.groupBox1.Controls.Add(this.tbRotX);
            this.groupBox1.Location = new System.Drawing.Point(7, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 136);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вращение";
            // 
            // ZRtText
            // 
            this.ZRtText.AutoSize = true;
            this.ZRtText.Location = new System.Drawing.Point(31, 91);
            this.ZRtText.Name = "ZRtText";
            this.ZRtText.Size = new System.Drawing.Size(16, 17);
            this.ZRtText.TabIndex = 11;
            this.ZRtText.Text = "0";
            // 
            // YRtText
            // 
            this.YRtText.AutoSize = true;
            this.YRtText.Location = new System.Drawing.Point(31, 57);
            this.YRtText.Name = "YRtText";
            this.YRtText.Size = new System.Drawing.Size(16, 17);
            this.YRtText.TabIndex = 10;
            this.YRtText.Text = "0";
            // 
            // XRtText
            // 
            this.XRtText.AutoSize = true;
            this.XRtText.Location = new System.Drawing.Point(30, 24);
            this.XRtText.Name = "XRtText";
            this.XRtText.Size = new System.Drawing.Size(16, 17);
            this.XRtText.TabIndex = 9;
            this.XRtText.Text = "0";
            // 
            // chBRotZ
            // 
            this.chBRotZ.AutoSize = true;
            this.chBRotZ.Location = new System.Drawing.Point(305, 91);
            this.chBRotZ.Name = "chBRotZ";
            this.chBRotZ.Size = new System.Drawing.Size(18, 17);
            this.chBRotZ.TabIndex = 8;
            this.chBRotZ.UseVisualStyleBackColor = true;
            // 
            // chBRotY
            // 
            this.chBRotY.AutoSize = true;
            this.chBRotY.Location = new System.Drawing.Point(305, 56);
            this.chBRotY.Name = "chBRotY";
            this.chBRotY.Size = new System.Drawing.Size(18, 17);
            this.chBRotY.TabIndex = 7;
            this.chBRotY.UseVisualStyleBackColor = true;
            // 
            // chBRotX
            // 
            this.chBRotX.AutoSize = true;
            this.chBRotX.Location = new System.Drawing.Point(305, 24);
            this.chBRotX.Name = "chBRotX";
            this.chBRotX.Size = new System.Drawing.Size(18, 17);
            this.chBRotX.TabIndex = 6;
            this.chBRotX.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Z:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:";
            // 
            // tbRotZ
            // 
            this.tbRotZ.AutoSize = false;
            this.tbRotZ.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbRotZ.Location = new System.Drawing.Point(53, 86);
            this.tbRotZ.Maximum = 360;
            this.tbRotZ.Minimum = -360;
            this.tbRotZ.Name = "tbRotZ";
            this.tbRotZ.Size = new System.Drawing.Size(246, 30);
            this.tbRotZ.TabIndex = 2;
            this.tbRotZ.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbRotY
            // 
            this.tbRotY.AutoSize = false;
            this.tbRotY.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbRotY.Location = new System.Drawing.Point(53, 53);
            this.tbRotY.Maximum = 360;
            this.tbRotY.Minimum = -360;
            this.tbRotY.Name = "tbRotY";
            this.tbRotY.Size = new System.Drawing.Size(246, 30);
            this.tbRotY.TabIndex = 1;
            this.tbRotY.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tbRotX
            // 
            this.tbRotX.AutoSize = false;
            this.tbRotX.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbRotX.Location = new System.Drawing.Point(52, 21);
            this.tbRotX.Maximum = 360;
            this.tbRotX.Minimum = -360;
            this.tbRotX.Name = "tbRotX";
            this.tbRotX.Size = new System.Drawing.Size(247, 30);
            this.tbRotX.TabIndex = 0;
            this.tbRotX.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(347, 625);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2D";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Location = new System.Drawing.Point(17, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 124);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Выберите объект";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Квадрат",
            "Треугольник",
            "Буква А",
            "Буква М",
            "Буква К"});
            this.comboBox2.Location = new System.Drawing.Point(81, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 654);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.openGLControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotX)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbRotZ;
        private System.Windows.Forms.TrackBar tbRotY;
        private System.Windows.Forms.TrackBar tbRotX;
        private System.Windows.Forms.CheckBox chBRotZ;
        private System.Windows.Forms.CheckBox chBRotY;
        private System.Windows.Forms.CheckBox chBRotX;
        private System.Windows.Forms.CheckBox Wire;
        private System.Windows.Forms.CheckBox Light;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar tbTrZ;
        private System.Windows.Forms.TrackBar tbTrY;
        private System.Windows.Forms.TrackBar tbTrX;
        private System.Windows.Forms.Label ZRtText;
        private System.Windows.Forms.Label YRtText;
        private System.Windows.Forms.Label XRtText;
        private System.Windows.Forms.Label ZTrText;
        private System.Windows.Forms.Label YTrText;
        private System.Windows.Forms.Label XTrText;
        private System.Windows.Forms.CheckBox Axes;
    }
}

