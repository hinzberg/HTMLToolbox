# HTMLToolbox
## A lightweight class library to create simple HTML in C# code for data export

Exporting data from C# applications in HTML format is an easy way to quickly get a visually appealing result. However, HTML is not a full-fledged programming language. Loops and case distinctions do not exist there. If these control structures were necessary, this would have to be done in the C# code. Unfortunately, I did not find a means to do this easily. 

My goal was simple and clear. The generation of an HTML file should follow a simple path. All needed elements were first C# instances and would be added to a document at runtime. Just like the HTML DOM, they are just a collection of nested lists. Only at the end would the desired HTMl code be generated from this object tree.

One of the great advantages of HTML is nesting. Lists within paragraphs are just as little a problem as tables within other tables. To what extent my HTML toolbar can realize this remains to be seen. Additional formatting and layout are also planned, but not yet implemented. In the current state, the HTML code is not indented either.

#### The following HTML elements are supported so far.
- Headline (H1 to H6)
- Unordered List
- Ordered List with different types (A,a,I,i,1)
- Description List

### History
#### 2023-04-09
- DescriptionList added

#### 2023-04-05
- Headline added
- Unordered List, Ordered List added
- HTMLDocument and Interfaces added
- Initial Comit