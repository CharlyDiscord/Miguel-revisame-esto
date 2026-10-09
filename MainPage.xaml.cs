using System.ComponentModel.Design;

namespace CalculadoraMC_CALC
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (¡string.IsNullOrEmpty(Altura.Text) && ¡string.IsNullOrEmpty(Peso.Text)) 
            var altura = double.Parse(Altura.Text);
            var peso = double.Parse(Peso.Text);
            var imc = (peso / altura);
            IMC.Text = imc.ToString();

            string resultado = "";
            if (imc < 18.5)
            {
                resultado = "Tienes bajo peso";
            }
            else if (imc >= 18.5 && imc <= 24.0)
            {
                resultado = "Tu peso es normal";
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                resultado = "Tienes sobrepeso";
            }
            else
            {
                resultado = "Tienes obesidad, cuidate";
            }

            DisplayAlert("Resultado: ", resultado, "Quitar");


            else

                DisplayAlert("Datos errores", "porfavor, llena toda la informacion", "quitar");
            
            
        }
    }
}

