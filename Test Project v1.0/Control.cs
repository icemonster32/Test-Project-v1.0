using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project_v1._0
{
    internal class Control
    {
        static bool isMax = false, isFull = false;
        static Point old_loc, default_loc;
        static Size old_size, default_size;

        public static void SetIntial(Form form) //this method should fire when app starts
        {
            old_loc = form.Location;
            old_size = form.Size;
            default_loc = form.Location;
            default_size = form.Size;
        }

        public static void DoMaximize(Form form, Button Maxbtn)
        {
            if (isMax == false) // app not maximized ; then MAXIMIZED IT!
            {
                old_loc = new Point(form.Location.X, form.Location.Y);
                old_size = new Size(form.Size.Width, form.Size.Height);
                Maximize(form);
                isMax = true;
                isFull = false;
                Maxbtn.Text = "2";
            }

            else // app is currently maximed; then make it normal!
            {
                if (old_size.Width >= SystemInformation.WorkingArea.Width || old_size.Height >= SystemInformation.WorkingArea.Height)
                {
                    form.Location = default_loc;
                    form.Size = default_size;
                }
                else
                {
                    form.Location = old_loc;
                    form.Size = old_size;
                }
                isMax = false;
                isFull = false;
                Maxbtn.Text = "1";
            }
        }

        static void Maximize(Form form)
        {
            int x = SystemInformation.WorkingArea.Width;
            int y = SystemInformation.WorkingArea.Height;
            form.WindowState = FormWindowState.Normal;
            form.Location = new Point(0, 0);
            form.Size = new Size(x, y);
        }

        public static void Minimize(Form form)
        {
            if (form.WindowState == FormWindowState.Minimized)
                form.WindowState = FormWindowState.Normal;
            else if (form.WindowState == FormWindowState.Normal)
                form.WindowState = FormWindowState.Minimized;
        }

        public static void Exit()
        {
            Application.Exit();
        }
    }
}
