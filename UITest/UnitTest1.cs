using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;
using Avalonia.VisualTree;
using lab7.Models;
using static System.Net.Mime.MediaTypeNames;

namespace UITestsForGradeTable
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
            var textblock = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(b => b.Name == "TextBlock");
            var color = (textblock.Background as SolidColorBrush).Color;

            button.Command.Execute(button.CommandParameter);

            await Task.Delay(50);

            Assert.True(color.Equals(Colors.Red));
            Assert.True(textblock.Equals("0"));
        }
    }
}