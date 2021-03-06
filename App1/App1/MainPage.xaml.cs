﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

		}

        private bool ValidarNomeDoUsuario()
        {
            var isValid = (Nome.Text ?? "").Length > 0;

            var state = isValid ? "Valid" : "Invalid";

            VisualStateManager.GoToState(Nome, state);
            VisualStateManager.GoToState(NomeMsg, state);

            return isValid;
        }

        private bool ValidarEmailInformado()
        {
            var isValid = Email.Text.Contains("@");

            var state = isValid ? "Valid" : "Invalid";

            VisualStateManager.GoToState(Email, state);
            VisualStateManager.GoToState(EmailMsg, state);

            return isValid;
        }

        private bool ValidarSenhaInformada()
        {
            var isValid = Senha.Text.Length > 6;

            var state = isValid ? "Valid" : "Invalid";

            VisualStateManager.GoToState(Senha, state);
            VisualStateManager.GoToState(SenhaMsg, state);

            return isValid;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (IsValid())
                DisplayAlert("rsamorim", "Você foi registrado com sucesso!", "OK");
            else
                DisplayAlert("rsamorim", "Por favor, verifique os campos informados.", "OK");
        }

        bool IsValid()
        {
            var nomeValid = ValidarNomeDoUsuario();
            var emailValid = ValidarEmailInformado();
            var senhaValid = ValidarSenhaInformada();

            return nomeValid && emailValid && senhaValid;
        }

        private void Nome_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValidarNomeDoUsuario();
        }

        private void Email_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValidarEmailInformado();
        }

        private void Senha_TextChanged(object sender, TextChangedEventArgs e)
        {
            Button
            ValidarSenhaInformada();
        }
    }
}
