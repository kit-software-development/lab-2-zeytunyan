using System;
using Practice.Common;
using Practice.HR.Events;


namespace Practice.HR
{
    /// <summary>
    ///     Абстрактная база для описания конкретных реализаций типа "Человек".
    ///     Используется для дальнейшего наследования.
    /// </summary>
    internal abstract class AbstractPerson : IPerson
    {
        private IName _name;

        public IName Name
        {
            get { return _name; }

            set
            {
                var oldName = _name;
                _name = value;
                if (NameChange != null)
                {
                    NameChange.Invoke(this, new ValueChangeEventArgs<IName>(oldName));
                }
            }
        }

        public event EventHandler<ValueChangeEventArgs<IName>> NameChange;
        /*
         * TODO #3: Реализуйте интерфейс IPerson для класса AbstractPerson
         */
    }
}
