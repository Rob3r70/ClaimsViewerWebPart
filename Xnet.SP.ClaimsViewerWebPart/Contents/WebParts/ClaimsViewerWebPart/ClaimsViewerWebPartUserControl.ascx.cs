using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Xnet.SP.ClaimsViewerWebPart.Contents.Classes;
using System.Security.Claims;

namespace Xnet.SP.ClaimsViewerWebPart.ClaimsViewerWebPart
{
    public partial class ClaimsViewerWebPartUserControl : UserControl
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
            ClaimsIdentity identity = (Thread.CurrentPrincipal as ClaimsPrincipal).Identity as ClaimsIdentity;

            //IClaimsIdentity identity = (Thread.CurrentPrincipal as IClaimsPrincipal).Identity as IClaimsIdentity;
            IList<ClaimEntity> list = (IList<ClaimEntity>)new List<ClaimEntity>();
            foreach (Claim claim in identity.Claims)
                list.Add(new ClaimEntity()
                {
                    ClaimType = claim.Type,
                    Value = claim.Value,
                    ValueType = claim.ValueType
                });
            this.RefreshGrid(list);
        }

        private void RefreshGrid(IList<ClaimEntity> list)
        {
            this.ClaimsGridView.DataSource = (object)null;
            this.ClaimsGridView.DataSource = (object)list;
            this.ClaimsGridView.DataBind();
        }
    }
}
