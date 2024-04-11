using System.Windows.Controls;
using System.Windows.Input;

namespace WeatherApp;

public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void ComboBox_PreviewKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key != Key.Enter) return;
        
        if (ComboBox.Items.Count > 0 && ComboBox.Items[0] is ComboBoxItem firstItem)
                firstItem.Content = ComboBox.Text;
        else if (ComboBox.Items.Count == 0)
        {
            var newItem = new ComboBoxItem
            {
                Content = ComboBox.Text
            };
            ComboBox.Items.Insert(0, newItem);
        }
        
        ComboBox.IsDropDownOpen = true;
        e.Handled = true;
    }
}