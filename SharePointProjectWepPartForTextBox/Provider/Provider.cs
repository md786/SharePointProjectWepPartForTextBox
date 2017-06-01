using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace SharePointProjectWepPartForTextBox.Provider
{
    [ToolboxItemAttribute(false)]
    public class Provider : WebPart,ITextBox
    {
        private Button button;
        private TextBox textbox;
        

        public string TextConsumer {
            get => textbox.Text ;
            set => textbox.Text = value;
        }

        protected override void CreateChildControls()
        {
            textbox = new TextBox();
            textbox.Text = "hello";
            button = new Button();
            button.Click += Button_Click;
            button.Text = "button submit";
          
            this.Controls.Add(textbox);
            this.Controls.Add(button);
           
        }

        private void Button_Click(object sender, EventArgs e)
        {
            TextConsumer = textbox.Text;
           
         
        }
        [ConnectionProvider("Provider")]
        public ITextBox Message()
        {
            return this;
        }



    }
}
