<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="pdf_chrome.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <h2>The Basic Idea</h2>
    Run/Execute the Chrome.exe program with arguments/switches
    <pre lang="text">
chrome.exe

// arguments:
--headless
--disable-gpu
--run-all-compositor-stages-before-draw
--print-to-pdf="{filePath}"
{url}
    </pre>
    Example:
    <pre lang="text">
        C:\Program Files\Google\Chrome\Application\chrome.exe --headless --disable-gpu --run-all-compositor-stages-before-draw --print-to-pdf="D:\test\web_pdf\pdf_chrome\temp\pdf\345555635.pdf" http://localhost:55977/temp/pdf/345555635.html
    </pre>
</body>
</html>
