using mvp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mvp.Views
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> AddEventHandler { get; set; }

        public EventHandler<EventArgs> LoadEventHandler { get; set; }

        public string VendorText
        {
            get => txtBoxVendor.Text;
            set => txtBoxVendor.Text = value;
        }

        public string ModelText
        {
            get => txtBoxModel.Text;
            set => txtBoxModel.Text = value;
        }

        public string ColorText
        {
            get => txtBoxColor.Text;
            set => txtBoxColor.Text = value;
        }

        public string YearText
        {
            get => txtBoxYear.Text;
            set => txtBoxYear.Text = value;
        }

        public string EngineVolText
        {
            get => txtBoxEngineVol.Text;
            set => txtBoxEngineVol.Text = value;
        }

        public List<Car> Cars { set  { listBoxCar.DataSource = value; } }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEventHandler.Invoke(sender, e);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadEventHandler.Invoke(sender, e);
        }
    }
}
