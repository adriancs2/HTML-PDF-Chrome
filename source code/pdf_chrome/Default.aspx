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

        textarea {
            font-family: "Cascadia Mono", Consolas, "Courier New", Courier, monospace;
            font-weight: bold;
            font-size: 10pt;
            color: #5b5b5b;
            height: calc(100vh - 200px);
            width: calc(100vw - 60px);
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
            top: calc(50vh - 150px);
            left: calc(50vw - 130px);
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

    <h1>Convert HTML to PDF by Using Chrome</h1>

    Tutorial: <a href="https://adriancs.com/aspnet-webforms/433/convert-html-to-pdf-with-chrome-in-asp-net-webforms/">adriancs.com</a> | <a href="https://www.codeproject.com/Articles/5347275/Convert-HTML-to-PDF-with-Chrome-in-ASP-NET-WebForm">CodeProject.com</a>

    <br />
    <br />

    <form id="form1" runat="server">
        <asp:Button ID="btGeneratePdfAttachment" runat="server" Text="Generate PDF (download as attachment)" OnClick="btGeneratePdfAttachment_Click" OnClientClick="showLoading();" />
        <asp:Button ID="btGeneratePdfInline" runat="server" Text="Generate PDF (display as inline)" OnClick="btGeneratePdfInline_Click" OnClientClick="showLoading();" />
        <asp:Button ID="btPreview" runat="server" Text="Preview HTML Rendering" OnClick="btPreview_Click" />
        <asp:TextBox ID="txt" runat="server" TextMode="MultiLine" spellcheck="false" ValidateRequestMode="Disabled"></asp:TextBox>
    </form>

    <div id="divLoading" class="divLoading" onclick="hideLoading();">
        <img src="loading.gif" /><br />
        Generating PDF...
    </div>

</body>
</html>
