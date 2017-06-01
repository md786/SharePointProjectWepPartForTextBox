using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace SharePointProjectWepPartForTextBox.Consumer
{
    [ToolboxItemAttribute(false)]
    public class Consumer : WebPart
    {
        Label label;
        ITextBox _textbox;

        protected override void CreateChildControls()
        {
            label = new Label();
            label.Text = _textbox.TextConsumer;
            this.Controls.Add(label);
        }
        [ConnectionConsumer("Provider")]
        public void Recive(ITextBox itextbox)
        {
            this._textbox = itextbox;
        }
    }
}
