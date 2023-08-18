using Avalonia.Controls;

namespace avalonia_11_0_2_mirtek_demo;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        fib(45);
    }

    private int fib(int n) { 
        return (n == 0 || n == 1) ? 1 : fib(n - 2) + fib(n - 1);
    }
}