//Lukhanyo Kalashe
//2023575000
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers
{
    public partial class CfrmMain : Form
    {
        protected Computer computer;
        protected List<Computer> lstComputer = new List<Computer>();
        public CfrmMain()
        {
            
            InitializeComponent();
            IBuilder BareboneBuilder = new BareboneBuilder("Barebone");
            Computer BareboneComputer = BareboneBuilder.GetComputers();
            lstComputer.Add(BareboneComputer);

            IBuilder HomeBuilder = new HomeComputerBuilder("Home computer");
            Computer HomeComputer = HomeBuilder.GetComputers();
            lstComputer.Add(HomeComputer);

            IBuilder OfficeBuilder = new OfficeComputerBuilder("Office computer");
            Computer OfficeComputer = OfficeBuilder.GetComputers();
            lstComputer.Add(OfficeComputer);

            IBuilder GamingBuilder = new GamingComputerBuilder("Gaming computer");
            Computer GamingComputer = GamingBuilder.GetComputers();
            lstComputer.Add(GamingComputer);

            IBuilder BeastBuilder = new BeastComputerBuilder("Beast");
            Computer BeastComputer = BeastBuilder.GetComputers();
            lstComputer.Add(BeastComputer);


            foreach(var computer in lstComputer)
            {
                lstBxComputers.Items.Add(computer);
            }
            lstBxComputers.DisplayMember = "Name";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstBxComputers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form cdlgMessage = new CdlgMessage(lstBxComputers.SelectedItem as Computer);
            cdlgMessage.Text = (lstBxComputers.SelectedItem as Computer).Name;
            cdlgMessage.Show();
        }
    }
}
