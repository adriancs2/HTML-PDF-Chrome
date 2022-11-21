using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pdf_chrome
{
    public class sample_html
    {
		public static string Basic = @"<!DOCTYPE html>
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

        public static string Invoice1 = @"
<html>
	<head>
		<meta charset=""utf-8"">
		<title>Invoice</title>
		<style type=""text/css"">
			/* reset */

			*
			{
				border: 0;
				box-sizing: content-box;
				color: inherit;
				font-family: inherit;
				font-size: inherit;
				font-style: inherit;
				font-weight: inherit;
				line-height: inherit;
				list-style: none;
				margin: 0;
				padding: 0;
				text-decoration: none;
				vertical-align: top;
			}

			/* content editable */

			*[contenteditable] { border-radius: 0.25em; min-width: 1em; outline: 0; }

			*[contenteditable] { cursor: pointer; }

			*[contenteditable]:hover, *[contenteditable]:focus, td:hover *[contenteditable], td:focus *[contenteditable], img.hover { background: #DEF; box-shadow: 0 0 1em 0.5em #DEF; }

			span[contenteditable] { display: inline-block; }

			/* heading */

			h1 { font: bold 100% sans-serif; letter-spacing: 0.5em; text-align: center; text-transform: uppercase; }

			/* table */

			table { font-size: 75%; table-layout: fixed; width: 100%; }
			table { border-collapse: separate; border-spacing: 2px; }
			th, td { border-width: 1px; padding: 0.5em; position: relative; text-align: left; }
			th, td { border-radius: 0.25em; border-style: solid; }
			th { background: #EEE; border-color: #BBB; }
			td { border-color: #DDD; }

			/* page */

			html { font: 16px/1 'Open Sans', sans-serif; overflow: auto; padding: 0.5in; }
			html { background: #999; cursor: default; }

			body { box-sizing: border-box; height: 11in; margin: 0 auto; overflow: hidden; padding: 0.5in; width: 8.5in; }
			body { background: #FFF; border-radius: 1px; box-shadow: 0 0 1in -0.25in rgba(0, 0, 0, 0.5); }

			/* header */

			header { margin: 0 0 3em; }
			header:after { clear: both; content: """"; display: table; }

			header h1 { background: #000; border-radius: 0.25em; color: #FFF; margin: 0 0 1em; padding: 0.5em 0; }
			header address { float: left; font-size: 75%; font-style: normal; line-height: 1.25; margin: 0 1em 1em 0; }
			header address p { margin: 0 0 0.25em; }
			header span, header img { display: block; float: right; }
			header span { margin: 0 0 1em 1em; max-height: 25%; max-width: 60%; position: relative; }
			header img { max-height: 100%; max-width: 100%; }
			header input { cursor: pointer; -ms-filter:""progid:DXImageTransform.Microsoft.Alpha(Opacity=0)""; height: 100%; left: 0; opacity: 0; position: absolute; top: 0; width: 100%; }

			/* article */

			article, article address, table.meta, table.inventory { margin: 0 0 3em; }
			article:after { clear: both; content: """"; display: table; }
			article h1 { clip: rect(0 0 0 0); position: absolute; }

			article address { float: left; font-size: 125%; font-weight: bold; }

			/* table meta & balance */

			table.meta, table.balance { float: right; width: 36%; }
			table.meta:after, table.balance:after { clear: both; content: """"; display: table; }

			/* table meta */

			table.meta th { width: 40%; }
			table.meta td { width: 60%; }

			/* table items */

			table.inventory { clear: both; width: 100%; }
			table.inventory th { font-weight: bold; text-align: center; }

			table.inventory td:nth-child(1) { width: 26%; }
			table.inventory td:nth-child(2) { width: 38%; }
			table.inventory td:nth-child(3) { text-align: right; width: 12%; }
			table.inventory td:nth-child(4) { text-align: right; width: 12%; }
			table.inventory td:nth-child(5) { text-align: right; width: 12%; }

			/* table balance */

			table.balance th, table.balance td { width: 50%; }
			table.balance td { text-align: right; }

			/* aside */

			aside h1 { border: none; border-width: 0 0 1px; margin: 0 0 1em; }
			aside h1 { border-color: #999; border-bottom-style: solid; }

			/* javascript */

			.add, .cut
			{
				border-width: 1px;
				display: block;
				font-size: .8rem;
				padding: 0.25em 0.5em;	
				float: left;
				text-align: center;
				width: 0.6em;
			}

			.add, .cut
			{
				background: #9AF;
				box-shadow: 0 1px 2px rgba(0,0,0,0.2);
				background-image: -moz-linear-gradient(#00ADEE 5%, #0078A5 100%);
				background-image: -webkit-linear-gradient(#00ADEE 5%, #0078A5 100%);
				border-radius: 0.5em;
				border-color: #0076A3;
				color: #FFF;
				cursor: pointer;
				font-weight: bold;
				text-shadow: 0 -1px 2px rgba(0,0,0,0.333);
			}

			.add { margin: -2.5em 0 0; }

			.add:hover { background: #00ADEE; }

			.cut { opacity: 0; position: absolute; top: 0; left: -1.5em; }
			.cut { -webkit-transition: opacity 100ms ease-in; }

			tr:hover .cut { opacity: 1; }

			@media print {
				* { -webkit-print-color-adjust: exact; }
				html { background: none; padding: 0; }
				body { box-shadow: none; margin: 0; }
				span:empty { display: none; }
				.add, .cut { display: none; }
			}

			@page { margin: 0; }
		</style>
		<link rel=""license"" href=""https://www.opensource.org/licenses/mit-license/"">
		<script src=""script.js""></script>
	</head>
	<body>
		<header>
			<h1>Invoice</h1>
			<address contenteditable>
				<p>Jonathan Neal</p>
				<p>101 E. Chapman Ave<br>Orange, CA 92866</p>
				<p>(800) 555-1234</p>
			</address>
			<span><img alt="""" src=""http://www.jonathantneal.com/examples/invoice/logo.png""><input type=""file"" accept=""image/*""></span>
		</header>
		<article>
			<h1>Recipient</h1>
			<address contenteditable>
				<p>Some Company<br>c/o Some Guy</p>
			</address>
			<table class=""meta"">
				<tr>
					<th><span contenteditable>Invoice #</span></th>
					<td><span contenteditable>101138</span></td>
				</tr>
				<tr>
					<th><span contenteditable>Date</span></th>
					<td><span contenteditable>January 1, 2012</span></td>
				</tr>
				<tr>
					<th><span contenteditable>Amount Due</span></th>
					<td><span id=""prefix"" contenteditable>$</span><span>600.00</span></td>
				</tr>
			</table>
			<table class=""inventory"">
				<thead>
					<tr>
						<th><span contenteditable>Item</span></th>
						<th><span contenteditable>Description</span></th>
						<th><span contenteditable>Rate</span></th>
						<th><span contenteditable>Quantity</span></th>
						<th><span contenteditable>Price</span></th>
					</tr>
				</thead>
				<tbody>
					<tr>
						<td><a class=""cut"">-</a><span contenteditable>Front End Consultation</span></td>
						<td><span contenteditable>Experience Review</span></td>
						<td><span data-prefix>$</span><span contenteditable>150.00</span></td>
						<td><span contenteditable>4</span></td>
						<td><span data-prefix>$</span><span>600.00</span></td>
					</tr>
					<tr>
						<td><a class=""cut"">-</a><span contenteditable>Front End Consultation</span></td>
						<td><span contenteditable>Experience Review</span></td>
						<td><span data-prefix>$</span><span contenteditable>150.00</span></td>
						<td><span contenteditable>4</span></td>
						<td><span data-prefix>$</span><span>600.00</span></td>
					</tr>
					<tr>
						<td><a class=""cut"">-</a><span contenteditable>Front End Consultation</span></td>
						<td><span contenteditable>Experience Review</span></td>
						<td><span data-prefix>$</span><span contenteditable>150.00</span></td>
						<td><span contenteditable>4</span></td>
						<td><span data-prefix>$</span><span>600.00</span></td>
					</tr>
					<tr>
						<td><a class=""cut"">-</a><span contenteditable>Front End Consultation</span></td>
						<td><span contenteditable>Experience Review</span></td>
						<td><span data-prefix>$</span><span contenteditable>150.00</span></td>
						<td><span contenteditable>4</span></td>
						<td><span data-prefix>$</span><span>600.00</span></td>
					</tr>
				</tbody>
			</table>
			<a class=""add"">+</a>
			<table class=""balance"">
				<tr>
					<th><span contenteditable>Total</span></th>
					<td><span data-prefix>$</span><span>600.00</span></td>
				</tr>
				<tr>
					<th><span contenteditable>Amount Paid</span></th>
					<td><span data-prefix>$</span><span contenteditable>0.00</span></td>
				</tr>
				<tr>
					<th><span contenteditable>Balance Due</span></th>
					<td><span data-prefix>$</span><span>600.00</span></td>
				</tr>
			</table>
		</article>
		<aside>
			<h1><span contenteditable>Additional Notes</span></h1>
			<div contenteditable>
				<p>A finance charge of 1.5% will be made on unpaid balances after 30 days.</p>
			</div>
		</aside>
	</body>
</html>
";

		public static string Invoice2 = @"
<!DOCTYPE html>
<html lang=""en"">
  <head>
    <meta charset=""utf-8"">
    <title>Example 1</title>
    <link rel=""stylesheet"" href=""style.css"" media=""all"" />
  </head>
  <body>
    <header class=""clearfix"">
      <div id=""logo"">
        <img src=""logo.png"">
      </div>
      <h1>INVOICE 3-2-1</h1>
      <div id=""company"" class=""clearfix"">
        <div>Company Name</div>
        <div>455 Foggy Heights,<br /> AZ 85004, US</div>
        <div>(602) 519-0450</div>
        <div><a href=""mailto:company@example.com"">company@example.com</a></div>
      </div>
      <div id=""project"">
        <div><span>PROJECT</span> Website development</div>
        <div><span>CLIENT</span> John Doe</div>
        <div><span>ADDRESS</span> 796 Silver Harbour, TX 79273, US</div>
        <div><span>EMAIL</span> <a href=""mailto:john@example.com"">john@example.com</a></div>
        <div><span>DATE</span> August 17, 2015</div>
        <div><span>DUE DATE</span> September 17, 2015</div>
      </div>
    </header>
    <main>
      <table>
        <thead>
          <tr>
            <th class=""service"">SERVICE</th>
            <th class=""desc"">DESCRIPTION</th>
            <th>PRICE</th>
            <th>QTY</th>
            <th>TOTAL</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td class=""service"">Design</td>
            <td class=""desc"">Creating a recognizable design solution based on the company's existing visual identity</td>
            <td class=""unit"">$40.00</td>
            <td class=""qty"">26</td>
            <td class=""total"">$1,040.00</td>
          </tr>
          <tr>
            <td class=""service"">Development</td>
            <td class=""desc"">Developing a Content Management System-based Website</td>
            <td class=""unit"">$40.00</td>
            <td class=""qty"">80</td>
            <td class=""total"">$3,200.00</td>
          </tr>
          <tr>
            <td class=""service"">SEO</td>
            <td class=""desc"">Optimize the site for search engines (SEO)</td>
            <td class=""unit"">$40.00</td>
            <td class=""qty"">20</td>
            <td class=""total"">$800.00</td>
          </tr>
          <tr>
            <td class=""service"">Training</td>
            <td class=""desc"">Initial training sessions for staff responsible for uploading web content</td>
            <td class=""unit"">$40.00</td>
            <td class=""qty"">4</td>
            <td class=""total"">$160.00</td>
          </tr>
          <tr>
            <td colspan=""4"">SUBTOTAL</td>
            <td class=""total"">$5,200.00</td>
          </tr>
          <tr>
            <td colspan=""4"">TAX 25%</td>
            <td class=""total"">$1,300.00</td>
          </tr>
          <tr>
            <td colspan=""4"" class=""grand total"">GRAND TOTAL</td>
            <td class=""grand total"">$6,500.00</td>
          </tr>
        </tbody>
      </table>
      <div id=""notices"">
        <div>NOTICE:</div>
        <div class=""notice"">A finance charge of 1.5% will be made on unpaid balances after 30 days.</div>
      </div>
    </main>
    <footer>
      Invoice was created on a computer and is valid without the signature and seal.
    </footer>
  </body>
</html>";
    }
}