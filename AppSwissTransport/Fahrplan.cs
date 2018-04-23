using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace AppSwissTransport
{
  
    public partial class Fahrplan : Form
    {
        Transport transport = new Transport();
        public Fahrplan()
        {
            InitializeComponent();
        }

        public void combox(ComboBox comboBoxName)
        {
            if (!string.IsNullOrEmpty(comboBoxName.Text))
            {
                List<Station> stations = transport.GetStations(comboBoxName.Text).StationList;
                if (stations.Count > 0)
                {
                    comboBoxName.Items.Clear();
                    foreach (Station station in stations)
                    {
                        comboBoxName.Items.Add(station.Name);
                    }
                }
                comboBoxName.Text = "";
                comboBoxName.SelectedIndex = 0;
            }
        }

        private void btnVon_Click(object sender, EventArgs e)
        {
            combox(cbAbfahrt);
        }

        private void btnNach_Click(object sender, EventArgs e)
        {
            combox(cbAnkunft);
        }
        private void btnSuche_Click(object sender, EventArgs e)
        {
            dgvFahrplan.Rows.Clear();
            Connections cons = transport.GetConnections(cbAbfahrt.Text, cbAnkunft.Text);
            cons.ConnectionList.ForEach(delegate (Connection conn)
            {

                object[] arr = new object[3];

                DateTime dt = Convert.ToDateTime(conn.From.Departure);
                DateTime dt2 = Convert.ToDateTime(conn.To.Arrival);

                arr[0] = dt.ToString("HH:MM");
                arr[1] = dt2.ToString("HH:MM");
                arr[2] = conn.From.Platform;

                dgvFahrplan.Rows.Add(arr);
            });


        }

       
        private void btnAbfahrtstafel_Click(object sender, EventArgs e)
        {
            Form Abfahrt = new Abfahrtstafel();
            Abfahrt.Show();
        }
    }
}
