using Factory.Product;

namespace Factory.Creator
{
    public abstract class Dialog
    {
        public void Render()
        {
            var okButton = CreateButton();
            okButton.OnClick("Close Dialog");
            okButton.Render();
        }

        protected abstract IButton CreateButton();
    }
}