using MudBlazor;

namespace PsicologaJessicaAlbuquerque.Layout
{
    public class MainLayoutBase
    {

        public readonly MudTheme Theme = new()
        {
            PaletteLight = new PaletteLight()
            {
                Primary = "#004d40",
                AppbarBackground = "#f5f5f5",
                Background = "#f1f4fa",
                DrawerBackground = "#ffffff",
                Surface = "#ffffff"
            },
            PaletteDark = new PaletteDark()
            {
                Primary = "#66bb6a",
                Background = "#303030",
                Surface = "#424242"
            }
        };

        public bool DrawerOpen { get; set; } = true;
        public bool IsDarkMode { get; set; } = false;

        public void DrawerToggle()
        {
            DrawerOpen = !DrawerOpen;
        }
    }
}
