using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace RaspberryPi.Objects
{
    class BaseObj
    {
        public SolidColorBrush ErrorLightColor = new SolidColorBrush(Windows.UI.Colors.Red);
        public SolidColorBrush OperationLightColor = new SolidColorBrush(Windows.UI.Colors.Green);

        /// <summary>
        /// 回報狀態用的文字顯示物件
        /// </summary>
        public TextBlock StatusTextBlock { get; set; }
        /// <summary>
        /// 回報狀態用的燈號物件
        /// </summary>
        public Ellipse StatusEllipse { get; set; }
        /// <summary>
        /// 最後成功時間
        /// </summary>
        public TextBlock StatusLastTime { get; set; }

        public void SetError(string strErrorMessage)
        {
            this.StatusEllipse.Fill = this.ErrorLightColor;
            this.StatusTextBlock.Text = strErrorMessage;
        }

        public void SetOperation(string strOperationMessage, DateTime dtLast)
        {
            this.StatusEllipse.Fill = this.OperationLightColor;
            this.StatusTextBlock.Text = strOperationMessage;
            this.StatusLastTime.Text = dtLast.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
