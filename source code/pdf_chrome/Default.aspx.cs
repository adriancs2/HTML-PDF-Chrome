using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pdf_chrome
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                txt.Text = @"<!DOCTYPE html>
<html lang=""en"">

<head>
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <style type=""text/css"">
        h1 {
            margin: 0;
            padding: 0;
        }
        .page {
            margin: auto;
            margin-top: 10mm;
            border: 1px solid black;
            width: 18cm;
            height: 27cm;
        }

        @page {
            margin: 0;
            size: A4 portrait;
        }
    </style>
</head>

<body>

    <div class=""page"">
        <h1>Page 1</h1>
        <img src=""/pdf.jpg"" style=""width: 100%; height: auto;"" />
    </div>

    <div style=""page-break-after: always""></div>

    <div class=""page"">
        <h1>Page 2</h1>
        <img src=""/pdf.jpg"" style=""width: 100%; height: auto;"" />
    </div>

    <div style=""page-break-after: always""></div>

    <div class=""page"">
        <h1>Page 3</h1>
        <img src=""/pdf.jpg"" style=""width: 100%; height: auto;"" />
    </div>

</body>

</html>";
            }
        }

        protected void btGenerate_Click(object sender, EventArgs e)
        {

        }

        protected void btPreview_Click(object sender, EventArgs e)
        {
            string html = txt.Text;

            Response.Clear();
            Response.Write(html);
            Response.End();
        }

        protected void btGeneratePdfAttachment_Click(object sender, EventArgs e)
        {
            pdf.GeneratePdfAttachment(txt.Text, "file.pdf");
        }

        protected void btGeneratePdfInline_Click(object sender, EventArgs e)
        {
            pdf.GeneratePdfInline(txt.Text);
        }
    }
}