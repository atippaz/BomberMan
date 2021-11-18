using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BomberMan
{
    static class FormEditor
    {
        static public void Resize(Form ThisForm) 
        {
            int WidthBF = Storages.Map.MapProperties.Location.X - ThisForm.Location.X;
            int HeightBF = Storages.Map.MapProperties.Location.Y - ThisForm.Location.Y;
            int WidthAT = ThisForm.Width;
            int HeightAT = ThisForm.Height;
            if (ThisForm.Size.Width < Storages.Map.MapProperties.Width || ThisForm.Size.Height < Storages.Map.MapProperties.Height)
            {
                while ((WidthAT <= Storages.Map.MapProperties.Width + WidthBF + 120))
                {
                    WidthAT += 1;
                }
                while ((HeightAT <= Storages.Map.MapProperties.Height + HeightBF + 200))
                {
                    HeightAT += 1;
                }
            }
            else
            {
                while ((WidthAT >= Storages.Map.MapProperties.Width + WidthBF + 120))
                {
                    WidthAT -= 1;
                }
                while ((HeightAT >= Storages.Map.MapProperties.Height + HeightBF + 120))
                {
                    HeightAT -= 1;
                }
            }
            ThisForm.Width = WidthAT;
            ThisForm.Height = HeightAT;
            ThisForm.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
