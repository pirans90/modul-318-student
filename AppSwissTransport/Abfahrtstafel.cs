using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSwissTransport
{
    public partial class Abfahrtstafel : Form
    {
        Transport transport = new Transport();
        public Abfahrtstafel()
        {
            InitializeComponent();
        }
        private void btnSuche_Click(object sender, EventArgs e)
        {
            dgrdAbfahrtsTafel.Rows.Clear();

            List<StationBoard> stationBoard = transport.GetStationBoard(cbAbfahrt.Text, "20").Entries;

            stationBoard.ForEach(delegate (StationBoard con)
            {
                dgrdAbfahrtsTafel.Rows.Add
                (
                    con.To.ToString(),
                    con.Stop.Departure.Hour.ToString() +
                    ":" +
                    con.Stop.Departure.Minute.ToString()
                );
            });

            cbAbfahrt.Text = "";
        }
        public void combox(ComboBox comboBoxName)
        {
            if (!string.IsNullOrEmpty(comboBoxName.Text))
            {
                List<StationBoard> stations = transport.GetStationBoard(comboBoxName.Text, "10").Entries;
                if (stations.Count > 0)
                {
                    comboBoxName.Items.Clear();
                    foreach (StationBoard station in stations)
                    {
                        comboBoxName.Items.Add(station.Name);
                    }
                }
                comboBoxName.Text = "";
                comboBoxName.SelectedIndex = 0;
            }
        }
    }
}
