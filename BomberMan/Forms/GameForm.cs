using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace BomberMan
{
    public partial class Game : Form
    {
        readonly Timer time = new Timer();
        List<Control> Box;
        List<Control> Wall;
        Map map; 
        Player player; Enemy Enemy;
        int position, Size;
        public Game(string Playername)
        {
            InitializeComponent();
            Enemy = new Enemy();
            player = new Player(Playername);
            Init();
        }

        void Init()
        {
            this.Focus();
            position = 100;
                Size = 800;
            CreateMap();
            Box = new List<Control>();
            Wall = new List<Control>();
            foreach (Control items in this.Controls)
            {
                if (items is PictureBox && (string)items.Tag == "Wall")
                {
                    Wall.Add(items);
                }
                else if (items is PictureBox && (string)items.Tag == "Box")
                {
                    Box.Add(items);
                }
            }
            // The duration of creating a loop, where 1000 is 1 second. and every Interval will do update
            time.Interval = 35;
            time.Tick += Update;
            time.Start();

        }
        void ResizeForm(Form BrforeFormResize,Map AfterFormResize) 
        {
            int x = AfterFormResize.MapProperties.Location.X - BrforeFormResize.Location.X;
            int y = AfterFormResize.MapProperties.Location.Y - BrforeFormResize.Location.Y;
            while (AfterFormResize.MapProperties.Width %10 != 0)
            {
                AfterFormResize.MapProperties.Width += 1;
            }
            while (AfterFormResize.MapProperties.Height % 10 != 0)
            {
                AfterFormResize.MapProperties.Height += 1;
            }
            while ( (BrforeFormResize.Width < AfterFormResize.MapProperties.Width + x))
            {
                BrforeFormResize.Width += 1;
            }
            while ((BrforeFormResize.Height < AfterFormResize.MapProperties.Height + y))
            {
                BrforeFormResize.Height += 1;
            }
            Console.WriteLine($"{AfterFormResize.MapProperties.Location.X- BrforeFormResize.Location.X }");
            Console.WriteLine($"{AfterFormResize.MapProperties.Location.Y - BrforeFormResize.Location.Y }");
            Console.WriteLine($"{ BrforeFormResize.Height-AfterFormResize.MapProperties.Height}");
            Console.WriteLine($"{ BrforeFormResize.Width - AfterFormResize.MapProperties.Width}");
            Console.WriteLine($"{BrforeFormResize.Width} :{ AfterFormResize.MapProperties.Width}");
            Console.WriteLine($"{BrforeFormResize.Height} :{ AfterFormResize.MapProperties.Height}");

        }
        void CreateMap() 
        {
            
            map = new Map(DecorateImage.Blackboard, new Size(Size, Size),new Point(position,position));
            map.Add(this);
            map.AddPicture(player.Character);
            player.Character.BackColor = Color.Transparent;
            ResizeForm(this, map);
        }
        void Update(object sender, EventArgs a)
        {
                
        }

    }
}
