
using HelixToolkit.Wpf;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace QuickLook.Plugin.HelixViewer
{
    public partial class HelixViewerPanel : UserControl
    {
        public HelixViewerPanel(string path)
        {
            InitializeComponent();

            var MLoader = new ModelImporter();

            var M = MLoader.Load(path);

            PreviewModel.Content = M;

            GeometryModel3D model = M.Children[0] as GeometryModel3D;

            DiffuseMaterial material = new DiffuseMaterial(new SolidColorBrush(Color.FromRgb(160,160,160)));

            foreach(GeometryModel3D child in M.Children)
            {
                child.Material = material;
                child.BackMaterial = material;
            }

            
        }

    }
}
