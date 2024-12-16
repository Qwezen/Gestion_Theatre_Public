using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using GestionTheatreBLL;
using GestionTheatreBO;

namespace GestionTheatreGUI
{
    public partial class Pieces : Form
    {
        public Pieces()
        {
            InitializeComponent();
        }

        private void Pieces_Load(object sender, EventArgs e)
        {
            pieceGridView.CellClick += PieceGridView_CellClick;

            themeComboBox.DataSource = GestionThemes.Instance.Themes;
            auteurComboBox.DataSource = GestionAuteurs.Instance.Auteurs;
            publicComboBox.DataSource = GestionPublics.Instance.Publics;
            compagnieComboBox.DataSource = GestionCompagnies.Instance.Compagnies;

            RefreshDataView();
            RefreshEntry();

            FormClosed += Pieces_FormClosed;
        }

        private void Pieces_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /*
         * Renvoie la piece sélectionner actuellement dans la grille.
        */
        private Piece GetSelectedPiece()
        {
            return pieceGridView.CurrentRow.DataBoundItem as Piece;
        }

        /*
         * Met à jour la grille des pieces.
        */
        private void RefreshDataView()
        {
            pieceGridView.DataSource = GestionPieces.Instance.GetPieces();

            pieceGridView.Columns.RemoveAt(0);
            pieceGridView.Columns[0].HeaderText = "Nom";
            pieceGridView.Columns[2].HeaderText = "Temps";
        }

        /*
         * Met à jour les entrées selon la piece sélectionner dans la grille.
        */
        private void RefreshEntry()
        {
            Piece piece = GetSelectedPiece();
            nameTextBox.Text = piece.Name;
            tarifTextBox.Text = piece.Tarif.ToString();
            timeTextBox.Text = piece.Time.ToString();
            descriptionTextBox.Text = piece.Description;

            themeComboBox.SelectedItem = GestionThemes.Instance.Themes.Where(x => x.ID == piece.Theme.ID).First();
            auteurComboBox.SelectedItem = GestionAuteurs.Instance.Auteurs.Where(x => x.ID == piece.Auteur.ID).First();
            publicComboBox.SelectedItem = GestionPublics.Instance.Publics.Where(x => x.ID == piece.Public.ID).First();
            compagnieComboBox.SelectedItem = GestionCompagnies.Instance.Compagnies.Where(x => x.ID == piece.Compagnie.ID).First();
        }

        private void EmptyEntry()
        {
            nameTextBox.Text = string.Empty;
            tarifTextBox.Text = string.Empty;
            timeTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;

            themeComboBox.SelectedItem = GestionThemes.Instance.Themes.First();
            auteurComboBox.SelectedItem = GestionAuteurs.Instance.Auteurs.First();
            publicComboBox.SelectedItem = GestionPublics.Instance.Publics.First();
            compagnieComboBox.SelectedItem = GestionCompagnies.Instance.Compagnies.First();

            pieceGridView.CurrentRow.Selected = false;
        }

        private void PieceGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshEntry();
        }

        /*
         * Renvoie false si l'une des entrées est vide ou invalide.
        */
        private bool EntryIsValid()
        {
            return CheckNameValid()
                    && CheckTarifValid()
                    && CheckTimeValid()
                    && CheckDescriptionValid()
                    && CheckThemeValid()
                    && CheckAuteurValid()
                    && CheckPublicValid()
                    && CheckCompagnieValid();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!EntryIsValid())
            {
                MessageBox.Show("Un des champs est vide ou invalide.", "ERREUR");

                return;
            }

            List<Piece> gridPieces = pieceGridView.DataSource as List<Piece>;
            if (gridPieces.Where(x => x.Name == nameTextBox.Text).FirstOrDefault() != null)
            {
                MessageBox.Show($"Une pièce s'appelle déjà {nameTextBox.Text}.", "ERREUR");
                nameTextBox.Text = string.Empty;

                return;
            }

