using AudioVisualizer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Playback;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace cSoundz
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MediaPlayer _player;
        AudioVisualizer.PlaybackSource _source;
        public MainPage()
        {
            _player = new MediaPlayer();
            _source = PlaybackSource.CreateFromMediaPlayer(_player);
            _source.SourceChanged += Playback_SourceChanged;
            this.InitializeComponent();
            //Loaded += MainPage_Loaded;

        }
        private void Playback_SourceChanged(object sender, IVisualizationSource source)
        {
            vuMeter.Source = source;
            //spectrumDisplay.Source = source;
            //playPositionDisplay.Source = source;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            vuMeter.Source = _source.Source;
            //spectrumDisplay.Source = _source.VisualizationSource;
            //playPositionDisplay.Source = _source.VisualizationSource;
        }
        
    }
}
