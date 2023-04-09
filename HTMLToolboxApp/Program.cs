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

// Ordered List
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




