using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Fresno.Endidades;
using Fresno.Repositorio;

namespace Fresno
{
    public partial class Favoritos : PhoneApplicationPage
    {
        FeedItem feed;
        public Favoritos()
        {
            InitializeComponent();
            Refresh();
        }

        private void onSelecionChange(object sender, SelectionChangedEventArgs e)
        {
            feed = null;
            feed = (sender as ListBox).SelectedItem as FeedItem;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            Internet page = e.Content as Internet;
            if (page != null)
                page.paginas = feed;
            Refresh();

        }

        private void Navigate(string pPage)
        {
            NavigationService.Navigate(new Uri(pPage, UriKind.Relative));
        }

        private void abrirBrowser_Click(object sender, EventArgs e)
        {
            if (feed != null)
            {
                Navigate("/Internet.xaml");
            }
            else
            {
                if (MessageBox.Show("Você deve selecionar uma noticia primeiro! ;)")
                    == MessageBoxResult.OK)
                { }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (feed != null)
            {
                if (MessageBox.Show("Você deseja excluir esta noticia? =O")
                    == MessageBoxResult.OK)
                {
                    FeedsRepositorio.Delete(feed);
                    if (MessageBox.Show("Excluido com sucesso! ;)")
                    == MessageBoxResult.OK)
                    { }
                    Refresh();
                }
            }
            else
            {
                if (MessageBox.Show("Você deve selecionar uma noticia primeiro!")
                    == MessageBoxResult.OK)
                { }
            }
            Refresh();
        }

        private void Refresh()
        {
            List<FeedItem> feeds = FeedsRepositorio.Get();
            LstFavoritos.ItemsSource = feeds;
        }
    }
}