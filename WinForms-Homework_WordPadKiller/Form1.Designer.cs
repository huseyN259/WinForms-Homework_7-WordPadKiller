namespace WinForms_Homework_WordPadKiller;

partial class Form1
{
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
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
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cbox_Fonts = new System.Windows.Forms.ComboBox();
			this.cbox_Sizes = new System.Windows.Forms.ComboBox();
			this.cbox_Colors = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.btn_Bold = new System.Windows.Forms.Button();
			this.btn_Underline = new System.Windows.Forms.Button();
			this.btn_Italic = new System.Windows.Forms.Button();
			this.btn_Left = new System.Windows.Forms.Button();
			this.btn_Right = new System.Windows.Forms.Button();
			this.btn_Center = new System.Windows.Forms.Button();
			this.btn_Load = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(113, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Font";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(328, 21);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 31);
			this.label2.TabIndex = 1;
			this.label2.Text = "Size";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(468, 21);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 31);
			this.label3.TabIndex = 2;
			this.label3.Text = "FontStyle";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(719, 21);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 31);
			this.label4.TabIndex = 3;
			this.label4.Text = "Alignment";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(979, 21);
			this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 31);
			this.label5.TabIndex = 4;
			this.label5.Text = "Color";
			// 
			// cbox_Fonts
			// 
			this.cbox_Fonts.FormattingEnabled = true;
			this.cbox_Fonts.Location = new System.Drawing.Point(12, 62);
			this.cbox_Fonts.Margin = new System.Windows.Forms.Padding(5);
			this.cbox_Fonts.Name = "cbox_Fonts";
			this.cbox_Fonts.Size = new System.Drawing.Size(290, 39);
			this.cbox_Fonts.TabIndex = 5;
			this.cbox_Fonts.SelectedIndexChanged += new System.EventHandler(this.cbox_Fonts_SelectedIndexChanged);
			// 
			// cbox_Sizes
			// 
			this.cbox_Sizes.FormattingEnabled = true;
			this.cbox_Sizes.Location = new System.Drawing.Point(312, 62);
			this.cbox_Sizes.Margin = new System.Windows.Forms.Padding(5);
			this.cbox_Sizes.Name = "cbox_Sizes";
			this.cbox_Sizes.Size = new System.Drawing.Size(88, 39);
			this.cbox_Sizes.TabIndex = 6;
			this.cbox_Sizes.SelectedIndexChanged += new System.EventHandler(this.cbox_Sizes_SelectedIndexChanged);
			// 
			// cbox_Colors
			// 
			this.cbox_Colors.FormattingEnabled = true;
			this.cbox_Colors.Location = new System.Drawing.Point(935, 64);
			this.cbox_Colors.Margin = new System.Windows.Forms.Padding(5);
			this.cbox_Colors.Name = "cbox_Colors";
			this.cbox_Colors.Size = new System.Drawing.Size(186, 39);
			this.cbox_Colors.TabIndex = 7;
			this.cbox_Colors.SelectedIndexChanged += new System.EventHandler(this.cbox_Colors_SelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(1183, 9);
			this.textBox1.Margin = new System.Windows.Forms.Padding(5);
			this.textBox1.Name = "textBox1";
			this.textBox1.PlaceholderText = "Enter name and load file";
			this.textBox1.Size = new System.Drawing.Size(347, 38);
			this.textBox1.TabIndex = 8;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(1183, 65);
			this.textBox2.Margin = new System.Windows.Forms.Padding(5);
			this.textBox2.Name = "textBox2";
			this.textBox2.PlaceholderText = "Save";
			this.textBox2.Size = new System.Drawing.Size(347, 38);
			this.textBox2.TabIndex = 9;
			// 
			// btn_Bold
			// 
			this.btn_Bold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_Bold.Location = new System.Drawing.Point(424, 62);
			this.btn_Bold.Margin = new System.Windows.Forms.Padding(5);
			this.btn_Bold.Name = "btn_Bold";
			this.btn_Bold.Size = new System.Drawing.Size(62, 39);
			this.btn_Bold.TabIndex = 10;
			this.btn_Bold.Text = "B";
			this.btn_Bold.UseVisualStyleBackColor = true;
			this.btn_Bold.Click += new System.EventHandler(this.btn_Bold_Click);
			// 
			// btn_Underline
			// 
			this.btn_Underline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
			this.btn_Underline.Location = new System.Drawing.Point(496, 62);
			this.btn_Underline.Margin = new System.Windows.Forms.Padding(5);
			this.btn_Underline.Name = "btn_Underline";
			this.btn_Underline.Size = new System.Drawing.Size(62, 39);
			this.btn_Underline.TabIndex = 11;
			this.btn_Underline.Text = "U";
			this.btn_Underline.UseVisualStyleBackColor = true;
			this.btn_Underline.Click += new System.EventHandler(this.btn_Underline_Click);
			// 
			// btn_Italic
			// 
			this.btn_Italic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.btn_Italic.Location = new System.Drawing.Point(567, 62);
			this.btn_Italic.Margin = new System.Windows.Forms.Padding(5);
			this.btn_Italic.Name = "btn_Italic";
			this.btn_Italic.Size = new System.Drawing.Size(62, 39);
			this.btn_Italic.TabIndex = 12;
			this.btn_Italic.Text = "I";
			this.btn_Italic.UseVisualStyleBackColor = true;
			this.btn_Italic.Click += new System.EventHandler(this.btn_Italic_Click);
			// 
			// btn_Left
			// 
			this.btn_Left.Location = new System.Drawing.Point(668, 62);
			this.btn_Left.Margin = new System.Windows.Forms.Padding(5);
			this.btn_Left.Name = "btn_Left";
			this.btn_Left.Size = new System.Drawing.Size(72, 39);
			this.btn_Left.TabIndex = 13;
			this.btn_Left.Text = "L";
			this.btn_Left.UseVisualStyleBackColor = true;
			this.btn_Left.Click += new System.EventHandler(this.btn_Left_Click);
			// 
			// btn_Right
			// 
			this.btn_Right.Location = new System.Drawing.Point(830, 62);
			this.btn_Right.Margin = new System.Windows.Forms.Padding(5);
			this.btn_Right.Name = "btn_Right";
			this.btn_Right.Size = new System.Drawing.Size(72, 39);
			this.btn_Right.TabIndex = 14;
			this.btn_Right.Text = "R";
			this.btn_Right.UseVisualStyleBackColor = true;
			this.btn_Right.Click += new System.EventHandler(this.btn_Right_Click);
			// 
			// btn_Center
			// 
			this.btn_Center.Location = new System.Drawing.Point(749, 62);
			this.btn_Center.Margin = new System.Windows.Forms.Padding(5);
			this.btn_Center.Name = "btn_Center";
			this.btn_Center.Size = new System.Drawing.Size(72, 39);
			this.btn_Center.TabIndex = 15;
			this.btn_Center.Text = "C";
			this.btn_Center.UseVisualStyleBackColor = true;
			this.btn_Center.Click += new System.EventHandler(this.btn_Center_Click);
			// 
			// btn_Load
			// 
			this.btn_Load.Location = new System.Drawing.Point(1566, 6);
			this.btn_Load.Margin = new System.Windows.Forms.Padding(5);
			this.btn_Load.Name = "btn_Load";
			this.btn_Load.Size = new System.Drawing.Size(138, 46);
			this.btn_Load.TabIndex = 16;
			this.btn_Load.Text = "Load";
			this.btn_Load.UseVisualStyleBackColor = true;
			this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(1566, 62);
			this.btn_Save.Margin = new System.Windows.Forms.Padding(5);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(138, 45);
			this.btn_Save.TabIndex = 17;
			this.btn_Save.Text = "Save";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 137);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(1707, 522);
			this.richTextBox1.TabIndex = 18;
			this.richTextBox1.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1720, 671);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.btn_Load);
			this.Controls.Add(this.btn_Center);
			this.Controls.Add(this.btn_Right);
			this.Controls.Add(this.btn_Left);
			this.Controls.Add(this.btn_Italic);
			this.Controls.Add(this.btn_Underline);
			this.Controls.Add(this.btn_Bold);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.cbox_Colors);
			this.Controls.Add(this.cbox_Sizes);
			this.Controls.Add(this.cbox_Fonts);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Form1";
			this.Text = "WordPad";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

	}

	#endregion

	private Label label1;
	private Label label2;
	private Label label3;
	private Label label4;
	private Label label5;
	private ComboBox cbox_Fonts;
	private ComboBox cbox_Sizes;
	private ComboBox cbox_Colors;
	private TextBox textBox1;
	private TextBox textBox2;
	private Button btn_Bold;
	private Button btn_Underline;
	private Button btn_Italic;
	private Button btn_Left;
	private Button btn_Right;
	private Button btn_Center;
	private Button btn_Load;
	private Button btn_Save;
	private RichTextBox richTextBox1;
}