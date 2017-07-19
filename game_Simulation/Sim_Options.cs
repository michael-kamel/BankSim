using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_Simulation
{
    public partial class Sim_Options : Form
    {
        private Timer clock;
        private Timer teller_Clock;
        private Timer client_Clock;

        public Sim_Options(Timer clock,Timer teller_Clock, Timer client_Clock)
        {
            InitializeComponent();
            this.clock = clock;
            this.teller_Clock = teller_Clock;
            this.client_Clock = client_Clock;
            clock_txt.Text = (double)clock.Interval / 1000 + "";
            teller_Clock_txt.Text = (double)teller_Clock.Interval / 1000 + "";
            client_Clock_txt.Text = (double)client_Clock.Interval / 1000 + "";
        }
        private void interval_Update(TextBox txt,Timer timer)
        {
            double j;
            if (double.TryParse(txt.Text, out j))
            {
                j *= 1000;
                timer.Interval = (int)j;
            }
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            interval_Update(teller_Clock_txt, teller_Clock);
            interval_Update(client_Clock_txt, client_Clock);
        }
    }
}
