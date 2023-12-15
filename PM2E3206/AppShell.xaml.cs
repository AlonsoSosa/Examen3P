using PM2E3206.Vistas;
namespace PM2E3206
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Create), typeof(Create));
            Routing.RegisterRoute(nameof(PageView), typeof(PageView));
        }
    }
}
