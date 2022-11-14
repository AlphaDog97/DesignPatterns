using Example;

Text text = new Text("Calibri",12);
text.ShowInformation();

BoldText boldText = new BoldText(text);
boldText.ShowInformation();

boldText.ChangeStatusOfBold(true);
boldText.ShowInformation();

UnderlineText underlineText = new UnderlineText(text);
underlineText.ShowInformation();

underlineText.ChangeStatusOfUnderline(true);
underlineText.ShowInformation();