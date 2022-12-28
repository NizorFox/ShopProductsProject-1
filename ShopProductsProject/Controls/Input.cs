using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ShopProductsProject.Controls
{
    public class Input:TextBox
    {
        public string Placeholder { get; set; }
        public Input()
        {
            Loaded += AddText;
            GotFocus += RemoveText;
        }
        /// <summary>
        /// Действие при фокусировке на элементе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveText(object sender, System.Windows.RoutedEventArgs e)
        {
            if (Text==Placeholder)
            {
                Text = "";
            }
        }
        /// <summary>
        /// Действие в случае, если в поле ничего не вводится
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddText(object sender, System.Windows.RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Text))
            {
                Text = Placeholder;
            }
        }


    }
}
