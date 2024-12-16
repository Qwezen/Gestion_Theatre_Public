using System;
using System.Configuration;
using System.Windows.Forms;
using GestionTheatreBLL;

namespace GestionTheatreGUI
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["Theatre"];
            if (settings == null)
            {
                throw new ArgumentNullException(nameof(settings), "La chaîne de connexion est null.");
            }

            string sCon = settings.ConnectionString;
            if (string.IsNullOrEmpty(sCon))
            {
                throw new ArgumentException("La chaîne de connexion est vide ou null.");
            }

            GestionUtilisateurs.Instance.SetConnectionSettings(sCon);
        }

        private void EmptyEntry()
        {
            nameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string password = passwordTextBox.Text;

            if (!CheckNameValid() || !CheckPasswordValid())
            {
                MessageBox.Show("Un des champs est vide.", "ERREUR", MessageBoxButtons.OK);

                return;
            }

            if (GestionUtilisateurs.Instance.Login(name, password))
            {
                Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect.", "ERREUR", MessageBoxButtons.OK);
                EmptyEntry();
            }
        }

        #region Provider

        private bool CheckNameValid()
        {
            if (nameTextBox.Text.Length > 0)
            {
                errorProviderId.SetError(nameTextBox, string.Empty);

                return true;
            }
            else
            {
                errorProviderId.SetError(nameTextBox, "Veuillez entrez un nom valide.");

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

        private bool CheckPasswordValid()
        {
            if (passwordTextBox.Text.Length > 0)
            {
                errorProviderPassword.SetError(passwordTextBox, string.Empty);

                return true;
            }
            else
            {
                errorProviderPassword.SetError(passwordTextBox, "Veuillez entrez un mot de passe valide.");

                return false;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckPasswordValid();
        }

        private void passwordTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckPasswordValid();
        }

        #endregion
    }
}
