using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Calculator
{
		public class Calc : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Button btn_sbros;
		private System.Windows.Forms.Button btnChangesign;
		private System.Windows.Forms.Button btnpoint;
		private System.Windows.Forms.Button btn_ravno;
		private System.Windows.Forms.Button btn_delenie;
		private System.Windows.Forms.Button btn_umnojenie;
		private System.Windows.Forms.Button btn_plus;
		private System.Windows.Forms.Button btn_minus;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
        private IContainer components;

        /// <summary>
        /// Объявляем и инициализируем переменные, которые будут
        ///  возникать на экране при нажатии соответствующих кнопок.
        /// </summary>
        private const string odin = "1";
		private const string dva = "2";
		private const string tri = "3";
		private const string chetire = "4";
		private const string pyat = "5";
		private const string shest = "6";
		private const string sem = "7";
		private const string vosem = "8";
		private const string devyat = "9";
        private MenuStrip menuStrip1;
        private ToolStripMenuItem VidMenuItem;
        private ToolStripMenuItem MainToolStrip;
        private ToolStripMenuItem EngToolStrip;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private Button Stepen;
        private Button Square;
        private Button RevValue;
        private Button Exponent;
        private Button Factorial;
        private Button Cube;
        private Button Quadratic;
        private ToolTip toolTip1;
        private GroupBox groupBox1;
        private const string nul = "0";

		public Calc()
		{
			InitializeComponent();
			// При запуске приложения на экране будет нуль
			txtOutput.Text = "0";
            TopMost = true;
        }

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btn_sbros = new System.Windows.Forms.Button();
            this.btnChangesign = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btn_ravno = new System.Windows.Forms.Button();
            this.btn_delenie = new System.Windows.Forms.Button();
            this.btn_umnojenie = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.VidMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.EngToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Stepen = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.RevValue = new System.Windows.Forms.Button();
            this.Exponent = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.Cube = new System.Windows.Forms.Button();
            this.Quadratic = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.AccessibleName = "Display";
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.BackColor = System.Drawing.SystemColors.Menu;
            this.txtOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtOutput.Location = new System.Drawing.Point(12, 27);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(286, 38);
            this.txtOutput.TabIndex = 60;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_sbros
            // 
            this.btn_sbros.AccessibleName = "reset";
            this.btn_sbros.BackColor = System.Drawing.SystemColors.Control;
            this.btn_sbros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_sbros.Location = new System.Drawing.Point(199, 92);
            this.btn_sbros.Name = "btn_sbros";
            this.btn_sbros.Size = new System.Drawing.Size(106, 50);
            this.btn_sbros.TabIndex = 0;
            this.btn_sbros.Text = "C";
            this.toolTip1.SetToolTip(this.btn_sbros, "Обнулить данные");
            this.btn_sbros.UseVisualStyleBackColor = false;
            this.btn_sbros.Click += new System.EventHandler(this.btn_sbros_Click);
            // 
            // btnChangesign
            // 
            this.btnChangesign.AccessibleName = "change sign";
            this.btnChangesign.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangesign.Location = new System.Drawing.Point(12, 260);
            this.btnChangesign.Name = "btnChangesign";
            this.btnChangesign.Size = new System.Drawing.Size(50, 50);
            this.btnChangesign.TabIndex = 58;
            this.btnChangesign.Text = "+/-";
            this.toolTip1.SetToolTip(this.btnChangesign, "Положительное/отрицательное число");
            this.btnChangesign.UseVisualStyleBackColor = false;
            this.btnChangesign.Click += new System.EventHandler(this.btnChangesign_Click);
            // 
            // btnpoint
            // 
            this.btnpoint.AccessibleName = "point ";
            this.btnpoint.BackColor = System.Drawing.SystemColors.Control;
            this.btnpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnpoint.Location = new System.Drawing.Point(124, 260);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(50, 50);
            this.btnpoint.TabIndex = 57;
            this.btnpoint.Text = ",";
            this.toolTip1.SetToolTip(this.btnpoint, "Десятичный разделитель");
            this.btnpoint.UseVisualStyleBackColor = false;
            this.btnpoint.Click += new System.EventHandler(this.btnpoint_Click);
            // 
            // btn_ravno
            // 
            this.btn_ravno.AccessibleDescription = "ravno";
            this.btn_ravno.AccessibleName = "equal";
            this.btn_ravno.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ravno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ravno.Location = new System.Drawing.Point(199, 260);
            this.btn_ravno.Name = "btn_ravno";
            this.btn_ravno.Size = new System.Drawing.Size(106, 50);
            this.btn_ravno.TabIndex = 56;
            this.btn_ravno.Text = "=";
            this.toolTip1.SetToolTip(this.btn_ravno, "Равно");
            this.btn_ravno.UseVisualStyleBackColor = false;
            this.btn_ravno.Click += new System.EventHandler(this.btn_ravno_Click);
            // 
            // btn_delenie
            // 
            this.btn_delenie.AccessibleName = "divide ";
            this.btn_delenie.BackColor = System.Drawing.SystemColors.Control;
            this.btn_delenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_delenie.Location = new System.Drawing.Point(255, 204);
            this.btn_delenie.Name = "btn_delenie";
            this.btn_delenie.Size = new System.Drawing.Size(50, 50);
            this.btn_delenie.TabIndex = 55;
            this.btn_delenie.Text = "/";
            this.toolTip1.SetToolTip(this.btn_delenie, "Деление");
            this.btn_delenie.UseVisualStyleBackColor = false;
            this.btn_delenie.Click += new System.EventHandler(this.btn_delenie_Click);
            // 
            // btn_umnojenie
            // 
            this.btn_umnojenie.AccessibleName = "multiply ";
            this.btn_umnojenie.BackColor = System.Drawing.SystemColors.Control;
            this.btn_umnojenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_umnojenie.Location = new System.Drawing.Point(255, 148);
            this.btn_umnojenie.Name = "btn_umnojenie";
            this.btn_umnojenie.Size = new System.Drawing.Size(50, 50);
            this.btn_umnojenie.TabIndex = 54;
            this.btn_umnojenie.Text = "*";
            this.toolTip1.SetToolTip(this.btn_umnojenie, "Умножение");
            this.btn_umnojenie.UseVisualStyleBackColor = false;
            this.btn_umnojenie.Click += new System.EventHandler(this.btn_umnojenie_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.AccessibleName = "plus ";
            this.btn_plus.BackColor = System.Drawing.SystemColors.Control;
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_plus.Location = new System.Drawing.Point(199, 204);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(50, 50);
            this.btn_plus.TabIndex = 53;
            this.btn_plus.Text = "+";
            this.toolTip1.SetToolTip(this.btn_plus, "Сложение");
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.AccessibleName = "minus ";
            this.btn_minus.BackColor = System.Drawing.SystemColors.Control;
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_minus.Location = new System.Drawing.Point(199, 148);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(50, 50);
            this.btn_minus.TabIndex = 52;
            this.btn_minus.Text = "-";
            this.toolTip1.SetToolTip(this.btn_minus, "Вычитание");
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn0
            // 
            this.btn0.AccessibleName = "zero";
            this.btn0.BackColor = System.Drawing.SystemColors.Control;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn0.Location = new System.Drawing.Point(68, 260);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(50, 50);
            this.btn0.TabIndex = 51;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.AccessibleName = "nine ";
            this.btn9.BackColor = System.Drawing.SystemColors.Control;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn9.Location = new System.Drawing.Point(124, 92);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 50);
            this.btn9.TabIndex = 50;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.AccessibleName = "eight ";
            this.btn8.BackColor = System.Drawing.SystemColors.Control;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn8.Location = new System.Drawing.Point(68, 92);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 50);
            this.btn8.TabIndex = 49;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.AccessibleName = "seven ";
            this.btn7.BackColor = System.Drawing.SystemColors.Control;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn7.Location = new System.Drawing.Point(12, 92);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 50);
            this.btn7.TabIndex = 48;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.AccessibleName = "six ";
            this.btn6.BackColor = System.Drawing.SystemColors.Control;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn6.Location = new System.Drawing.Point(124, 148);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 47;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.AccessibleName = "five ";
            this.btn5.BackColor = System.Drawing.SystemColors.Control;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn5.Location = new System.Drawing.Point(68, 148);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 46;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.AccessibleName = "four ";
            this.btn4.BackColor = System.Drawing.SystemColors.Control;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn4.Location = new System.Drawing.Point(12, 148);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 45;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.AccessibleName = "three ";
            this.btn3.BackColor = System.Drawing.SystemColors.Control;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.Location = new System.Drawing.Point(124, 204);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 44;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.AccessibleName = "two ";
            this.btn2.BackColor = System.Drawing.SystemColors.Control;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.Location = new System.Drawing.Point(68, 204);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 43;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.AccessibleName = "one ";
            this.btn1.BackColor = System.Drawing.SystemColors.Control;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Location = new System.Drawing.Point(12, 204);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 42;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VidMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(310, 24);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // VidMenuItem
            // 
            this.VidMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStrip,
            this.EngToolStrip,
            this.ExitToolStripMenuItem});
            this.VidMenuItem.Name = "VidMenuItem";
            this.VidMenuItem.Size = new System.Drawing.Size(117, 20);
            this.VidMenuItem.Text = "&Вид калькулятора";
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(148, 22);
            this.MainToolStrip.Text = "&Обычный";
            this.MainToolStrip.Click += new System.EventHandler(this.MainToolStrip_Click);
            // 
            // EngToolStrip
            // 
            this.EngToolStrip.Name = "EngToolStrip";
            this.EngToolStrip.Size = new System.Drawing.Size(148, 22);
            this.EngToolStrip.Text = "&Инженерный";
            this.EngToolStrip.Click += new System.EventHandler(this.EngToolStrip_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ExitToolStripMenuItem.Text = "&Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Stepen
            // 
            this.Stepen.BackColor = System.Drawing.SystemColors.Control;
            this.Stepen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stepen.Location = new System.Drawing.Point(326, 92);
            this.Stepen.Name = "Stepen";
            this.Stepen.Size = new System.Drawing.Size(50, 50);
            this.Stepen.TabIndex = 62;
            this.Stepen.Text = "X^n";
            this.toolTip1.SetToolTip(this.Stepen, "Возведение в степень");
            this.Stepen.UseVisualStyleBackColor = false;
            this.Stepen.Click += new System.EventHandler(this.Stepen_Click);
            // 
            // Square
            // 
            this.Square.BackColor = System.Drawing.SystemColors.Control;
            this.Square.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Square.Location = new System.Drawing.Point(382, 92);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(50, 50);
            this.Square.TabIndex = 63;
            this.Square.Text = "√";
            this.toolTip1.SetToolTip(this.Square, "Извлечение квадратного корня");
            this.Square.UseVisualStyleBackColor = false;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // RevValue
            // 
            this.RevValue.BackColor = System.Drawing.SystemColors.Control;
            this.RevValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RevValue.Location = new System.Drawing.Point(326, 148);
            this.RevValue.Name = "RevValue";
            this.RevValue.Size = new System.Drawing.Size(50, 50);
            this.RevValue.TabIndex = 64;
            this.RevValue.Text = "1/x";
            this.toolTip1.SetToolTip(this.RevValue, "Расчет обратного значения");
            this.RevValue.UseVisualStyleBackColor = false;
            this.RevValue.Click += new System.EventHandler(this.RevValue_Click);
            // 
            // Exponent
            // 
            this.Exponent.BackColor = System.Drawing.SystemColors.Control;
            this.Exponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exponent.Location = new System.Drawing.Point(382, 148);
            this.Exponent.Name = "Exponent";
            this.Exponent.Size = new System.Drawing.Size(50, 50);
            this.Exponent.TabIndex = 65;
            this.Exponent.Text = "x^2";
            this.toolTip1.SetToolTip(this.Exponent, "Определение квадратного числа");
            this.Exponent.UseVisualStyleBackColor = false;
            this.Exponent.Click += new System.EventHandler(this.Exponent_Click);
            // 
            // Factorial
            // 
            this.Factorial.BackColor = System.Drawing.SystemColors.Control;
            this.Factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Factorial.Location = new System.Drawing.Point(326, 204);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(50, 50);
            this.Factorial.TabIndex = 66;
            this.Factorial.Text = "!n";
            this.toolTip1.SetToolTip(this.Factorial, "Факториал");
            this.Factorial.UseVisualStyleBackColor = false;
            this.Factorial.Click += new System.EventHandler(this.Factorial_Click);
            // 
            // Cube
            // 
            this.Cube.BackColor = System.Drawing.SystemColors.Control;
            this.Cube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cube.Location = new System.Drawing.Point(382, 204);
            this.Cube.Name = "Cube";
            this.Cube.Size = new System.Drawing.Size(50, 50);
            this.Cube.TabIndex = 67;
            this.Cube.Text = "3√";
            this.toolTip1.SetToolTip(this.Cube, "Извлечение кубического корня");
            this.Cube.UseVisualStyleBackColor = false;
            this.Cube.Click += new System.EventHandler(this.Cube_Click);
            // 
            // Quadratic
            // 
            this.Quadratic.BackColor = System.Drawing.SystemColors.Control;
            this.Quadratic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quadratic.Location = new System.Drawing.Point(326, 260);
            this.Quadratic.Name = "Quadratic";
            this.Quadratic.Size = new System.Drawing.Size(106, 50);
            this.Quadratic.TabIndex = 68;
            this.Quadratic.Text = "Квадратное уравнение";
            this.toolTip1.SetToolTip(this.Quadratic, "Решение квадратного уравнения");
            this.Quadratic.UseVisualStyleBackColor = false;
            this.Quadratic.Click += new System.EventHandler(this.Quadratic_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 317);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(310, 317);
            this.Controls.Add(this.Quadratic);
            this.Controls.Add(this.Cube);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.Exponent);
            this.Controls.Add(this.RevValue);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Stepen);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btn_sbros);
            this.Controls.Add(this.btnChangesign);
            this.Controls.Add(this.btnpoint);
            this.Controls.Add(this.btn_ravno);
            this.Controls.Add(this.btn_delenie);
            this.Controls.Add(this.btn_umnojenie);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор 2.0";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Calc());
		}
		/// <summary>
		/// Обработчики для кнопок  обращаются к методу chislonaEkrane класса mehanizmcalkulyatora
		/// и передают ему одну из постоянных (odin, dva, tri  и т.д.). Результат, возвращаемый методом,
		/// присваивается  свойству Text текстового поля txtOutput.
		/// </summary>

		private void btn1_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (odin);
		}

		private void btn2_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (dva);
        }

		private void btn3_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (tri);
        }

		private void btn4_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (chetire);
		}

		private void btn5_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (pyat);
		}

		private void btn6_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (shest);
		}

		private void btn7_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (sem);
		}

		private void btn8_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (vosem);
		}

		private void btn9_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (devyat);
		}

		private void btn0_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (nul);
		}

		private void btnChangesign_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.ZnakChisla();
		}

		private void btnpoint_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.ZnakTochki();
		}
			/// <summary>
			/// Обработчики кнопок действия калькулятора передают 
			/// методу DeystvieCalculatora класса mehanizmcalkulyatora переменную перечисления Deystvie.
			/// </summary>
		
		private void btn_delenie_Click(object sender, System.EventArgs e)
		{
			mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Delenie);
		}

		private void btn_umnojenie_Click(object sender, System.EventArgs e)
		{
			mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Umnojenie);
		}

		private void btn_minus_Click(object sender, System.EventArgs e)
		{
			mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Vichitanie);
		}

		private void btn_plus_Click(object sender, System.EventArgs e)
		{
			mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Slojenie);
		}

		private void btn_ravno_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.ZnakRavno();
			mehanizmcalkulyatora.Sbros();
		}

		private void btn_sbros_Click(object sender, System.EventArgs e)
		{
			mehanizmcalkulyatora.Sbros();
			txtOutput.Text = "0";
		}

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Close();
		}
        //возведение в степень
        private void Stepen_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Stepen);
        }

        private void Square_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.Square();
        }

        private void RevValue_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.RevValue();
        }

        private void Exponent_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.Exponent();
        }
        //вид калькулятора
        private void MainToolStrip_Click(object sender, EventArgs e)
        {
            this.Size = new Size(330, 360);
        }

        private void EngToolStrip_Click(object sender, EventArgs e)
        {
            this.Size = new Size(460, 360);
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.Factorial();
        }

        private void Cube_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.Cube();
        }

        private void Quadratic_Click(object sender, EventArgs e)
        {
            QuadraticForm newChild = new QuadraticForm();
            newChild.Show();
        }
    }
    class mehanizmcalkulyatora
	{
	/// <summary>
	///Создаем перечисление Deystvie, для определения одного из 11 действий калькулятора.
	/// </summary>
		public enum Deystvie:int
		{
			NeopredelDeystvie = 0,
			Slojenie = 1,
			Vichitanie = 2,
			Umnojenie = 3,
			Delenie = 4,
            Stepen = 5            
    }

	/// <summary>
	/// Объявляем и инициализируем переменную, 
	/// которая будет использоваться для смены знака при нажатии клавиши (+/-)
	/// </summary>

		private static double peremennayaMinus = -1;

		/// <summary>
		/// Объвляем переменные, для работы калькулятора:
		/// resultatVichisleniy - переменная для хранения
		///  промежуточного результата в механизме калькулятора
		///  resultatOutput - переменная, значение которой будет сниматься с экрана и  выводиться на него.
		///  tekusheeDeystvieCalculatora - хранение одного из действия калькулятора.
		///  pervoeChislo - переменная, в которую будет записываться число на экране
		///   до нажатия на одну из четырех кнопок с действием.
		///  vtoroeChislo - второе число на экране.
		///  dobavlenierazryada при добавлении следующего  разряда эта переменная примет значение true;
		///  ChislosTochkoy при добавлении десятичного разряда (знака точки) эта переменная примет значение true
		/// </summary>
	
		private static double resultatVichisleniy;
		private static string resultatOutput;
		private static Deystvie tekusheeDeystvieCalculatora;
		private static double pervoeChislo;
		private static double vtoroeChislo;
		private static bool dobavlenierazryada;
		private static bool ChislosTochkoy;
 
		/// <summary>
		/// В конструкторе класса mehanizmcalkulyatora инициализируем переменные 
		/// ChislosTochkoy и dobavlenierazryada - при запуске калькулятора на экране 
		/// нет ни разрядности, ни десятичной части.
		/// </summary>

		public mehanizmcalkulyatora ()
		{
			ChislosTochkoy = false;
			dobavlenierazryada = false;
		}

			
		/// <summary>
		/// В этом методе переменная resultatOutput изменяется - при вводе числа ее значение перезаписывается.
		/// </summary>
		

		public static string chislonaEkrane (string najatayaKlavisha)
		{
			resultatOutput = resultatOutput + najatayaKlavisha;
			return (resultatOutput);
		}
		/// <summary>
		/// Метод, в котором определяется peremenDeystviya - одно значение перечисления Deystvie,
		///в зависимости от выбора  клавиши +, -, *,  или /
		/// </summary>
	
		public static void DeystvieCalculatora (Deystvie peremenDeystviya)
		{
			try
			{
				if (resultatOutput != "" && !dobavlenierazryada)
				{
					pervoeChislo = System.Convert.ToDouble (resultatOutput);
					tekusheeDeystvieCalculatora = peremenDeystviya;
					resultatOutput = "";
					ChislosTochkoy = false;
				}			
			}
		
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
			
			}
		}



	/// <summary>
	/// При нажатии  кнопки +/- число на экране - tekusheeChislo умножается на -1,
	///  а затем результат снова присваивается переменной resultatOutput.
	/// </summary>
	

		public static string ZnakChisla ()
		{
			double tekusheeChislo;

			if (resultatOutput != "")
			{
				tekusheeChislo = System.Convert.ToDouble (resultatOutput);
				resultatOutput = System.Convert.ToString(tekusheeChislo * peremennayaMinus);
			}
		
			return (resultatOutput);
		}

		/// <summary>
		/// При нажатии кнопки ( , ) переменная resultatOutput приобретает дробную часть.
		/// </summary>
	

		public static string ZnakTochki ()
		{
			if (!ChislosTochkoy && !dobavlenierazryada)
			{
				if (resultatOutput != "")
					resultatOutput = resultatOutput + ",";
				else
					resultatOutput = "0,";

				ChislosTochkoy = true;
			}

			return (resultatOutput);
		}

        public static string Square()
        {
            double tekusheeChislo;
            if (resultatOutput != "")
            {
                tekusheeChislo = System.Convert.ToDouble(resultatOutput);
                resultatOutput = System.Convert.ToString(Math.Sqrt(tekusheeChislo));
            }
            return resultatOutput;
        }
        public static string RevValue()
        {
            double tekusheeChislo;
            if (resultatOutput != "")
            {
                tekusheeChislo = System.Convert.ToDouble(resultatOutput);
                resultatOutput = System.Convert.ToString(1 / tekusheeChislo);
            }
            return (resultatOutput);
        }
        public static string Exponent()
        {
            double tekusheeChislo;
            if (resultatOutput != "")
            {
                tekusheeChislo = System.Convert.ToDouble(resultatOutput);
                resultatOutput = System.Convert.ToString(Math.Pow(tekusheeChislo, 2));
            }
            return (resultatOutput);
        }
        public static string Factorial()
        {
            double tekusheeChislo;
            if (resultatOutput != "")
            {
                tekusheeChislo = System.Convert.ToDouble(resultatOutput);
                
                     long factotial = 1;
                if (tekusheeChislo != 0)
                {
                    for (int i = 2; i <= tekusheeChislo; i++)
                    {
                        factotial *= i;
                    }
                }                
                resultatOutput = System.Convert.ToString(factotial);
            }
            return (resultatOutput);
        }
        public static string Cube()
        {
            double tekusheeChislo;
            if (resultatOutput != "")
            {
                tekusheeChislo = System.Convert.ToDouble(resultatOutput);
                resultatOutput = System.Convert.ToString(Math.Pow(tekusheeChislo, (1.0/3.0)));
            }
            return (resultatOutput);
        }

        

        /// <summary>
        /// При нажатии кнопки ZnakRavno обрабатываются значения 
        /// переменнных pervoeChislo и vtoroeChislo, результат присваивается переменной resultatVichisleniy 
        /// которая  затем преобразуется в resultatOutput.
        /// </summary>


        public static string ZnakRavno ()
		{
			bool proverkaOshibok = false;

			if (resultatOutput != "")
			{
				vtoroeChislo = System.Convert.ToDouble (resultatOutput);
				dobavlenierazryada = true;

				switch (tekusheeDeystvieCalculatora)
				{
					case Deystvie.NeopredelDeystvie:
						proverkaOshibok = false;
						break;

					case Deystvie.Slojenie:
						resultatVichisleniy = pervoeChislo + vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Vichitanie:
						resultatVichisleniy = pervoeChislo - vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Umnojenie:
						resultatVichisleniy = pervoeChislo * vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Delenie:
						resultatVichisleniy = pervoeChislo / vtoroeChislo;
						proverkaOshibok = true;
						break;

                    case Deystvie.Stepen:
                        resultatVichisleniy = Math.Pow(pervoeChislo, vtoroeChislo);
                        proverkaOshibok = true;
                        break;
                
                    default:
						proverkaOshibok = false;
						break;
				}

				if (proverkaOshibok)
					resultatOutput = System.Convert.ToString (resultatVichisleniy);
			}
			
			return (resultatOutput);
		}

	/// <summary>
	/// При нажатии кнопки  С (сброс) значения переменных обнуляются.
	/// </summary>

		public static void Sbros ()
		{
			resultatVichisleniy = 0;
			pervoeChislo = 0;
			vtoroeChislo = 0;
			resultatOutput = "";
			tekusheeDeystvieCalculatora = Deystvie.NeopredelDeystvie;
			ChislosTochkoy = false;
			dobavlenierazryada = false;			
		}
	}
}
