<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="pdf_chrome.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script async src="https://www.googletagmanager.com/gtag/js?id=G-CGCZ1LFMRL"></script>
    <script>
        window.dataLayer = window.dataLayer || [];
        function gtag() { dataLayer.push(arguments); }
        gtag('js', new Date());

        gtag('config', 'G-CGCZ1LFMRL');
    </script>

    <title></title>
    <style type="text/css">
        body {
            font-size: 12pt;
        }

        h1 {
            padding: 10px 0;
            margin: auto;
            margin-bottom: 10px;
            border-bottom: 1px solid #b5b5b5;
        }

        .page {
            width: 100%;
            max-width: 1000px;
            margin: auto;
        }

        textarea {
            font-family: "Cascadia Mono", Consolas, "Courier New", Courier, monospace;
            font-weight: bold;
            font-size: 10pt;
            color: #5b5b5b;
            height: calc(100vh - 320px);
            width: 95%;
            margin-top: 10px;
            padding: 10px;
        }

        .divLoading {
            width: 360px;
            font-size: 20pt;
            font-style: italic;
            font-family: Arial;
            z-index: 9;
            position: fixed;
            top: calc(50vh - 160px);
            left: calc(50vw - 180px);
            border: 10px solid #7591ef;
            border-radius: 25px;
            padding: 10px;
            text-align: center;
            background: #dce5ff;
            display: none;
            font-weight: bold;
        }
    </style>

    <script type="text/javascript">
        function showLoading() {
            let d = document.getElementById("divLoading");
            d.style.display = "block";
            setTimeout(hideLoading, 2000);
        }

        function hideLoading() {
            let d = document.getElementById("divLoading");
            d.style.display = "none";
        }
    </script>
</head>
<body>

    <div class="page">

        <h1>Convert HTML to PDF by Using Chrome in ASP.NET</h1>

        Project Site: <a href="https://github.com/adriancs2/HTML-PDF-Chrome">github.com</a> &nbsp; &nbsp; &nbsp;
        Tutorial: <a href="https://adriancs.com/aspnet-webforms/433/convert-html-to-pdf-with-chrome-in-asp-net-webforms/">adriancs.com</a> | <a href="https://www.codeproject.com/Articles/5347275/Convert-HTML-to-PDF-with-Chrome-in-ASP-NET-WebForm">CodeProject.com</a>

        <br />
        <br />

        <form id="form1" runat="server">
            <asp:Button ID="btGeneratePdfAttachment" runat="server" Text="Generate PDF (download as attachment)" OnClick="btGeneratePdfAttachment_Click" OnClientClick="showLoading();" />
            <asp:Button ID="btGeneratePdfInline" runat="server" Text="Generate PDF (display as inline)" OnClick="btGeneratePdfInline_Click" OnClientClick="showLoading();" />
            <asp:Button ID="btPreview" runat="server" Text="Preview HTML Rendering" OnClick="btPreview_Click" /><br />
            <br />
            Load Sample HTML:
        <asp:Button ID="btLoadBasic" runat="server" Text="Basic" OnClick="btLoadBasic_Click" />
            <asp:Button ID="btLoadInvoice1" runat="server" Text="Invoice 1" OnClick="btLoadInvoice1_Click" />
            <asp:Button ID="btLoadInvoice2" runat="server" Text="Invoice 2" OnClick="btLoadInvoice2_Click" />
            <asp:Button ID="btLoadInvoice3" runat="server" Text="Invoice 3" OnClick="btLoadInvoice3_Click" />
            <asp:Button ID="btLoadInvoice4" runat="server" Text="Invoice 4" OnClick="btLoadInvoice4_Click" />
            <asp:Button ID="btLoadForm1" runat="server" Text="Form 1" OnClick="btLoadForm1_Click" /><br />

            <br />

            Acknowledgement of The Origin of HTML Sample, Special Thanks to: <a href="https://htmlpdfapi.com/blog/free_html5_invoice_templates">htmlpdfapi.com</a> and Document Templates provided by Microsoft Word 2021.

        <br />
            <br />

            Edit HTML Here:
        <asp:TextBox ID="txt" runat="server" TextMode="MultiLine" spellcheck="false" ValidateRequestMode="Disabled"></asp:TextBox>
        </form>



        <div id="divLoading" class="divLoading" onclick="hideLoading();">
            <img src="loading.gif" /><br />
            Generating PDF...
        </div>

    </div>
</body>
</html>
