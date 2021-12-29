using MessageNotifier.Models;
using System;
using System.Threading;

namespace MessageNotifier.Services
{
    internal class MailService
    {
        /// <summary>
        /// Публичное событие для подписки на него
        /// </summary>
        public event EventHandler<NewMailEventArgs> NewMail;
        // Пример делегата EventHandler: void MethodName(object sender, NewMailEventArgs e);
        // Делегат - это прототип/требование к методу, который можно использовать при подписке на событие

        protected virtual void OnNewMail(NewMailEventArgs e)
        {
            // Проверка входных данных в метод на null
            //_ = e ?? throw new ArgumentNullException(nameof(e));

            // Вариант 1
            // Возможна уязвимость при многопоточности

            //NewMail?.Invoke(this, e);

            // Вариант 2
            // Решение проблемы вар.1, добавление врем. переменной, но компиляторы обрабатывают по разному, могут оптимизировать и привести к вар.1

            //var temp = NewMail;
            //temp?.Invoke(this, e);

            // Вариант 3
            // Сохранение ссылки на делегат во временной переменной для обеспечения безопасности потоков

            Volatile.Read(ref NewMail)?.Invoke(this, e);
        }

        #region Public API

        public void SimulateNewMail(string from, string to, string subject)
        {
            // Какой-то внешний класс отправляет сообщение в службу подписчиков

            // Проверить входные данные на корректность
            // Создать объект для хранения инфо, которую нужно передать получателям уведомления
            var e = new NewMailEventArgs(from, to, subject);

            // Вызвать виртуальный метод, уведомляющий объект о событии
            // Если ни один из производных типов не переопреедляет этот метод, объект уведомит всех зарегистрированныз получателей уведомления
            OnNewMail(e);
        }

        #endregion

    }
}
