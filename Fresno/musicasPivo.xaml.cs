using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Fresno.Endidades;

namespace Fresno
{
    public partial class musicasPivo : PhoneApplicationPage
    {
        public musicasPivo()
        {
            InitializeComponent();
        }

        #region Quarto 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (btmusica.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/7cWondmMjlDFnBob/01%20-%20Teu%20Semblante.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusica.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusica.Content = "Play";
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (btmusica1.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/ypkO1Bfl4gjrGHuR/02%20-%20Desde%20J%C3%A1.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusica1.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusica1.Content = "Play";
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (btmusica2.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/o7NwlexrIvF71QkD/03%20-%20Carta.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusica2.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusica2.Content = "Play";
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (btmusica3.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/peWLqnIwkeYaJrBW/04%20-%20Carpe%20Diem.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusica3.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusica3.Content = "Play";
            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (btmusica4.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/DWZOAAubW1ep9jCZ/05%20-%20O%20Gelo.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusica4.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusica4.Content = "Play";
            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (btmusica5.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/ShLFte4cxMvqEayE/06%20-%20Se%20Algum%20Dia%20eu%20n%C3%A3o%20Acordar.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusica5.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusica5.Content = "Play";
            }
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (btmusica6.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/qryN61t7bCKAv90S/07%20-%20Mais%20um%20Soldado.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusica6.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusica6.Content = "Play";
            }
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (btmusica7.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/dRKlrZeHN8LIOFTh/08%20-%20Stonehenge.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusica7.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusica7.Content = "Play";
            }
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (btmusica8.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/ii4UfJhkkyaMLk8R/09%20-%201%20Eu%20sem%201%20voc%C3%AA.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusica8.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusica8.Content = "Play";
            }
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (btmusica9.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/QyJa70OV3oWzpeRi/10%20-%20Sono%20Profundo.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusica9.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusica9.Content = "Play";
            }
        }
        #endregion

        #region Rio

        private void ButtonRio1_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaRio1.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/0o7UXs8Ud9E0j9aZ/01-Fresno-Orgulho.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaRio1.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaRio1.Content = "Play";
            }
        }

        private void ButtonRio2_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaRio2.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/CsGmHCPkqFu4W1Ya/02-Fresno-Onde_Esta.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaRio2.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaRio2.Content = "Play";
            }
        }

        private void ButtonRio3_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaRio3.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/8hxjml3ZRrwvueVR/03-Fresno-Experiencia.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaRio3.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaRio3.Content = "Play";
            }
        }

        private void ButtonRio4_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaRio4.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/wtvWJPEFq1bbuJsl/04-Fresno-O_Que_Sobrou.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaRio4.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaRio4.Content = "Play";
            }
        }

        private void ButtonRio5_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaRio5.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/g3hIjozutbhDigra/05-Fresno-Verdades_Que_Tanto_Guardei.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaRio5.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaRio5.Content = "Play";
            }
        }

        private void ButtonRio6_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaRio6.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/hXsmPgxqLbnGtrqB/06-Fresno-Duas_Lagrimas.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaRio6.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaRio6.Content = "Play";
            }
        }

        private void ButtonRio7_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaRio7.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/tjXfhPw0QZuKc1UT/07-Fresno-Impossibilidades.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaRio7.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaRio7.Content = "Play";
            }
        }

        private void ButtonRio8_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaRio8.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/DpbM1zcs7BqFDie4/08-Fresno-Velha_Historia.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaRio8.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaRio8.Content = "Play";
            }
        }

        private void ButtonRio9_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaRio9.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/yAdmz9uFfrM78lCh/09-Fresno-Planos_E_Promessas.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaRio9.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaRio9.Content = "Play";
            }
        }

        private void ButtonRio10_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaRio10.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/pTmMjwrXsTQfJShN/10-Fresno-Evaporar.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaRio10.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaRio10.Content = "Play";
            }
        }

        private void ButtonRio11_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaRio11.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/bMQsRIn7iUh29LqC/11-Fresno-Outra_Vez.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaRio11.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaRio11.Content = "Play";
            }
        }

        private void ButtonRio12_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaRio12.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/JykSbxNTlMpPVuhr/12-Fresno-Pergunta.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaRio12.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaRio12.Content = "Play";
            }
        }
        #endregion

        #region Ciano

        private void ButtonCiano1_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaCiano1.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/L1qHvYU68WBSOY6i/01%20A%20Resposta.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaCiano1.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaCiano1.Content = "Play";
            }
        }

        private void ButtonCiano2_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaCiano2.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/BdmMGVIoutZkgint/02%20Quebre%20As%20Correntes.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaCiano2.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaCiano2.Content = "Play";
            }
        }

        private void ButtonCiano3_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaCiano3.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/yC29va6S6Lly9rju/03%20O%20Que%20Hoje%20Voc%C3%AA%20V%C3%AA.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaCiano3.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaCiano3.Content = "Play";
            }
        }

        private void ButtonCiano4_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaCiano4.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/Oti43XMvjozi88u0/04%20Absolutamente%20Nada.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaCiano4.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaCiano4.Content = "Play";
            }
        }

        private void ButtonCiano5_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaCiano5.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/vcGPrcNO3FDzDYai/05%20Cada%20Po%C3%A7a%20Dessa%20Rua%20Tem%20Um%20Pouco%20de%20Minhas%20L%C3%A1grimas.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaCiano5.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaCiano5.Content = "Play";
            }
        }

        private void ButtonCiano6_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaCiano6.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/CrFRetBlYhZhzsBl/06%20Logo%20Voc%C3%AA.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaCiano6.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaCiano6.Content = "Play";
            }
        }

        private void ButtonCiano7_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaCiano7.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/NL4DxvYmwwM6MvmC/07%20O%20Peso%20Do%20Mundo.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaCiano7.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaCiano7.Content = "Play";
            }
        }

        private void ButtonCiano8_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaCiano8.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/auYs2ZGAMSCtpOKS/08%20Algu%C3%A9m%20Que%20Te%20Faz%20Sorrir.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaCiano8.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaCiano8.Content = "Play";
            }
        }

        private void ButtonCiano9_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaCiano9.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/RW0LZyG39ROmPktZ/09%20Soneto%20Para%20Petr%20Cech.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaCiano9.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaCiano9.Content = "Play";
            }
        }

        private void ButtonCiano10_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaCiano10.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/Esq7KV4LIx2MWHkD/10%20Enferrujou.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaCiano10.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaCiano10.Content = "Play";
            }
        }

        private void ButtonCiano11_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaCiano11.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/dEDxBbYRRVojL2R3/11%20Inf%C3%A2ncia.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaCiano11.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaCiano11.Content = "Play";
            }
        }

        private void ButtonCiano12_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaCiano12.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/uKddgFjN21TV7spb/12%20Teu%20Semblante.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaCiano12.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaCiano12.Content = "Play";
            }
        }

        private void ButtonCiano13_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaCiano13.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/INhiExC8NwzaTzau/13%20Stonehenge.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaCiano13.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaCiano13.Content = "Play";
            }
        }

        private void ButtonCiano14_Click(object sender, RoutedEventArgs e)
        {
            if (btmusicaCiano14.Content.ToString() == "Play")
            {
                MediaPlayer.Source = new Uri("https://copy.com/NvynQnZlK8oWBWiu/14%20Sono%20Profundo.mp3?download=1", UriKind.Absolute);
                MediaPlayer.Play();
                btmusicaCiano14.Content = "Stop";
            }
            else
            {
                MediaPlayer.Stop();
                btmusicaCiano14.Content = "Play";
            }
        }


        #endregion

    }
}