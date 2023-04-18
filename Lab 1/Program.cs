namespace Lab_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			Console.WriteLine("Hello, World!");
			Stapler stapler = new Stapler(50,15,"Red",false,false);
			int counter = 50;
			//goto test;
			while (counter > 0)
			{
				counter--;
				stapler.staple();
				Console.WriteLine(stapler.Staples.ToString());
				Thread.Sleep(100);
			}
			stapler.reload();
			counter = 50;
			while (counter > 0)
			{
				counter--;
				stapler.staple();
				Console.WriteLine(stapler.Staples.ToString());
				Thread.Sleep(100);
			}
			Notebook diary = new Notebook("Diary", new List<string>());
			counter = 5;
			while (counter > 0)
			{
				counter--;
				try
				{
					diary.Pages.Add(Console.ReadLine());
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex);
				}
			}
			counter = 5;
			while (counter > 0)
			{
				counter--;
				try
				{
					Console.WriteLine(diary.Pages[counter]);
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex);
				}
			}
			//test:
			Umbrella umbrella = new Umbrella();
			counter = 26;
			while (counter > 0)
			{
				counter--;
				umbrella.ToggleOpen();
				Console.WriteLine(umbrella.Open.ToString());
				Thread.Sleep(10 + (counter * 10));
			}
			Console.WriteLine($"The umbrella flew away...");
		}
	}

	public class Stapler
	{
		int _maxStaples;
		int _staples;
		string _color;
		bool _open;
		bool _stapleMode;

		public Stapler(int maxStaples, int staples, string color, bool open, bool stapleMode)
		{
			_maxStaples = maxStaples;
			_staples = staples;
			_color = color;
			_open = open;
			_stapleMode = stapleMode;
		}
		public void staple()
		{
			if (_staples > 0)
			{
				_staples--;
			}
			else
			{
				Console.WriteLine("Out of staples!");
			}
		}
		public void reload()
		{
			_staples = _maxStaples;
			Console.WriteLine("Reloaded stapler!");
		}
		public int Staples { get => _staples; set => _staples = value; }
		public string Color { get => _color; set => _color = value; }
		public bool Open { get => _open; set => _open = value; }
		public bool StapleMode { get => _stapleMode; set => _stapleMode = value; }
	}

	public class PostIt
	{
		private string _text;
		private string _color;

		public PostIt(string text, string color)
		{
			_text = text;
			_color = color;
		}

		public string Text { get => _text; set => _text = value; }
		public string Color { get => _color; set => _color = value; }
	}

	public class GuitarPick
	{
		string _color;
		float _thickness;
		float _lenth;

		public GuitarPick(string color, float thickness, float lenth)
		{
			_color = color;
			_thickness = thickness;
			_lenth = lenth;
		}

		public string Color { get => _color; set => _color = value; }
		public float Thickness { get => _thickness; set => _thickness = value; }
		public float Lenth { get => _lenth; set => _lenth = value; }
	}

	public class Notebook
	{
		string title;
		List<string> pages = new List<string>();

		public Notebook(string title, List<string> pages)
		{
			this.title = title;
			this.pages = pages;
		}

		public string Title { get => title; set => title = value; }
		public List<string> Pages { get => pages; set => pages = value; }
	}

	public class Umbrella
	{
		bool _open = false;

		public string Open { get {if (_open == true)
				{
					return "Open";
				}
				else 
				{
					return "Closed";
				}
			} }

		public void ToggleOpen()
		{
			_open = !_open;
		}

	}
}