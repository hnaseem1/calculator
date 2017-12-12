namespace WindowsFormsApplication2
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scienteficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonPlusMinus = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonAddition = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonOct = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonExp = new System.Windows.Forms.Button();
            this.buttonLnx = new System.Windows.Forms.Button();
            this.buttonHex = new System.Windows.Forms.Button();
            this.buttonTan = new System.Windows.Forms.Button();
            this.buttonTanh = new System.Windows.Forms.Button();
            this.buttonInverse = new System.Windows.Forms.Button();
            this.buttonBin = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonCosh = new System.Windows.Forms.Button();
            this.buttonCube = new System.Windows.Forms.Button();
            this.buttonDec = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonSinh = new System.Windows.Forms.Button();
            this.buttonSq = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonPi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbKevin = new System.Windows.Forms.RadioButton();
            this.rbFarenToCel = new System.Windows.Forms.RadioButton();
            this.rbCelToFaren = new System.Windows.Forms.RadioButton();
            this.TempInput = new System.Windows.Forms.TextBox();
            this.TempOutput = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblShowOp = new System.Windows.Forms.Label();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.scienteficToolStripMenuItem,
            this.temperatureToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // scienteficToolStripMenuItem
            // 
            this.scienteficToolStripMenuItem.Name = "scienteficToolStripMenuItem";
            this.scienteficToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.scienteficToolStripMenuItem.Text = "Scientefic";
            this.scienteficToolStripMenuItem.Click += new System.EventHandler(this.scienteficToolStripMenuItem_Click);
            // 
            // temperatureToolStripMenuItem
            // 
            this.temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            this.temperatureToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.temperatureToolStripMenuItem.Text = "Temperature";
            this.temperatureToolStripMenuItem.Click += new System.EventHandler(this.temperatureToolStripMenuItem_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(30, 109);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(51, 49);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Del";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(30, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 41);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonCE
            // 
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.Location = new System.Drawing.Point(87, 109);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(51, 49);
            this.buttonCE.TabIndex = 3;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonPlusMinus
            // 
            this.buttonPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlusMinus.Location = new System.Drawing.Point(199, 109);
            this.buttonPlusMinus.Name = "buttonPlusMinus";
            this.buttonPlusMinus.Size = new System.Drawing.Size(51, 49);
            this.buttonPlusMinus.TabIndex = 5;
            this.buttonPlusMinus.Text = "+/-";
            this.buttonPlusMinus.UseVisualStyleBackColor = true;
            this.buttonPlusMinus.Click += new System.EventHandler(this.buttonPlusMinus_Click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(142, 109);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(51, 49);
            this.buttonC.TabIndex = 4;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonAddition
            // 
            this.buttonAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddition.Location = new System.Drawing.Point(199, 164);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(51, 49);
            this.buttonAddition.TabIndex = 9;
            this.buttonAddition.Text = "+";
            this.buttonAddition.UseVisualStyleBackColor = true;
            this.buttonAddition.Click += new System.EventHandler(this.Arithmetic_Operators);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(142, 164);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 49);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(87, 164);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 49);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(30, 164);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 49);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubtract.Location = new System.Drawing.Point(199, 219);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(51, 49);
            this.buttonSubtract.TabIndex = 13;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.Arithmetic_Operators);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(142, 219);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 49);
            this.button6.TabIndex = 12;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(87, 219);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 49);
            this.button5.TabIndex = 11;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(30, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 49);
            this.button4.TabIndex = 10;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplication.Location = new System.Drawing.Point(199, 274);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(51, 49);
            this.buttonMultiplication.TabIndex = 17;
            this.buttonMultiplication.Text = "*";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.Arithmetic_Operators);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(142, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 49);
            this.button3.TabIndex = 16;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(87, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 49);
            this.button2.TabIndex = 15;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 49);
            this.button1.TabIndex = 14;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivision.Location = new System.Drawing.Point(199, 329);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(51, 49);
            this.buttonDivision.TabIndex = 21;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.Arithmetic_Operators);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEqual.Location = new System.Drawing.Point(142, 329);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(51, 49);
            this.buttonEqual.TabIndex = 20;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecimal.Location = new System.Drawing.Point(87, 329);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(51, 49);
            this.buttonDecimal.TabIndex = 19;
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            this.buttonDecimal.Click += new System.EventHandler(this.button_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(30, 329);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(51, 49);
            this.button0.TabIndex = 18;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonPercent
            // 
            this.buttonPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPercent.Location = new System.Drawing.Point(439, 329);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(51, 49);
            this.buttonPercent.TabIndex = 41;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.buttonPercent_Click);
            // 
            // buttonOct
            // 
            this.buttonOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOct.Location = new System.Drawing.Point(382, 329);
            this.buttonOct.Name = "buttonOct";
            this.buttonOct.Size = new System.Drawing.Size(51, 49);
            this.buttonOct.TabIndex = 40;
            this.buttonOct.Text = "Oct";
            this.buttonOct.UseVisualStyleBackColor = true;
            this.buttonOct.Click += new System.EventHandler(this.buttonOct_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMod.Location = new System.Drawing.Point(327, 329);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(51, 49);
            this.buttonMod.TabIndex = 39;
            this.buttonMod.Text = "Mod";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.Arithmetic_Operators);
            // 
            // buttonExp
            // 
            this.buttonExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExp.Location = new System.Drawing.Point(270, 329);
            this.buttonExp.Name = "buttonExp";
            this.buttonExp.Size = new System.Drawing.Size(51, 49);
            this.buttonExp.TabIndex = 38;
            this.buttonExp.Text = "Exp";
            this.buttonExp.UseVisualStyleBackColor = true;
            this.buttonExp.Click += new System.EventHandler(this.Arithmetic_Operators);
            // 
            // buttonLnx
            // 
            this.buttonLnx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLnx.Location = new System.Drawing.Point(439, 274);
            this.buttonLnx.Name = "buttonLnx";
            this.buttonLnx.Size = new System.Drawing.Size(51, 49);
            this.buttonLnx.TabIndex = 37;
            this.buttonLnx.Text = "ln x";
            this.buttonLnx.UseVisualStyleBackColor = true;
            this.buttonLnx.Click += new System.EventHandler(this.buttonLnx_Click);
            // 
            // buttonHex
            // 
            this.buttonHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHex.Location = new System.Drawing.Point(382, 274);
            this.buttonHex.Name = "buttonHex";
            this.buttonHex.Size = new System.Drawing.Size(51, 49);
            this.buttonHex.TabIndex = 36;
            this.buttonHex.Text = "Hex";
            this.buttonHex.UseVisualStyleBackColor = true;
            this.buttonHex.Click += new System.EventHandler(this.buttonHex_Click);
            // 
            // buttonTan
            // 
            this.buttonTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTan.Location = new System.Drawing.Point(327, 274);
            this.buttonTan.Name = "buttonTan";
            this.buttonTan.Size = new System.Drawing.Size(51, 49);
            this.buttonTan.TabIndex = 35;
            this.buttonTan.Text = "Tan";
            this.buttonTan.UseVisualStyleBackColor = true;
            this.buttonTan.Click += new System.EventHandler(this.buttonTan_Click);
            // 
            // buttonTanh
            // 
            this.buttonTanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTanh.Location = new System.Drawing.Point(270, 274);
            this.buttonTanh.Name = "buttonTanh";
            this.buttonTanh.Size = new System.Drawing.Size(51, 49);
            this.buttonTanh.TabIndex = 34;
            this.buttonTanh.Text = "Tanh";
            this.buttonTanh.UseVisualStyleBackColor = true;
            this.buttonTanh.Click += new System.EventHandler(this.buttonTanh_Click);
            // 
            // buttonInverse
            // 
            this.buttonInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInverse.Location = new System.Drawing.Point(439, 219);
            this.buttonInverse.Name = "buttonInverse";
            this.buttonInverse.Size = new System.Drawing.Size(51, 49);
            this.buttonInverse.TabIndex = 33;
            this.buttonInverse.Text = "1/X";
            this.buttonInverse.UseVisualStyleBackColor = true;
            this.buttonInverse.Click += new System.EventHandler(this.buttonInverse_Click);
            // 
            // buttonBin
            // 
            this.buttonBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBin.Location = new System.Drawing.Point(382, 219);
            this.buttonBin.Name = "buttonBin";
            this.buttonBin.Size = new System.Drawing.Size(51, 49);
            this.buttonBin.TabIndex = 32;
            this.buttonBin.Text = "Bin";
            this.buttonBin.UseVisualStyleBackColor = true;
            this.buttonBin.Click += new System.EventHandler(this.buttonBin_Click);
            // 
            // buttonCos
            // 
            this.buttonCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCos.Location = new System.Drawing.Point(327, 219);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(51, 49);
            this.buttonCos.TabIndex = 31;
            this.buttonCos.Text = "Cos";
            this.buttonCos.UseVisualStyleBackColor = true;
            this.buttonCos.Click += new System.EventHandler(this.buttonCos_Click);
            // 
            // buttonCosh
            // 
            this.buttonCosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCosh.Location = new System.Drawing.Point(270, 219);
            this.buttonCosh.Name = "buttonCosh";
            this.buttonCosh.Size = new System.Drawing.Size(51, 49);
            this.buttonCosh.TabIndex = 30;
            this.buttonCosh.Text = "Cosh";
            this.buttonCosh.UseVisualStyleBackColor = true;
            this.buttonCosh.Click += new System.EventHandler(this.buttonCosh_Click);
            // 
            // buttonCube
            // 
            this.buttonCube.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCube.Location = new System.Drawing.Point(439, 164);
            this.buttonCube.Name = "buttonCube";
            this.buttonCube.Size = new System.Drawing.Size(51, 49);
            this.buttonCube.TabIndex = 29;
            this.buttonCube.Text = "X^3";
            this.buttonCube.UseVisualStyleBackColor = true;
            this.buttonCube.Click += new System.EventHandler(this.buttonCube_Click);
            // 
            // buttonDec
            // 
            this.buttonDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDec.Location = new System.Drawing.Point(382, 164);
            this.buttonDec.Name = "buttonDec";
            this.buttonDec.Size = new System.Drawing.Size(51, 49);
            this.buttonDec.TabIndex = 28;
            this.buttonDec.Text = "Dec";
            this.buttonDec.UseVisualStyleBackColor = true;
            this.buttonDec.Click += new System.EventHandler(this.buttonDec_Click);
            // 
            // buttonSin
            // 
            this.buttonSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSin.Location = new System.Drawing.Point(327, 164);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(51, 49);
            this.buttonSin.TabIndex = 27;
            this.buttonSin.Text = "Sin";
            this.buttonSin.UseVisualStyleBackColor = true;
            this.buttonSin.Click += new System.EventHandler(this.buttonSin_Click);
            // 
            // buttonSinh
            // 
            this.buttonSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSinh.Location = new System.Drawing.Point(270, 164);
            this.buttonSinh.Name = "buttonSinh";
            this.buttonSinh.Size = new System.Drawing.Size(51, 49);
            this.buttonSinh.TabIndex = 26;
            this.buttonSinh.Text = "Sinh";
            this.buttonSinh.UseVisualStyleBackColor = true;
            this.buttonSinh.Click += new System.EventHandler(this.buttonSinh_Click);
            // 
            // buttonSq
            // 
            this.buttonSq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSq.Location = new System.Drawing.Point(439, 109);
            this.buttonSq.Name = "buttonSq";
            this.buttonSq.Size = new System.Drawing.Size(51, 49);
            this.buttonSq.TabIndex = 25;
            this.buttonSq.Text = "X^2";
            this.buttonSq.UseVisualStyleBackColor = true;
            this.buttonSq.Click += new System.EventHandler(this.buttonSq_Click);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSqrt.Location = new System.Drawing.Point(382, 109);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(51, 49);
            this.buttonSqrt.TabIndex = 24;
            this.buttonSqrt.Text = "Sqrt";
            this.buttonSqrt.UseVisualStyleBackColor = true;
            this.buttonSqrt.Click += new System.EventHandler(this.buttonSqrt_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLog.Location = new System.Drawing.Point(327, 109);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(51, 49);
            this.buttonLog.TabIndex = 23;
            this.buttonLog.Text = "Log";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonPi
            // 
            this.buttonPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPi.Location = new System.Drawing.Point(270, 109);
            this.buttonPi.Name = "buttonPi";
            this.buttonPi.Size = new System.Drawing.Size(51, 49);
            this.buttonPi.TabIndex = 22;
            this.buttonPi.Text = "π";
            this.buttonPi.UseVisualStyleBackColor = true;
            this.buttonPi.Click += new System.EventHandler(this.buttonPi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.TempInput);
            this.groupBox1.Controls.Add(this.TempOutput);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.buttonConvert);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(508, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 336);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperature";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.rbKevin);
            this.groupBox2.Controls.Add(this.rbFarenToCel);
            this.groupBox2.Controls.Add(this.rbCelToFaren);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(6, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 153);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Select Temperature For Conversion";
            // 
            // rbKevin
            // 
            this.rbKevin.AutoSize = true;
            this.rbKevin.Location = new System.Drawing.Point(13, 110);
            this.rbKevin.Name = "rbKevin";
            this.rbKevin.Size = new System.Drawing.Size(71, 22);
            this.rbKevin.TabIndex = 5;
            this.rbKevin.TabStop = true;
            this.rbKevin.Text = "Kelvin";
            this.rbKevin.UseVisualStyleBackColor = true;
            this.rbKevin.CheckedChanged += new System.EventHandler(this.rbKevin_CheckedChanged);
            // 
            // rbFarenToCel
            // 
            this.rbFarenToCel.AutoSize = true;
            this.rbFarenToCel.Location = new System.Drawing.Point(13, 76);
            this.rbFarenToCel.Name = "rbFarenToCel";
            this.rbFarenToCel.Size = new System.Drawing.Size(73, 22);
            this.rbFarenToCel.TabIndex = 4;
            this.rbFarenToCel.TabStop = true;
            this.rbFarenToCel.Text = "F to C";
            this.rbFarenToCel.UseVisualStyleBackColor = true;
            this.rbFarenToCel.CheckedChanged += new System.EventHandler(this.rbFarenToCel_CheckedChanged);
            // 
            // rbCelToFaren
            // 
            this.rbCelToFaren.AutoSize = true;
            this.rbCelToFaren.Location = new System.Drawing.Point(13, 37);
            this.rbCelToFaren.Name = "rbCelToFaren";
            this.rbCelToFaren.Size = new System.Drawing.Size(73, 22);
            this.rbCelToFaren.TabIndex = 3;
            this.rbCelToFaren.TabStop = true;
            this.rbCelToFaren.Text = "C to F";
            this.rbCelToFaren.UseVisualStyleBackColor = true;
            this.rbCelToFaren.CheckedChanged += new System.EventHandler(this.rbCelToFaren_CheckedChanged);
            // 
            // TempInput
            // 
            this.TempInput.Location = new System.Drawing.Point(246, 38);
            this.TempInput.Name = "TempInput";
            this.TempInput.Size = new System.Drawing.Size(95, 29);
            this.TempInput.TabIndex = 49;
            // 
            // TempOutput
            // 
            this.TempOutput.Location = new System.Drawing.Point(246, 239);
            this.TempOutput.Name = "TempOutput";
            this.TempOutput.Size = new System.Drawing.Size(95, 29);
            this.TempOutput.TabIndex = 48;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(246, 287);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(95, 37);
            this.buttonReset.TabIndex = 47;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(6, 287);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(95, 37);
            this.buttonConvert.TabIndex = 46;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "Enter Value To Convert";
            // 
            // lblShowOp
            // 
            this.lblShowOp.AutoSize = true;
            this.lblShowOp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblShowOp.Location = new System.Drawing.Point(39, 60);
            this.lblShowOp.Name = "lblShowOp";
            this.lblShowOp.Size = new System.Drawing.Size(0, 13);
            this.lblShowOp.TabIndex = 43;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 391);
            this.Controls.Add(this.lblShowOp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonOct);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.buttonExp);
            this.Controls.Add(this.buttonLnx);
            this.Controls.Add(this.buttonHex);
            this.Controls.Add(this.buttonTan);
            this.Controls.Add(this.buttonTanh);
            this.Controls.Add(this.buttonInverse);
            this.Controls.Add(this.buttonBin);
            this.Controls.Add(this.buttonCos);
            this.Controls.Add(this.buttonCosh);
            this.Controls.Add(this.buttonCube);
            this.Controls.Add(this.buttonDec);
            this.Controls.Add(this.buttonSin);
            this.Controls.Add(this.buttonSinh);
            this.Controls.Add(this.buttonSq);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonPi);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonAddition);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonPlusMinus);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scienteficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureToolStripMenuItem;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonPlusMinus;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonAddition;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonOct;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonExp;
        private System.Windows.Forms.Button buttonLnx;
        private System.Windows.Forms.Button buttonHex;
        private System.Windows.Forms.Button buttonTan;
        private System.Windows.Forms.Button buttonTanh;
        private System.Windows.Forms.Button buttonInverse;
        private System.Windows.Forms.Button buttonBin;
        private System.Windows.Forms.Button buttonCos;
        private System.Windows.Forms.Button buttonCosh;
        private System.Windows.Forms.Button buttonCube;
        private System.Windows.Forms.Button buttonDec;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonSinh;
        private System.Windows.Forms.Button buttonSq;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonPi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TempInput;
        private System.Windows.Forms.TextBox TempOutput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbKevin;
        private System.Windows.Forms.RadioButton rbFarenToCel;
        private System.Windows.Forms.RadioButton rbCelToFaren;
        private System.Windows.Forms.Label lblShowOp;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

