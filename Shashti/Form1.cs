using Shashti.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shashti
{
    public partial class Form1 : Form
    {
        private int _x;
        private int _y;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this._getScreenResolution();
            this._updateLabelValues();
        }

        private void picboxRefresh_Click(object sender, EventArgs e)
        {
            this._getScreenResolution();
            this._updateLabelValues();
        }

        // Private Methods

        private void _getScreenResolution()
        {
            this._x = clsScreen.getScreenX();
            this._y = clsScreen.getScreenY();
        }

        private void _updateLabelValues()
        {
            this.lblX.Text = _x.ToString();
            this.lblY.Text = _y.ToString();
        }


    }
}
