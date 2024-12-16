using GestionTheatreBLL;
using GestionTheatreBO;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GestionTheatreGUI
{
    public partial class Representations : Form
    {
        private List<Piece> _pieces, _filterPieces;

        public Representations()
        {
            _pieces = new List<Piece>();
            _filterPieces = new List<Piece>();

            InitializeComponent();

        }
        private void Representations_Load(object sender, EventArgs e)
        {
            representationsGridView.CellClick += RepresentationsGridView_CellClick;
            foreach (Piece piece in GestionPieces.Instance.GetPieces())
            {
                _pieces.Add(piece);
                _filterPieces.Add(piece);
            }
            tarifComboBox.DataSource = GestionTarifs.Instance.Tarifs;
            pieceComboBox.DataSource = _pieces;
            filterPieceComboBox.DataSource = _filterPieces;

            RefreshDataView();
            RefreshEntry();

            FormClosed += Representations_FormClosed;
        }
        private void Representations_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void RefreshDataView()
        {
            representationsGridView.DataSource = GestionRepresentations.Instance.GetRepresentations();

            representationsGridView.Columns.RemoveAt(0);
            representationsGridView.Columns[0].HeaderText = "Date";
            representationsGridView.Columns[1].HeaderText = "Nombre de places";
            representationsGridView.Columns[2].HeaderText = "Tarif";
        }

        private Representation GetSelectedRepresentation()
        {
            if (representationsGridView.CurrentRow == null)
                return null;

            return representationsGridView.CurrentRow.DataBoundItem as Representation;
        }

        private void RefreshEntry()
        {
            Representation representation = GetSelectedRepresentation();
            if (representation == null)
                return;

            dateTextBox.Text = string.Format("{0}/{1}/{2}", representation.DateRepresentation.Date.Day,
                representation.DateRepresentation.Date.Month,
                representation.DateRepresentation.Date.Year);
            hoursTextBox.Text = string.Format("{0}:{1}",
                representation.DateRepresentation.TimeOfDay.Hours,
                representation.DateRepresentation.TimeOfDay.Minutes);
            nbPlaceTextBox.Text = representation.NBPlace.ToString();

            tarifComboBox.SelectedItem = GestionTarifs.Instance.Tarifs.Where(x => x.ID == representation.Tarif.ID).First();
            pieceComboBox.SelectedItem = _pieces.Where(x => x.ID == representation.Piece.ID).First();
        }
        
        private void EmptyEntry()
        {
            dateTextBox.Text = string.Empty;
            hoursTextBox.Text = string.Empty;
            nbPlaceTextBox.Text = string.Empty;

            tarifComboBox.SelectedItem = GestionTarifs.Instance.Tarifs.First();
            pieceComboBox.SelectedItem = _pieces.First();

            representationsGridView.CurrentRow.Selected = false;

        }

        private void RepresentationsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshEntry();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            Dispose();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            List<Representation> representations = new List<Representation>();
            Piece piece = (Piece)filterPieceComboBox.SelectedItem;
            if (CheckFirstDateValid() && CheckSecondDateValid())
            {
                DateTime firstDate = DateTime.Parse(firstDateTextBox.Text);
                DateTime secondDate = DateTime.Parse(secondDateTextBox.Text);
                representations = GestionRepresentations.Instance.GetFilterRepresentations(piece, true, firstDate, secondDate);
            }
            else
            {
                representations = GestionRepresentations.Instance.GetFilterRepresentations(piece);
            }

            representationsGridView.DataSource = representations;
            representationsGridView.Columns.RemoveAt(0);
            representationsGridView.Columns[0].HeaderText = "Date";
            representationsGridView.Columns[1].HeaderText = "Nombre de places";
            representationsGridView.Columns[2].HeaderText = "Tarif";
            
            RefreshEntry();
        }

        /*
         * Renvoie false si l'une des entrées est vide ou invalide.
        */
        private bool EntryIsValid()
        {
            return CheckDateValid()
                    && CheckHoursValid()
                    && CheckTarifValid()
                    && CheckPieceValid()
                    && CheckNbPlaceValid();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!EntryIsValid())
            {
                MessageBox.Show("Un des champs est vide ou invalide.", "ERREUR");

                return;
            }

            DateTime date;
            try
            {
                date = DateTime.Parse(dateTextBox.Text + " " + hoursTextBox.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show($"Format de date invalide ({fe.Message}).", "ERREUR");

                return;
            }

            List<Representation> gridRepresentations = representationsGridView.DataSource as List<Representation>;
            Piece piece = (Piece)pieceComboBox.SelectedItem;

            int countPiece = gridRepresentations.Where(x => x.Piece.ID == piece.ID).ToList().Count;
            if (gridRepresentations.Where(x => x.DateRepresentation.ToString() == date.ToString()).FirstOrDefault() != null && 
                countPiece >= 1)
            {
                MessageBox.Show($"Une représentation est déjà présente sur cette date {date}.", "ERREUR");
                dateTextBox.Text = string.Empty;
                hoursTextBox.Text = string.Empty;

                return;
            }

            if (MessageBox.Show("Êtes vous sûr de vouloir ajouter une représentation ?", "CONFIRMATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Tarif tarif = (Tarif)tarifComboBox.SelectedItem;

                Representation representation = new Representation(0, date,
                    int.Parse(nbPlaceTextBox.Text), tarif, piece);

                MessageBox.Show(GestionRepresentations.Instance.AddRepresentation(representation));
                RefreshDataView();
                EmptyEntry();
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            Representation representationSelected = GetSelectedRepresentation();
            if (representationSelected == null)
            {
                MessageBox.Show("Veuillez sélectionner une pièce.", "ERREUR", MessageBoxButtons.OK);

                return;
            }

            if (!EntryIsValid())
            {
                MessageBox.Show("Un des champs est vide ou invalide.", "ERREUR");

                return;
            }

            DateTime date;
            try
            {
                date = DateTime.Parse(dateTextBox.Text + " " + hoursTextBox.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show($"Format de date invalide ({fe.Message}).", "ERREUR");

                return;
            }

            if (MessageBox.Show($"Êtes vous sûr de vouloir modifier la représentation ({representationSelected.DateRepresentation} - {representationSelected.Piece}) ?", "CONFIRMATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idRepresentation = representationSelected.ID;

                Tarif tarif = (Tarif)tarifComboBox.SelectedItem;
                Piece piece = (Piece)pieceComboBox.SelectedItem;

                Representation representation = new Representation(idRepresentation, date, int.Parse(nbPlaceTextBox.Text), tarif, piece);

                MessageBox.Show(GestionRepresentations.Instance.UpdateRepresentation(representation));
                RefreshDataView();
                EmptyEntry();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Representation representation = GetSelectedRepresentation();
            if (representation == null)
            {
                MessageBox.Show("Veuillez sélectionner une représentation.", "ERREUR", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show($"Êtes vous sûr de vouloir supprimer la représentation ({representation.DateRepresentation} - {representation.Piece}) ?", "CONFIRMATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (GestionRepresentations.Instance.ConstraintReservation(representation))
                    {
                        MessageBox.Show("Impossible de supprimer cette représentation car elle est présente dans une ou des réservations.", "ERREUR", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show(GestionRepresentations.Instance.DeleteRepresentation(representation));
                        RefreshDataView();
                    }
                    EmptyEntry();
                }
            }
        }

        #region Provider

        private bool CheckDateValid()
        {
            Regex r = new Regex(@"^(0?[1-9]|[12][0-9]|3[01])/(0?[1-9]|1[0-2])/([0-9]{4})$");
            if (r.IsMatch(dateTextBox.Text))
            {
                errorProviderDate.SetError(dateTextBox, string.Empty);

                return true;
            }
            else
            {
                errorProviderDate.SetError(dateTextBox, "Veuillez entrez une date valide.");

                return false;
            }
        }

        private void dateTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckDateValid();
        }

        private void dateTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckDateValid();
        }

        private bool CheckHoursValid()
        {
            Regex r = new Regex(@"^([01]?[0-9]|2[0-3]):([0-5][0-9]|[0-9])$");
            if (r.IsMatch(hoursTextBox.Text))
            {
                errorProviderHours.SetError(hoursTextBox, string.Empty);

                return true;
            }
            else
            {
                errorProviderHours.SetError(hoursTextBox, "Veuillez entrez une heure valide.");

                return false;
            }
        }

        private void hoursTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckHoursValid();
        }

        private void hoursTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckHoursValid();
        }

        private bool CheckNbPlaceValid()
        {
            if (nbPlaceTextBox.Text.Length == 0)
            {
                errorProviderNbPlace.SetError(nbPlaceTextBox, "Veuillez entrez un nombre de place valide ou supérieur à 0.");

                return false;
            }

            try
            {
                int time = int.Parse(nbPlaceTextBox.Text);
                if (time > 0)
                {
                    errorProviderNbPlace.SetError(nbPlaceTextBox, string.Empty);

                    return true;
                }

                errorProviderNbPlace.SetError(nbPlaceTextBox, "Veuillez entrez un nombre de place valide ou supérieur à 0.");

                return false;
            }
            catch
            {
                errorProviderNbPlace.SetError(nbPlaceTextBox, "Veuillez entrez un nombre de place valide ou supérieur à 0.");

                return false;
            }
        }

        private void nbPlaceTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckNbPlaceValid();
        }

        private void nbPlaceTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckNbPlaceValid();
        }

        private bool CheckTarifValid()
        {
            if (tarifComboBox.SelectedItem != null)
            {
                errorProviderTarif.SetError(tarifComboBox, string.Empty);

                return true;
            }
            else
            {
                errorProviderTarif.SetError(tarifComboBox, "Veuillez entrez un tarif valide dans la liste.");

                return false;
            }
        }

        private void tarifComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckTarifValid();
        }

        private bool CheckPieceValid()
        {
            if (pieceComboBox.SelectedItem != null)
            {
                errorProviderPiece.SetError(pieceComboBox, string.Empty);

                return true;
            }
            else
            {
                errorProviderPiece.SetError(pieceComboBox, "Veuillez entrez une pièce valide dans la liste.");

                return false;
            }
        }

        private void pieceComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckPieceValid();
        }

        private bool CheckFirstDateValid()
        {
            Regex r = new Regex(@"^(0?[1-9]|[12][0-9]|3[01])/(0?[1-9]|1[0-2])/([0-9]{4})$");
            if (r.IsMatch(secondDateTextBox.Text))
            {
                errorProviderFirstDate.SetError(firstDateTextBox, string.Empty);

                return true;
            }
            else
            {
                errorProviderFirstDate.SetError(firstDateTextBox, "Veuillez entrez une date valide.");

                return false;
            }
        }

        private void firstDateTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckFirstDateValid();
        }

        private void firstDateTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckFirstDateValid();
        }

        private bool CheckSecondDateValid()
        {
            Regex r = new Regex(@"^(0?[1-9]|[12][0-9]|3[01])/(0?[1-9]|1[0-2])/([0-9]{4})$");
            if (r.IsMatch(secondDateTextBox.Text))
            {
                errorProviderSecondDate.SetError(secondDateTextBox, string.Empty);

                return true;
            }
            else
            {
                errorProviderSecondDate.SetError(secondDateTextBox, "Veuillez entrez une date valide.");

                return false;
            }
        }

        private void secondDateTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckSecondDateValid();
        }

        private void secondDateTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckSecondDateValid();
        }

        private bool CheckFilterPieceValid()
        {
            if (filterPieceComboBox.SelectedItem != null)
            {
                errorProviderFilterPiece.SetError(filterPieceComboBox, string.Empty);

                return true;
            }
            else
            {
                errorProviderFilterPiece.SetError(filterPieceComboBox, "Veuillez entrez une pièce valide dans la liste.");

                return false;
            }
        }

        private void filterPieceComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckFilterPieceValid();
        }

        #endregion
    }
}
