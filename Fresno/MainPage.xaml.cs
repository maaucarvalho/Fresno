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
using Fresno.Endidades;
using Fresno.Repositorio;
using System.Windows.Navigation;
using System.Xml.Linq;

namespace Fresno
{
    public partial class MainPage : PhoneApplicationPage
    {
        FeedItem feed;
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            List<FeedItem> feeds = FeedsRepositorio.Get();

            WebClient rssClient = new WebClient();
            rssClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(rssClient_DonloadStringCompleted);

            rssClient.Encoding = System.Text.Encoding.GetEncoding("ISO8859-1");

            rssClient.DownloadStringAsync(new Uri(
                @"http://www.territoriodamusica.com/rss/agendaRock.xml"));

        }

        void rssClient_DonloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            var RssItem = from rss in XElement.Parse(e.Result).Descendants("item")
                          select new FeedItem
                          {
                              Title = rss.Element("title").Value,
                              Description = rss.Element("description").Value,
                              PubDate = rss.Element("pubDate").Value,
                              Link = rss.Element("link").Value
                          };
            LstItem.ItemsSource = RssItem;
        }

        private void Navigate(string pPage)
        {
            NavigationService.Navigate(new Uri(pPage, UriKind.Relative));
        }

        private void onSelectionChange(object sender, SelectionChangedEventArgs e)
        {
            feed = null;
            feed = (sender as ListBox).SelectedItem as FeedItem;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            Internet page = e.Content as Internet;
            if (page != null)
                page.paginas = feed;
        }

        private void noticias_Click(object sender, EventArgs e)
        {
            if (feed != null)
            {
                Navigate("/Internet.xaml");
            }
            else
            {
                if (MessageBox.Show("Selecione uma Noticia!!!")
                    == MessageBoxResult.OK)
                { }
            }
        }

        private void twitter_Click(object sender, EventArgs e)
        {
            Navigate("/twitterPivo.xaml");
        }

        private void musicas_Click(object sender, EventArgs e)
        {
            Navigate("/musicasPivo.xaml");
        }

        private void sobre_Click(object sender, EventArgs e)
        {
            Navigate("/Sobre.xaml");
        }
    }
}