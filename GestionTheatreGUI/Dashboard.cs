using GestionTheatreBO;
using System;
using System.Windows.Forms;

namespace GestionTheatreGUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            FormClosing += Dashboard_FormClosing;
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        private void pieceButton_Click(object sender, EventArgs e)
        {
            Hide();
            Pieces piece = new Pieces();
            piece.Show();
            Dispose();
        }

        private void representationButton_Click(object sender, EventArgs e)
        {
            Hide();
            Representations representations = new Representations();
            representations.Show();
            Dispose();
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            Hide();
            Reservations reservations = new Reservations();
            reservations.Show();
            Dispose();
        }
    }
}