            if (MessageBox.Show("Êtes vous sûr de vouloir ajouter une pièce ?", "CONFIRMATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Theme theme = (Theme)themeComboBox.SelectedItem;
                Auteur auteur = (Auteur)auteurComboBox.SelectedItem;
                Public publicType = (Public)publicComboBox.SelectedItem;
                Compagnie compagnie = (Compagnie)compagnieComboBox.SelectedItem;

                Piece piece = new Piece(0, nameTextBox.Text, descriptionTextBox.Text, float.Parse(tarifTextBox.Text),
                   float.Parse(timeTextBox.Text), theme, publicType, compagnie, auteur);

                MessageBox.Show(GestionPieces.Instance.AddPiece(piece));
                RefreshDataView();
                EmptyEntry();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Piece piece = GetSelectedPiece();
            if (piece == null)
            {
                MessageBox.Show("Veuillez sélectionner une pièce.", "ERREUR", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show($"Êtes vous sûr de vouloir supprimer la pièce ({piece.Name}) ?", "CONFIRMATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool checkRepresentation = GestionPieces.Instance.ConstraintRepresentation(piece);
                    bool checkReservation = GestionPieces.Instance.ConstraintReservation(piece);
                    if (checkRepresentation == true || checkReservation == true)
                    {
                        if (checkRepresentation == true && checkReservation == false)
                        {
                            MessageBox.Show("Impossible de supprimer cette pièce car elle est présente dans représentation");
                        }
                        if (checkRepresentation == true && checkReservation == true)
                        {
                            MessageBox.Show("Impossible de supprimer cette pièce car elle est présente dans une représentation réservée");
                        }
                        RefreshDataView();
                        EmptyEntry();
                    }
                    else
                    {
                        MessageBox.Show(GestionPieces.Instance.DeletePiece(piece));
                        RefreshDataView();
                        EmptyEntry();
                    }

                }
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            Piece pieceSelected = GetSelectedPiece();
            if (pieceSelected == null)
            {
                MessageBox.Show("Veuillez sélectionner une pièce.", "ERREUR", MessageBoxButtons.OK);

                return;
            }

            if (!EntryIsValid())
            {
                MessageBox.Show("Un des champs est vide ou invalide.", "ERREUR");

                return;
            }

            if (MessageBox.Show($"Êtes vous sûr de vouloir modifier la pièce ({pieceSelected.Name}) ?", "CONFIRMATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idPiece = pieceSelected.ID;

                Theme theme = (Theme)themeComboBox.SelectedItem;
                Auteur auteur = (Auteur)auteurComboBox.SelectedItem;
                Public publicType = (Public)publicComboBox.SelectedItem;
                Compagnie compagnie = (Compagnie)compagnieComboBox.SelectedItem;

                Piece piece = new Piece(idPiece, nameTextBox.Text, descriptionTextBox.Text, float.Parse(tarifTextBox.Text),
                    float.Parse(timeTextBox.Text), theme, publicType, compagnie, auteur);

                MessageBox.Show(GestionPieces.Instance.UpdatePiece(piece));
                RefreshDataView();
                EmptyEntry();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            Dispose();
        }

        #region Provider

        private bool CheckNameValid()
        {
            if (nameTextBox.Text.Length > 0)
            {
                errorProviderName.SetError(nameTextBox, string.Empty);

                return true;
            }
            else
            {
                errorProviderName.SetError(nameTextBox, "Veuillez entrez un nom valide.");

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

        private bool CheckTarifValid()
        {
            if (tarifTextBox.Text.Length == 0)
            {
                errorProviderTarif.SetError(tarifTextBox, "Veuillez entrez un tarif valide ou supérieur à 0.");

                return false;
            }

            try
            {
                int tarif = int.Parse(tarifTextBox.Text);
                if (tarif > 0)
                {
                    errorProviderTarif.SetError(tarifTextBox, string.Empty);

                    return true;
                }

                errorProviderTarif.SetError(tarifTextBox, "Veuillez entrez un tarif valide ou supérieur à 0.");

                return false;
            }
            catch
            {
                errorProviderTarif.SetError(tarifTextBox, "Veuillez entrez un tarif valide ou supérieur à 0.");

                return false;
            }
        }

        private void tarifTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckTarifValid();
        }

        private void tarifTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckTarifValid();
        }

        private bool CheckTimeValid()
        {
            if (timeTextBox.Text.Length == 0)
            {
                errorProviderTime.SetError(timeTextBox, "Veuillez entrez une durée valide ou supérieur à 0.");

                return false;
            }

            try
            {
                int time = int.Parse(timeTextBox.Text);
                if (time > 0)
                {
                    errorProviderTime.SetError(timeTextBox, string.Empty);

                    return true;
                }

                errorProviderTime.SetError(timeTextBox, "Veuillez entrez une durée valide ou supérieur à 0.");

                return false;
            }
            catch
            {
                errorProviderTime.SetError(timeTextBox, "Veuillez entrez une durée valide ou supérieur à 0.");

                return false;
            }
        }

        private void timeTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckTimeValid();
        }

        private void timeTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckTimeValid();
        }

        private bool CheckDescriptionValid()
        {
            if (descriptionTextBox.Text.Length > 0)
            {
                errorProviderDescription.SetError(descriptionTextBox, string.Empty);

                return true;
            }
            else
            {
                errorProviderDescription.SetError(descriptionTextBox, "Veuillez entrez une description valide.");

                return false;
            }
        }


        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckDescriptionValid();
        }

        private void descriptionTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckDescriptionValid();
        }

        private bool CheckThemeValid()
        {
            if (themeComboBox.SelectedItem != null)
            {
                errorProviderTheme.SetError(themeComboBox, string.Empty);

                return true;
            }
            else
            {
                errorProviderTheme.SetError(themeComboBox, "Veuillez entrez un thème valide dans la liste.");

                return false;
            }
        }

        private void themeComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckThemeValid();
        }

        private bool CheckAuteurValid()
        {
            if (auteurComboBox.SelectedItem != null)
            {
                errorProviderAuteur.SetError(auteurComboBox, string.Empty);

                return true;
            }
            else
            {
                errorProviderAuteur.SetError(auteurComboBox, "Veuillez entrez un auteur valide dans la liste.");

                return false;
            }
        }

        private void auteurComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckAuteurValid();
        }

        private bool CheckPublicValid()
        {
            if (publicComboBox.SelectedItem != null)
            {
                errorProviderPublic.SetError(publicComboBox, string.Empty);

                return true;
            }
            else
            {
                errorProviderPublic.SetError(publicComboBox, "Veuillez entrez un type de publique valide dans la liste.");

                return false;
            }
        }

        private void publicComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckPublicValid();
        }

        private bool CheckCompagnieValid()
        {
            if (compagnieComboBox.SelectedItem != null)
            {
                errorProviderCompagnie.SetError(compagnieComboBox, string.Empty);

                return true;
            }
            else
            {
                errorProviderCompagnie.SetError(compagnieComboBox, "Veuillez entrez une compagnie valide dans la liste.");

                return false;
            }
        }

        private void compagnieComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckCompagnieValid();
        }

        #endregion
    }
}
