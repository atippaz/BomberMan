using System.Windows.Forms;
namespace BomberMan
{
    static class KeyBoard
    {
       public static bool CheckAll(KeyEventArgs e)
        {
            return Left(e) || Right(e) || Down(e) || Up(e);
        }
        public static bool Left(KeyEventArgs e)
        {
            return (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) ? true : false;
        }
        public static bool Down(KeyEventArgs e)
        {
            return (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) ? true : false;
        }
        public static bool Right(KeyEventArgs e)
        {
            return (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) ? true : false;
        }
        public static bool Up(KeyEventArgs e)
        {
            return (e.KeyCode == Keys.W || e.KeyCode == Keys.Up) ? true : false;
        }
    }
}
