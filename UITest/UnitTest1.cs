using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.VisualTree;
using lab7.Models;

namespace UITest
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Add");

            button.Command.Execute(button.CommandParameter);

            await Task.Delay(50);

            Assert.True(button.IsEnabled);
        }
    }
}