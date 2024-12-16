using GestionTheatreBLL;
using GestionTheatreBO;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GestionTheatreGUI
{
    public partial class Reservations : Form
    {
        private List<Representation> _representations;
        public Reservations()
        {
            _representations = new List<Representation>();      
            InitializeComponent();

        }
        private void Representations_Load(object sender, EventArgs e)
        {
            reservationsGridView.CellClick += ReservationsGridView_CellClick;
            _representations = GestionRepresentations.Instance.GetRepresentations();

            representationComboBox.DataSource = _representations;

            foreach (Representation representation in GestionRepresentations.Instance.GetRepresentations())
            {
                _representations.Add(representation);
            }
            representationComboBox.DataSource = _representations;

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
            reservationsGridView.DataSource = GestionReservations.Instance.GetReservations();

            reservationsGridView.Columns[0].HeaderText = "Représentation";
            reservationsGridView.Columns[1].HeaderText = "Client";
            reservationsGridView.Columns[2].HeaderText = "Nombre de places";
            reservationsGridView.Columns[3].HeaderText = "Tarification";
            reservationsGridView.Columns[4].HeaderText = "Tarif total";
        }

        private Reservation GetSelectedReservation()
        {
            if (reservationsGridView.CurrentRow == null)
            {
                return null;
            }
            else
            {
                return reservationsGridView.CurrentRow.DataBoundItem as Reservation;
            }
        }

        private void RefreshEntry()
        {
            Reservation reservation = GetSelectedReservation();
            if (reservation == null)
                return;

            representationComboBox.SelectedItem = _representations.Where(x => x.ID == reservation.Representation.ID).First();
            tarifByPlaceTextBox.Text = reservation.Representation.Piece.Tarif.ToString();
            firstNameTextBox.Text = reservation.Client.FirstName;
            nameTextBox.Text = reservation.Client.Name;
            mailTextBox.Text = reservation.Client.Mail;
            telTextBox.Text = reservation.Client.Tel.ToString();
            nbPlaceTextBox.Text = reservation.NbPlaceReserve.ToString();
            resultTarifTextBox.Text = reservation.TotalTarifView.ToString();
        }

        private void EmptyEntry()
        {
            representationComboBox.SelectedItem = _representations.First();
            Representation representation = representationComboBox.SelectedItem as Representation;
            tarifByPlaceTextBox.Text = representation.Piece.Tarif.ToString();
            firstNameTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            mailTextBox.Text = string.Empty;
            telTextBox.Text = string.Empty;
            nbPlaceTextBox.Text = string.Empty;

            reservationsGridView.CurrentRow.Selected = false;
        }

        private void ReservationsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
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

        /*
         * Renvoie false si l'une des entrées est vide ou invalide.
        */
        private bool EntryIsValid()
        {
            return CheckRepresentationValid()
                    && CheckFirstNameValid()
                    && CheckNameValid()
                    && CheckMailValid()
                    && CheckTelValid()
                    && CheckNbPlaceValid();
        }

        private bool NbPlaceIsValid(int place, int placeTotal)
        {
            return place <= placeTotal;
        }

        private bool NbRemainingPlaceIsValid(int place, int remainingPlace)
        {
            return place <= remainingPlace;
        }

        #region Buttons

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!EntryIsValid())
            {
                MessageBox.Show("Un des champs est vide ou invalide.", "ERREUR");

                return;
            }

            int place = int.Parse(nbPlaceTextBox.Text);
            Representation representationSelected = representationComboBox.SelectedValue as Representation;

            if (!NbPlaceIsValid(place, representationSelected.NBPlace))
            {
                nbPlaceTextBox.Text = string.Empty;
                MessageBox.Show($"Le nombre de places est supérieur au nombre total de places pour cette représentation. (Total des places : {representationSelected.NBPlace})", "ERREUR");

                return;
            }

            int remainingPlace = GestionReservations.Instance.GetNbPlace(representationSelected);
            if (!NbRemainingPlaceIsValid(place, remainingPlace))
            {
                nbPlaceTextBox.Text = string.Empty;
                MessageBox.Show($"Le nombre de places est supérieur au nombre de places restantes pour cette représentation. (Places restantes : {remainingPlace})", "ERREUR");

                return;
            }

            Client newClient = new Client(-1, nameTextBox.Text, firstNameTextBox.Text,
               mailTextBox.Text, int.Parse(telTextBox.Text));

            foreach (Reservation reservation in reservationsGridView.DataSource as List<Reservation>)
            {
                if (reservation.Representation.ID == representationSelected.ID &&
                    reservation.Client.Equals(newClient) &&
                    reservation.NbPlaceReserve == place)
                {
                    EmptyEntry();
                    MessageBox.Show($"Une réservation similaire existe déjà. ({reservation.Client.FirstName} {reservation.Client.Name} - {reservation.Representation})", "ERREUR");

                    return;
                }
            }

            try
            {
                if (MessageBox.Show($"Êtes vous sûr de vouloir ajouter la réservation de ({firstNameTextBox.Text} {nameTextBox.Text} - {representationSelected}) ?", "CONFIRMATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Reservation newReservation = new Reservation(representationSelected, newClient, place);
                    MessageBox.Show(GestionReservations.Instance.AddReservation(newReservation));
                    RefreshDataView();
                    EmptyEntry();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERREUR", MessageBoxButtons.OK);
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (!EntryIsValid())
            {
                MessageBox.Show("Un des champs est vide ou invalide.", "ERREUR");

                return;
            }

            Reservation reservationSelected = GetSelectedReservation();

            int place = int.Parse(nbPlaceTextBox.Text);
            Representation representationSelected = representationComboBox.SelectedValue as Representation;

            if (!NbPlaceIsValid(place, representationSelected.NBPlace))
            {
                nbPlaceTextBox.Text = string.Empty;
                MessageBox.Show($"Le nombre de places est supérieur au nombre total de places pour cette représentation. (Total des places : {representationSelected.NBPlace})", "ERREUR");

                return;
            }

            int remainingPlace = GestionReservations.Instance.GetNbPlace(representationSelected);
            if (!NbRemainingPlaceIsValid(place, remainingPlace))
            {
                nbPlaceTextBox.Text = string.Empty;
                MessageBox.Show($"Le nombre de places est supérieur au nombre de places restantes pour cette représentation. (Places restantes : {remainingPlace})", "ERREUR");

                return;
            }

            try
            {
                if (MessageBox.Show($"Êtes vous sûr de vouloir modifier la réservation de ({reservationSelected.Client} - {reservationSelected.Representation}) ?", "CONFIRMATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Client newClient = new Client(reservationSelected.Client.ID, nameTextBox.Text, firstNameTextBox.Text,
                        mailTextBox.Text, int.Parse(telTextBox.Text));

                    Reservation newReservation = new Reservation(representationSelected, newClient, int.Parse(nbPlaceTextBox.Text));
                    MessageBox.Show(GestionReservations.Instance.UpdateReservation(reservationSelected, newReservation));
                    RefreshDataView();
                    EmptyEntry();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERREUR", MessageBoxButtons.OK);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Reservation reservationSelected = GetSelectedReservation();
            if (reservationSelected == null)
            {
                MessageBox.Show("Veuillez sélectionner une réservation.", "ERREUR", MessageBoxButtons.OK);

                return;
            }
            else
            {
                if (MessageBox.Show($"Êtes vous sûr de vouloir supprimer la réservation de ({reservationSelected.Client} - {reservationSelected.Representation}) ?", "CONFIRMATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show(GestionReservations.Instance.DeleteReservation(reservationSelected));
                    RefreshDataView();
                    EmptyEntry();
                }
            }
        }

        #endregion

        #region Provider

        private bool CheckRepresentationValid()
        {
            if (representationComboBox.SelectedItem != null)
            {
                errorProviderRepresentation.SetError(representationComboBox, string.Empty);

                return true;
            }
            else
            {
                errorProviderRepresentation.SetError(representationComboBox, "Veuillez entrez une représentation valide dans la liste.");

                return false;
            }
        }

        private void representationComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CheckRepresentationValid())
            {
                Representation representation = representationComboBox.SelectedItem as Representation;
                tarifByPlaceTextBox.Text = representation.Piece.Tarif.ToString();
                if (CheckNbPlaceValid())
                {
                    resultTarifTextBox.Text = Reservation.CalculateTotalTarif(int.Parse(nbPlaceTextBox.Text), representation.Piece.Tarif,
                            representation.Tarif.Variation).ToString();
                }
            }
        }

        private void representationComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckRepresentationValid();
        }

        private bool CheckFirstNameValid()
        {
            if (firstNameTextBox.Text.Length > 0)
            {
                errorProviderFirstName.SetError(firstNameTextBox, string.Empty);

                return true;
            }
            else
            {
                errorProviderFirstName.SetError(firstNameTextBox, "Veuillez entrez un nom valide.");

                return false;
            }
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckFirstNameValid();
        }

        private void firstNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckFirstNameValid();
        }

        private bool CheckNameValid()
        {
            if (nameTextBox.Text.Length > 0)
            {
                errorProviderName.SetError(nameTextBox, string.Empty);

                return true;
            }
            else
            {
                errorProviderName.SetError(nameTextBox, "Veuillez entrez un prénom valide.");

                return false;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckNameValid();
        }

        private void nameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckNameValid();
        }

        private bool CheckMailValid()
        {
            Regex r = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            if (r.IsMatch(mailTextBox.Text))
            {
                errorProviderMail.SetError(mailTextBox, string.Empty);

                return true;
            }
            else
            {
                errorProviderMail.SetError(mailTextBox, "Veuillez entrez un mail valide.");

                return false;
            }
        }

        private void mailTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckMailValid();
        }

        private void mailTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckMailValid();
        }

        private bool CheckTelValid()
        {
            Regex r = new Regex(@"^(0?6|0?7)\d{8}$");
            if (r.IsMatch(telTextBox.Text))
            {
                errorProviderTel.SetError(telTextBox, string.Empty);

                return true;
            }
            else
            {
                errorProviderTel.SetError(telTextBox, "Veuillez entrez un numéro de téléphone valide.");

                return false;
            }
        }

        private void telTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckTelValid();
        }

        private void telTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckTelValid();
        }

        private bool CheckNbPlaceValid()
        {
            if (nbPlaceTextBox.Text.Length == 0)
            {
                errorProviderNbPlace.SetError(nbPlaceTextBox, "Veuillez entrez un nombre de places valide ou supérieur à 0.");

                return false;
            }

            try
            {
                int place = int.Parse(nbPlaceTextBox.Text);
                if (place > 0)
                {
                    errorProviderNbPlace.SetError(nbPlaceTextBox, string.Empty);

                    if (CheckRepresentationValid())
                    {
                        Representation representation = representationComboBox.SelectedItem as Representation;
                        resultTarifTextBox.Text = Reservation.CalculateTotalTarif(place, representation.Piece.Tarif, 
                            representation.Tarif.Variation).ToString();
                    }

                    return true;
                }

                errorProviderNbPlace.SetError(nbPlaceTextBox, "Veuillez entrez une places valide ou supérieur à 0.");

                return false;
            }
            catch
            {
                errorProviderNbPlace.SetError(nbPlaceTextBox, "Veuillez entrez une places valide ou supérieur à 0.");

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

        #endregion
    }
}