using System;
using System.Threading;
using System.Windows.Forms;

class AnimateForm
{
    ///<summary>
    ///Resize form. Params: width, height, and speed (1 recommended)
    ///</summary>
    public static void AnimateResize(Form f, Int16 w, Int16 h, int s)
    {
        f.WindowState = FormWindowState.Normal;
        if (f.Width < w && f.Height < h)
        {
            for (int i = 0; i < 2; i++)
            {
                Thread.Sleep(s);
                if (f.Width < w)
                {
                    f.Width += 1;
                    i = 0;
                }
                if (f.Height < h)
                {
                    f.Height += 1;
                    i = 0;
                }
                if (f.Height == h && f.Width == w)
                {
                    i = 1;
                }
            }
        }
        if (f.Width > w && f.Height < h)
        {
            for (int i = 0; i < 2; i++)
            {
                Thread.Sleep(s);
                if (f.Width > w)
                {
                    f.Width -= 1;
                    i = 0;
                }
                if (f.Height < h)
                {
                    f.Height += 1;
                    i = 0;
                }
                if (f.Height == h && f.Width == w)
                {
                    i = 1;
                }
            }
        }
        if (f.Width < w && f.Height > h)
        {
            for (int i = 0; i < 2; i++)
            {
                Thread.Sleep(s);
                if (f.Width < w)
                {
                    f.Width += 1;
                    i = 0;
                }
                if (f.Height > h)
                {
                    f.Height -= 1;
                    i = 0;
                }
                if (f.Height == h && f.Width == w)
                {
                    i = 1;
                }
            }
        }
        if (f.Width > w && f.Height > h)
        {
            for (int i = 0; i < 2; i++)
            {
                Thread.Sleep(s);
                if (f.Width > w)
                {
                    f.Width -= 1;
                    i = 0;
                }
                if (f.Height > h)
                {
                    f.Height -= 1;
                    i = 0;
                }
                if (f.Height == h && f.Width == w)
                {
                    i = 1;
                }
            }
            if (f.Width == w && f.Height > h)
            {
                for (int i = 0; i < 2; i++)
                {
                    Thread.Sleep(s);
                    if (f.Height > h)
                    {
                        f.Height -= 1;
                        i = 0;
                    }
                    if (f.Height == h && f.Width == w)
                    {
                        i = 1;
                    }
                }
            }
            if (f.Height == h && f.Width < w)
            {
                for (int i = 0; i < 2; i++)
                {
                    Thread.Sleep(s);
                    if (f.Height > h)
                    {
                        f.Height -= 1;
                        i = 0;
                    }
                    if (f.Height == h && f.Width == w)
                    {
                        i = 1;
                    }
                }
            }
            if (f.Width == w && f.Height < h)
            {
                for (int i = 0; i < 2; i++)
                {
                    Thread.Sleep(s);
                    if (f.Height > h)
                    {
                        f.Height -= 1;
                        i = 0;
                    }
                    if (f.Height == h && f.Width == w)
                    {
                        i = 1;
                    }
                }
            }
            if (f.Height == h && f.Width > w)
            {
                for (int i = 0; i < 2; i++)
                {
                    Thread.Sleep(s);
                    if (f.Height > h)
                    {
                        f.Height -= 1;
                        i = 0;
                    }
                    if (f.Height == h && f.Width == w)
                    {
                        i = 1;
                    }
                }
            }
        }
    }
}
