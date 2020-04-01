using Factory.Product;

namespace Factory.Creator
{
    internal class WindowsDialog : Dialog
    {
        protected override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}