# GroupAgeParser
Приложение, которое позволяет подсчитать средний возраст подписчиков группы, используя два режима работы

Все user-параметры, используемые приложением:
  **token** - ключ доступа VK API. можно использовать ключ доступа сообщества/пользователя/сервисный.
  **groupId** - идентификатор сообщества или его короткое имя, может быть численным значением или строкой.
  **aTimeout** - крайний минимальный диапазон перерыва между API запросами в секундах
  **bTimeout** - крайний максимальный диапазон перерыва между API запросами в секундах

Вышеперечисленные параметры можно настраивать с помощью UI в приложении.
Также существует параметр **parseMode**, который можно настраивать с помощью RadioButton в главном окне приложения.

Различия режимов обработки данных:
  **fast mode** - быстрый способ, обрабатывает всех подписчиков с не скрытой датой рождения и высчитывает среднее значение.
  **detailed mode** - более медленный способ, обрабатывает всех подписчиков с не скрытой датой рождения и высчитывает среднее значение, однако если подписчик имеет открытый профиль и скрытую дату рождения, то код обработает друзей данного человека(максимум: 1000) и высчитает их средний возраст - этот возраст и будет считаться возрастом данного человека.

Все методы выполняются через официальный VK API, код НЕ СОХРАНЯЕТ и НЕ ПЕРЕДАЕТ никакие введенные Вами значения.
