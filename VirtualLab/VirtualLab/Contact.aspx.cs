using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtualLab
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidateControls();
        }

        public void ValidateControls() 
        { 
            //This method will validate all the controls
        }
    }
}