﻿using System;
using System.Collections.Generic;
using System.IO;
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
            if (!IsPostBack)
            {
                txt.Text = sample_html.Basic;
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

        void LoadFile(string filename)
        {
            string html = File.ReadAllText(Server.MapPath($"~/sample_html/{filename}.html"));
            txt.Text = html;
        }

        protected void btLoadBasic_Click(object sender, EventArgs e)
        {
            LoadFile("basic");
        }

        protected void btLoadInvoice1_Click(object sender, EventArgs e)
        {
            LoadFile("invoice1");
        }

        protected void btLoadInvoice2_Click(object sender, EventArgs e)
        {
            LoadFile("invoice2");
        }

        protected void btLoadInvoice3_Click(object sender, EventArgs e)
        {
            LoadFile("invoice3");
        }

        protected void btLoadInvoice4_Click(object sender, EventArgs e)
        {
            LoadFile("invoice4");
        }

        protected void btLoadForm1_Click(object sender, EventArgs e)
        {
            LoadFile("form1");
        }
    }
}