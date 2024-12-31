using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;
//using System.Threading.Tasks;


namespace AutoWindowsSize
{
    class AutoAdaptWindowsSize
    {
        double formOriginalWidth;
        double formOriginalHeight;
        double scaleX;
        double scaleY;
        Dictionary<string, string> ControlsInfo = new Dictionary<string, string>();

        private Form _form;
        Panel Win_Panel1 = new Panel();

        public AutoAdaptWindowsSize(Form form)
        {
            _form = form;

            _form.Controls.Add(Win_Panel1);
            Win_Panel1.BorderStyle = BorderStyle.None;
            Win_Panel1.Dock = DockStyle.Fill;
            Win_Panel1.BackColor = Color.Transparent;

            while (_form.Controls[0].Name.Trim() != "")
            {
                foreach (Control item in _form.Controls)
                {
                    if (item.Name.Trim() != "" && item.Name.Trim() != Win_Panel1.Name.Trim())
                    {
                        Win_Panel1.Controls.Add(item);
                    }
                }
            }

            InitControlsInfo(Win_Panel1);
        }

        public void InitControlsInfo(Control ctrlContainer)
        {
            if (ctrlContainer.Parent == _form)
            {
                formOriginalWidth = Convert.ToDouble(ctrlContainer.Width);
                formOriginalHeight = Convert.ToDouble(ctrlContainer.Height);
            }
            foreach (Control item in ctrlContainer.Controls)
            {
                if (item.Name.Trim() != "")
                {
                    ControlsInfo.Add(item.Name, (item.Left + item.Width / 2) + "," + (item.Top + item.Height / 2) + "," + item.Width + "," + item.Height + "," + item.Font.Size);
                }
                if (!(item is UserControl) && item.Controls.Count > 0)
                {
                    InitControlsInfo(item);
                }
            }
        }

        public void FormSizeChanged()
        {
            try
            {
                if (ControlsInfo.Count > 0)
                {
                    ControlsZoomScale(Win_Panel1);
                    ControlsChange(Win_Panel1);
                }
            }
            catch { }
        }

        private void ControlsZoomScale(Control ctrlContainer)
        {
            scaleX = (Convert.ToDouble(ctrlContainer.Width) / formOriginalWidth);
            scaleY = (Convert.ToDouble(ctrlContainer.Height) / formOriginalHeight);
        }

        private void ControlsChange(Control ctrlContainer)
        {
            double[] pos = new double[5];
            foreach (Control item in ctrlContainer.Controls)
            {
                if (item.Name.Trim() != "")
                {
                    if (!(item is UserControl) && item.Controls.Count > 0)
                    {
                        ControlsChange(item);
                    }
                    string[] strs = ControlsInfo[item.Name].Split(',');

                    for (int i = 0; i < 5; i++)
                    {
                        pos[i] = Convert.ToDouble(strs[i]);
                    }
                    double itemWidth = pos[2] * scaleX;
                    double itemHeight = pos[3] * scaleY;
                    item.Left = Convert.ToInt32(pos[0] * scaleX - itemWidth / 2);
                    item.Top = Convert.ToInt32(pos[1] * scaleY - itemHeight / 2);
                    item.Width = Convert.ToInt32(itemWidth);
                    item.Height = Convert.ToInt32(itemHeight);
                    if (float.Parse((pos[4] * Math.Min(scaleX, scaleY)).ToString()) != 0)
                    {
                        item.Font = new Font(item.Font.Name, float.Parse((pos[4] * Math.Min(scaleX, scaleY)).ToString()));
                    }
                }
            }
        }
    }
}