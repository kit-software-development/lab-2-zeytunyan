namespace Practice.Common
{
    /// <summary>
    ///     Скрытая реализация представления об имени человека.
    /// </summary>
    internal struct Name : IName
    {
        /*
         * TODO #1: Реализуйте интерфейс IName для структуры Name
         */


        public Name(string surname, string firstname, string patronymic)
        {
            Surname = surname;
            FirstName = firstname;
            Patronymic = patronymic;
            FullName = surname + ' ' + firstname + ' ' + patronymic;
            ShortName = surname + ' ' + firstname[0] + "." + patronymic[0] + '.';
        }

        public Name(IName name)
        {
            FullName = name.FullName;
            ShortName = name.ShortName;
            var tmp = FullName.Split(' ');
            Surname = tmp[0];
            FirstName = tmp[1];
            Patronymic = tmp[2];
        }

        /// <summary>
        ///     Имя.
        /// </summary>
        public string FirstName { get; }
        
        /// <summary>
        ///     Фамилия.
        /// </summary>
        public string Surname { get; }
        
        /// <summary>
        ///     Отчество.
        /// </summary>
        public string Patronymic { get; }
        

        public string FullName { get; }

        public string ShortName { get; }

    }
}
