using Factory.Product;

namespace Factory.Creator
{
    public class MacDialog : Dialog
    {
        protected override IButton CreateButton()
        {
            return new MacButton();
        }
    }
}