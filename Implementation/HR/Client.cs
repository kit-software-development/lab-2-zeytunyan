using System;
using Practice.HR.Events;


namespace Practice.HR
{
    /// <summary>
    ///     Скрытая реализация представления о клиенте.
    /// </summary>
    internal class Client : AbstractPerson, IClient
    {
        int x = 5;
        /*
         * TODO #4: Реализуйте интерфейс IClient для класса Client
         */
        private float _discount;

        public float Discount
        {
            get { return _discount; }
            set
            {
                var oldDiscount = _discount;
                _discount = value;
                if (DiscountChange != null)
                {
                    DiscountChange.Invoke(this, new ValueChangeEventArgs<float>(oldDiscount));
                }
            }
        }

        public event EventHandler<ValueChangeEventArgs<float>> DiscountChange;

    }
}
