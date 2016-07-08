using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ozeki.Media;
using Ozeki.Camera;



namespace CameraGUI
{
    public partial class MainWindow : Window
    {
        private IPCamera m_camera;
        private DrawingImageProvider m_drawingImageProvider;
        private MediaConnector m_connector;


        private URLConverter, 

/*
        IPCamera()
        m_camera = new IPCamera("192.168.112.109:8080","user","qwe123");
        _connector.Connect(_camera.VideoChannel, _drawingImageProvider);
        _camera.Start();
        videoViewer.Start();


        public MainWindow()
        {
            InitializeComponent();

            _drawingImageProvider = new DrawingImageProvider();
            _connector = new MediaConnector();
            SetImageProvider(_drawingImageProvider);
        }

        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            _camera = new IPCamera("96.10.1.168/index.shtml");
            _connector.Connect(_camera.VideoChannel, _drawingImageProvider);
            _camera.Start();
            videoViewer.Start();
        }

    }
}
    private void comboBox_Copy_ContextMenuClosing(object sender, ContextMenuEventArgs e)
    {

    }

    private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }






