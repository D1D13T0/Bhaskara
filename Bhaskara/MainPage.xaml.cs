namespace Bhaskara
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalcularClicked(object? sender, EventArgs e)
        {
            if (!float.TryParse(valorA.Text, out float ValorA) ||
                !float.TryParse(valorB.Text, out float ValorB) ||
                !float.TryParse(valorC.Text, out float ValorC))
            {
                resultado.Text = "Preencha todos os campos com valores numéricos válidos.";
                return;
            }

            if (ValorA == 0)
            {
                resultado.Text = "O coeficiente A não pode ser zero.";
                return;
            }

            float delta = (ValorB * ValorB) - (4 * ValorA * ValorC);

            if (delta < 0)
            {
                resultado.Text = $"Delta: {delta}\nA equação não possui raízes reais.";
            }
            else if (delta == 0)
            {
                float x1 = -ValorB / (2 * ValorA);
                resultado.Text = $"Delta: {delta}\nRaiz única: x = {x1}";
            }
            else
            {
                float x1 = (-ValorB + (float)Math.Sqrt(delta)) / (2 * ValorA);
                float x2 = (-ValorB - (float)Math.Sqrt(delta)) / (2 * ValorA);
                resultado.Text = $"Delta: {delta}\nx1 = {x1}, x2 = {x2}";
            }
        }
    }
}