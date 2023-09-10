using Microsoft.UI.Xaml;

using System.Collections.Generic;

namespace xBindTextBlockRunRepro;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public sealed partial class MainWindow : Window
{
    public Person Person { get; set; } = new(){ Name = "John Doe", Age = 42 };

    public List<Person> People { get; set; } = new() { new(){ Name = "Test List", Age = 20 } };

    public MainWindow()
    {
        InitializeComponent();
    }
}
