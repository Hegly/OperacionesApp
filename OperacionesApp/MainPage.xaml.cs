namespace OperacionesApp;

public partial class MainPage : TabbedPage
{
    public object SumaEntry1 { get; private set; }
    public object SumaEntry2 { get; private set; }
    public object SumaEntry3 { get; private set; }
    public object SumaResultadoLabel { get; private set; }
    public object RestaEntry1 { get; private set; }
    public object RestaEntry2 { get; private set; }
    public object RestaResultadoLabel { get; private set; }
    public object MultiplicarEntry1 { get; private set; }
    public object MultiplicarEntry2 { get; private set; }
    public object MultiplicarEntry3 { get; private set; }
    public object MultiplicaResultadoLabel { get; private set; }
    public object DividirEntry1 { get; private set; }
    public object DividirEntry2 { get; private set; }
    public object DividirResultadoLabel { get; private set; }

    public MainPage()
    {
        InitializeComponent();
    }

        private void OnSumaClicked(object sender, EventArgs e)
        {
            if (IsValidInput(SumaEntry1.Text) && IsValidInput(SumaEntry2.Text) && IsValidInput(SumaEntry3.Text))
            {
                if (TryParseInputs(SumaEntry1.Text, out double valor1) &&
                     TryParseInputs(SumaEntry2.Text, out double valor2) &&
                     TryParseInputs(SumaEntry3.Text, out double valor3))
                {
                    double resultado = valor1 + valor2 + valor3;
                    SumaResultadoLabel.Text = $"Resultado de la suma: {resultado}";
                }
                else
                {
                    DisplayAlert("Error", "Ingrese valores numéricos válidos.", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
            }
        }

    private bool TryParseInputs(object text, out double valor3)
    {
        throw new NotImplementedException();
    }

    private void OnRestaClicked(object sender, EventArgs e)
        {
            if (IsValidInput(RestaEntry1.Text) && IsValidInput(RestaEntry2.Text))
            {
                if (TryParseInputs(RestaEntry1.Text, out double valor1) &&
                    TryParseInputs(RestaEntry2.Text, out double valor2))
                {
                    double resultado = valor1 - valor2;
                    RestaResultadoLabel.Text = $"Resultado de la resta: {resultado}";
                }
                else
                {
                    DisplayAlert("Error", "Ingrese valores numéricos válidos.", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
            }
        }

        private void OnMultiplicaClicked(object sender, EventArgs e)
        {
            if (IsValidInput(MultiplicarEntry1.Text) && IsValidInput(MultiplicarEntry2.Text) && IsValidInput(MultiplicarEntry3.Text))
            {
                if (TryParseInputs(MultiplicarEntry1.Text, out double valor1) &&
                    TryParseInputs(MultiplicarEntry2.Text, out double valor2) &&
                    TryParseInputs(MultiplicarEntry3.Text, out double valor3))
                {
                    double resultado = valor1 * valor2 * valor3;
                    MultiplicaResultadoLabel.Text = $"Resultado de la multiplicación: {resultado}";
                }
                else
                {
                    DisplayAlert("Error", "Ingrese valores numéricos válidos.", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
            }
        }

        private void OnDivideClicked(object sender, EventArgs e)
        {
            if (IsValidInput(DividirEntry1.Text) && IsValidInput(DividirEntry2.Text))
            {
                if (TryParseInputs(DividirEntry1.Text, out double valor1) &&
                    TryParseInputs(DividirEntry2.Text, out double valor2) && valor2 != 0)
                {

                    if (valor2 != 0)
                    {
                        double resultado = valor1 / valor2;
                        DividirResultadoLabel.Text = $"Resultado de la división: {resultado}";
                    }
                    else
                    {
                        DisplayAlert("Error", "No se puede dividir por cero.", "OK");
                    }
                }
                else
                {
                    DisplayAlert("Error", "Ingrese valores numéricos válidos y asegúrese de que el divisor no sea cero.", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
            }
        }

    private bool IsValidInput(object text)
    {
        throw new NotImplementedException();
    }

    // Metod para limpiar los campos
    private void OnLimpiarClicked(object sender, EventArgs e)
        {
        SumaEntry1.Text = SumaEntry2.Text = SumaEntry3.Text = string.Empty;
        RestaEntry1.Text = RestaEntry2.Text = string.Empty;
        MultiplicarEntry1.Text = MultiplicarEntry2.Text = MultiplicarEntry3.Text = string.Empty;
        DividirEntry1.Text = DividirEntry2.Text = string.Empty;

        SumaResultadoLabel.Text = RestaResultadoLabel.Text = MultiplicaResultadoLabel.Text = DividirResultadoLabel.Text = string.Empty;
    }

    private static bool IsValidInput(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

    private static bool TryParseInputs(string input, out double result)
    {
        return double.TryParse(input, out result);
    }
}