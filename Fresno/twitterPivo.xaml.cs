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
using System.Xml.Linq;
using Fresno.Endidades;
using System.Windows.Navigation;
using Fresno.Repositorio;
using System.Collections;

namespace Fresno
{
    public partial class twitterPivo : PhoneApplicationPage
    {
        FeedTwitter feedt;
        public twitterPivo()
        {
            InitializeComponent();
        }

        private void Pivot_LoadedPivotItem(object sender, PivotItemEventArgs e)
        {
            WebClient RssClient = new WebClient();
            RssClient.DownloadStringCompleted += RssClient_DownloadStringCompleted;
            if (e.Item == FresnoB)
                RssClient.DownloadStringAsync(new Uri(@"http://twitrss.me/twitter_user_to_rss/?user=fresnorock"));
            else if (e.Item == Lucas)
                RssClient.DownloadStringAsync(new Uri(@"http://twitrss.me/twitter_user_to_rss/?user=lucasfresno"));
            else if (e.Item == Vavo)
                RssClient.DownloadStringAsync(new Uri(@"http://twitrss.me/twitter_user_to_rss/?user=vavofresno"));
            else if (e.Item == Guerra)
                RssClient.DownloadStringAsync(new Uri(@"http://twitrss.me/twitter_user_to_rss/?user=guerrafresno"));
            else
                RssClient.DownloadStringAsync(new Uri(@"http://twitrss.me/twitter_user_to_rss/?user=mariofresno"));
        }

        void RssClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                var RssData = from rss in XElement.Parse(e.Result).Descendants("item")
                              select new FeedTwitter
                              {
                                  Title = rss.Element("title").Value,
                                  PubDate = rss.Element("pubDate").Value,
                                  Link = rss.Element("link").Value
                              };
                LstFresno.ItemsSource = RssData;
                LstLucas.ItemsSource = RssData;
                LstVavo.ItemsSource = RssData;
                LstGuerra.ItemsSource = RssData;
                LstMario.ItemsSource = RssData;


            }
            catch (Exception)
            {
                if (MessageBox.Show("Vish!!! \n Você está sem conexão com a internet! ;/")
                   == MessageBoxResult.OK)
                { }
                InitializeComponent();
            }

        }

        private void onSelecionChange(object sender, SelectionChangedEventArgs e)
        {
            feedt = null;
            feedt = (sender as ListBox).SelectedItem as FeedTwitter;
        }

        private void Navigate(string pPage)
        {
            NavigationService.Navigate(new Uri(pPage, UriKind.Relative));
        } 
    }
}