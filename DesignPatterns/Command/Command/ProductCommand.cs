using Command.Receiver;

namespace Command.Command
{
    public class ProductCommand : ICommand
    {
        private readonly Product _product;
        private readonly PriceAction _priceAction;
        private readonly int _amount;
        private bool _isCommandExecuted;
 
        public ProductCommand(Product product, PriceAction priceAction, int amount)
        {
            _product = product;
            _priceAction = priceAction;
            _amount = amount;
        }
 
        public void ExecuteCommand()
        {
            if(_priceAction == PriceAction.Increase)
            {
                _product.IncreasePrice(_amount);
                _isCommandExecuted = true;
            }
            else
            {
                _isCommandExecuted = _product.DecreasePrice(_amount);
            }
        }
 
        public void UndoAction()
        {
            if (!_isCommandExecuted)
                return;
 
            if (_priceAction == PriceAction.Increase)
            {
                _product.DecreasePrice(_amount);
            }
            else
            {
                _product.IncreasePrice(_amount);
            }
        }
    }
}