using Hinzberg.HTMLToolbox;

HTMLDocument document = new HTMLDocument();

Headline headline = new Headline(@"HTML Toolbox");
document.Add(headline);

// Unordered List
Headline headlineUnorderedList = new Headline(@"Unordered List", HeadlineSize.Size2);
document.Add(headlineUnorderedList);

UnorderedList unorderedList = new UnorderedList();
unorderedList.Add(new ListItem(@"Unordered List Entry 1"));
unorderedList.Add(new ListItem(@"Unordered List Entry 2"));
unorderedList.Add(new ListItem(@"Unordered List Entry 3"));
document.Add(unorderedList);

// Ordered List
Headline headlineOrderedList = new Headline(@"Ordered List", HeadlineSize.Size2);
document.Add(headlineOrderedList);

OrderedList orderedList = new OrderedList();
orderedList.Add(new ListItem(@"Ordered List Entry 1"));
orderedList.Add(new ListItem(@"Ordered List Entry 2"));
orderedList.Add(new ListItem(@"Ordered List Entry 3"));
document.Add(orderedList);

// Description List
Headline headlineDescriptionList = new Headline(@"Description List", HeadlineSize.Size2);
document.Add(headlineDescriptionList);

DescriptionList descriptionList = new DescriptionList();
descriptionList.Add(new DescriptionListTerm("Animals"));
descriptionList.Add(new DescriptionListDescription("Lion"));
descriptionList.Add(new DescriptionListDescription("Tiger"));
descriptionList.Add(new DescriptionListDescription("Shark"));
descriptionList.Add(new DescriptionListTerm("Cities"));
descriptionList.Add(new DescriptionListDescription("London"));
descriptionList.Add(new DescriptionListDescription("Tokiyo"));
descriptionList.Add(new DescriptionListDescription("Rom"));
document.Add(descriptionList);

// Paragraph
Headline paragraphs = new Headline(@"Paragraph", HeadlineSize.Size2);
document.Add(paragraphs);
document.Add(new Paragraph("Paragraph, Text alignment left", ParagraphAlignment.Left));
document.Add(new Paragraph("Paragraph, Text alignment right", ParagraphAlignment.Right));
document.Add(new Paragraph("Paragraph, Text alignment center", ParagraphAlignment.Center));
document.Add(new Paragraph("Paragraph, Text alignment justify", ParagraphAlignment.Justify));

// Block Quotation and Cite
Headline blockQuotation = new Headline(@"Block Quotation and Cite", HeadlineSize.Size2);
document.Add(blockQuotation);
document.Add(new BlockQuote("The saddest aspect of life right now is that science gathers knowledge faster than society gathers wisdom."));
document.Add(new Cite("- Isaac Asimov"));

// Table
Headline tableQuotation = new Headline(@"Table", HeadlineSize.Size2);
document.Add(tableQuotation);
Table table = new Table(3, 2);
var p1 = new Paragraph("1. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat.");
var p2 = new Paragraph("2. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.");
var p3 = new Paragraph("3. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.");
var p4 = new Paragraph("4. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat.");
table.AddCell(new TableCell(0, 0, p1));
table.AddCell(new TableCell(0, 1, p2));
table.AddCell(new TableCell(1, 0, p3));
table.AddCell(new TableCell(1, 1, p4));
table.AddCell(new TableCell(2, 0, descriptionList));
table.AddCell(new TableCell(2, 1, orderedList));
document.Add(table);

Console.Write(document.HTMLContent);

string fileName = "document.html";

// Save file
StreamWriter streamWriter = new StreamWriter(fileName);
streamWriter.Write(document.HTMLContent);
streamWriter.Flush();
streamWriter.Close();

// Open in default Browser
var info = new System.Diagnostics.ProcessStartInfo(fileName);
info.UseShellExecute = true;
System.Diagnostics.Process.Start(info);




