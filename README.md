# GroupAgeParser
Приложение, которое позволяет подсчитать средний возраст подписчиков группы, используя два режима работы.

## Параметры и режимы
Все user-параметры, используемые приложением:
  - ``token`` - ключ доступа VK API. можно использовать ключ доступа сообщества/пользователя/сервисный.
  - ``groupId`` - идентификатор сообщества или его короткое имя, может быть численным значением или строкой.
  - ``aTimeout`` - крайний минимальный диапазон перерыва между API запросами в секундах
  - ``bTimeout`` - крайний максимальный диапазон перерыва между API запросами в секундах

Вышеперечисленные параметры можно настраивать с помощью UI в приложении.
Также существует параметр ``parseMode``, который можно настраивать с помощью переключателей в главном окне приложения.

Различия режимов обработки данных:
  - ``fast mode`` - быстрый способ, обрабатывает всех подписчиков, у которых не скрыта дата рождения и высчитывает среднее значение.
  - ``detailed mode`` - более медленный способ, обрабатывает всех подписчиков с не скрытой датой рождения и высчитывает среднее значение, однако если подписчик имеет открытый профиль и скрытую дату рождения, то код обработает друзей данного человека(максимум: 1000) и высчитает их средний возраст - этот возраст и будет считаться возрастом данного человека.

## Получение различных ключей доступа VK API
Для работы приложения обязательным параметром является наличие ключ доступа(``token``).
Ключи доступа VK API могут быть следующих видов:
  - пользователя
  - сообщества
  - сервисные

Приложение будет исправно работать только с ключом доступа пользователя или сервисным ключом доступа.
1. Получение ключа доступа пользователя:
    - перейдите по данной ссылке: https://vkhost.github.io/
    - выберите нужное приложение или нажмите "Настроить" для изменения получаемых прав/айди приложения
    - приложение запросит у Вас разрешение на использование необходимых прав, нажмите "Разрешить"
    - из адресной строки скопируйте часть от ``access_token=`` до ``&expires_in``, значение между этими двумя параметрами и есть токен
2. Получение сервисного ключа доступа:
    - перейдите по данной ссылке: https://vk.com/editapp?act=create
    - в "Платформа" выберите ``Standalone-приложение``, нажмите "Подключить приложение"
    - зайдите в "Настройки" в боковом меню слева
    - в строке "Сервисный ключ доступа" нажмите на значок глаза, подтвердите действие и скопируйте ключ доступа из этого поля

В приложении Group Age Parser поменяйте значение ключа ``token`` на только что скопированное и сохраните.


## Важная информация
Все методы выполняются через официальный VK API, код НЕ СОХРАНЯЕТ и НЕ ПЕРЕДАЕТ никакие введенные Вами значения.
