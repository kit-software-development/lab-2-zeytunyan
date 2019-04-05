using System;
using Practice.HR.Events;
using Practice.Organization;


namespace Practice.HR
{
    /// <summary>
    ///     Скрытая реализация представления о сотруднике.
    /// </summary>
    internal class Employee : AbstractPerson, IEmployee
    {
        /*
         * TODO #5: Реализуйте интерфейс IEmployee для класса Employee
         */

        private IDepartment _department;

        public IDepartment Department
        {
            get { return _department; }
            set
            {
                var oldDepartment = _department;
                _department = value;
                if (DepartmentChange != null)
                {
                    DepartmentChange.Invoke(this, new ValueChangeEventArgs<IDepartment>(oldDepartment));
                }
            }
        }

        public event EventHandler<ValueChangeEventArgs<IDepartment>> DepartmentChange;
    }
}
