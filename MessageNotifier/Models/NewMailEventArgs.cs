using System;

namespace MessageNotifier.Models
{
    /// <summary>
    /// Модель аргументов передаваемых при возникновении события
    /// </summary>
    internal class NewMailEventArgs : EventArgs
    {
        #region Public Readonly Props

        // Свойства в модели аргументов рекомендуется делать только для чтения

        public string From      { get; }
        public string To        { get; }
        public string Subject   { get; }

        #endregion

        #region Constructor

        public NewMailEventArgs(string from, string to, string subject)
        {
            From    = from;
            To      = to;
            Subject = subject;
        }

        #endregion

        public override string ToString()
        {
            return $"Письмо от {From} для {To} : {Subject}";
        }

    }
}
