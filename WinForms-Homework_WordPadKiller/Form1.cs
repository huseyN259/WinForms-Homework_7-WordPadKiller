namespace WinForms_Homework_WordPadKiller;

public partial class Form1 : Form
{
	List<string> fonts = new() { "Arial Rounded MT", "Cooper", "Georgia", "Latin", "Mistral", "Times New Roman" };
	List<string> sizes = new() { "8", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28" };
	List<Color> colors = new() { Color.Black, Color.Aquamarine, Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.DeepPink, Color.Purple, Color.Goldenrod, Color.LightSalmon };
	
	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		cbox_Fonts.DataSource = fonts;
		cbox_Sizes.DataSource = sizes;
		cbox_Colors.DataSource = colors;
		richTextBox1.ForeColor = Color.Black;
	}

	bool isClickedBold = false;
	int clickCountBold = 0;
	bool isClickedItalic = false;
	int clickCountItalic = 0;
	bool isClickedUnderline = false;
	int clickCountUnderline = 0;

	private void btn_Bold_Click(object sender, EventArgs e)
	{
		isClickedBold = true;
		if (isClickedBold && clickCountBold == 0)
		{
			var font = cbox_Fonts.SelectedItem as string;
			var size = cbox_Sizes.SelectedItem as string;
			var currentFontStyle = richTextBox1.SelectionFont.Style;

			Font f = new(font, float.Parse(size), currentFontStyle | FontStyle.Bold);
			richTextBox1.SelectionFont = f;
			
			clickCountBold++;
		}
		else if (clickCountBold == 1)
		{
			var font = cbox_Fonts.SelectedItem as string;
			var size = cbox_Sizes.SelectedItem as string;
			var currentFontStyle = richTextBox1.SelectionFont.Style;

			Font f = new(font, float.Parse(size), (FontStyle)(currentFontStyle - FontStyle.Bold));
			richTextBox1.SelectionFont = f;
			
			clickCountBold--;
		}
	}

	private void btn_Italic_Click(object sender, EventArgs e)
	{
		isClickedItalic = true;
		if (isClickedItalic && clickCountItalic == 0)
		{
			var font = cbox_Fonts.SelectedItem as string;
			var size = cbox_Sizes.SelectedItem as string;
			var currentFontStyle = richTextBox1.SelectionFont.Style;

			Font f = new(font, float.Parse(size), currentFontStyle | FontStyle.Italic);
			richTextBox1.SelectionFont = f;

			clickCountItalic++;
		}
		else if (clickCountItalic == 1)
		{
			var font = cbox_Fonts.SelectedItem as string;
			var size = cbox_Sizes.SelectedItem as string;
			var currentFontStyle = richTextBox1.SelectionFont.Style;

			Font f = new(font, float.Parse(size), (FontStyle)(currentFontStyle - FontStyle.Italic));
			richTextBox1.SelectionFont = f;

			clickCountItalic--;
		}
	}

	private void btn_Underline_Click(object sender, EventArgs e)
	{
		isClickedUnderline = true;
		if (isClickedUnderline && clickCountUnderline == 0)
		{
			var font = cbox_Fonts.SelectedItem as string;
			var size = cbox_Sizes.SelectedItem as string;
			var currentFontStyle = richTextBox1.SelectionFont.Style;

			Font f = new(font, float.Parse(size), currentFontStyle | FontStyle.Underline);
			richTextBox1.SelectionFont = f;
			
			clickCountUnderline++;
		}
		else if (clickCountUnderline == 1)
		{
			var font = cbox_Fonts.SelectedItem as string;
			var size = cbox_Sizes.SelectedItem as string;
			var currentFontStyle = richTextBox1.SelectionFont.Style;

			Font f = new(font, float.Parse(size), (FontStyle)(currentFontStyle - FontStyle.Underline));
			richTextBox1.SelectionFont = f;
			
			clickCountUnderline--;
		}
	}

	private void btn_Left_Click(object sender, EventArgs e)
	{
		richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
	}

	private void btn_Center_Click(object sender, EventArgs e)
	{
		richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
	}

	private void btn_Right_Click(object sender, EventArgs e)
	{
		richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
	}

	private void cbox_Colors_SelectedIndexChanged(object sender, EventArgs e)
	{
		var index = cbox_Colors.SelectedIndex;
		richTextBox1.SelectionColor = colors[index];
	}

	private void cbox_Fonts_SelectedIndexChanged(object sender, EventArgs e)
	{
		var font = cbox_Fonts.SelectedItem as string;
		var size = cbox_Sizes.SelectedItem as string;

		if (size != null)
		{
			Font f = new(Name = font, float.Parse(size));
			richTextBox1.SelectionFont = f;
		}
	}
	
	private void cbox_Sizes_SelectedIndexChanged(object sender, EventArgs e)
	{
		var font = cbox_Fonts.SelectedItem as string;
		var size = cbox_Sizes.SelectedItem as string;
		var currentFontStyle = richTextBox1.SelectionFont.Style;

		Font f = new(Name = font, float.Parse(size), currentFontStyle);
		richTextBox1.SelectionFont = f;
	}

	private void btn_Load_Click(object sender, EventArgs e)
	{
		var fileName = textBox1.Text;
		richTextBox1.Rtf = File.ReadAllText($"{fileName}.txt");
		textBox1.Text = null;
	}

	private void btn_Save_Click(object sender, EventArgs e)
	{
		var fileName = textBox2.Text;
		File.WriteAllText($"{fileName}.txt", richTextBox1.Rtf);
		richTextBox1.Text = null;
		textBox2.Text = null;
	}
}