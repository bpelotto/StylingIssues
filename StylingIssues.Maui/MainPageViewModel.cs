using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using StylingIssues.Maui.models;

namespace StylingIssues.Maui
{
	public class MainPageViewModel : BindableObject
	{
        private ObservableCollection<OrderHistory> orderHistoryList = new ObservableCollection<OrderHistory>();

        public ObservableCollection<OrderHistory> OrderHistoryList
        {
            get => orderHistoryList;
            set
            {
                orderHistoryList = value;
                OnPropertyChanged(nameof(OrderHistoryList));
            }
        }

        private string emptyViewText = "No Order History";

        public string EmptyViewText
        {
            get => emptyViewText;
            set
            {
                emptyViewText = value;
                OnPropertyChanged(nameof(EmptyViewText));
            }
        }


        public MainPageViewModel()
        {


            RefreshCommand = new Command(LoadOrderHistory);
            OpenOrderPdfCommand = new Command<string>(OpenOrderPdfAsync);

            LoadOrderHistory();
        }

        public ICommand RefreshCommand { get; }
        public ICommand OpenOrderPdfCommand { get; }

        private void LoadOrderHistory()
        {
            OrderHistoryList = new ObservableCollection<OrderHistory>()
            {
                new OrderHistory()
                {
                    CreatedOn = DateTime.UtcNow,
                    Total = 100.00
                }
            };
        }

        private void OpenOrderPdfAsync(string orderNumber)
        {

        }
    }
}

