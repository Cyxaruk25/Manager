**Обзор**

Этот код представляет консольное приложение на языке C#, реализующее простой менеджер задач. Он включает в себя базовый интерфейс для управления списком задач, включая возможности просмотра, добавления и удаления задач. Взаимодействие с пользователем осуществляется через консоль.

**Классы и Методы**

-TaskManager: Главный класс приложения, содержащий точку входа Main и статические методы для отображения меню и управления задачами.

-DisplayMenu(): Метод, отображающий текстовое меню с вариантами действий (показать задачи, добавить задачу, удалить задачу, выйти).

-DisplayTasks(): Метод, выводящий на консоль текущий список задач с их номерами.

-AddTask(): Метод, добавляющий новую задачу в список задач после запроса ввода у пользователя.

-RemoveTask(): Метод, удаляющий выбранную задачу из списка после запроса ввода у пользователя.

-Main(): Точка входа в приложение, содержащая бесконечный цикл для взаимодействия с пользователем.

**Переменные и состояния**

-tasks: Статический список строк, представляющий задачи в менеджере.

-choice: Переменная для хранения выбора пользователя из меню.

**Методы**

-DisplayMenu(): Отображает текстовое меню с вариантами действий для пользователя.

-DisplayTasks(): Выводит текущий список задач с их номерами на консоль.

-AddTask(): Запрашивает у пользователя ввод новой задачи и добавляет ее в список.

-RemoveTask(): Запрашивает у пользователя номер задачи для удаления и удаляет ее из списка.

-Main(): Основной метод, содержащий цикл для взаимодействия с пользователем.

**Примеры использования**

    TaskManager taskManager = new TaskManager();
    taskManager.Main();
Простой пример использования приложения для управления задачами через консоль.

**Входные и выходные данные**

Методы AddTask() и RemoveTask() взаимодействуют с пользователем через консольный ввод и вывод.

**Алгоритмы и структуры данных**

Программа использует стандартные структуры данных C#, такие как List<string>, для хранения и управления списком задач.

**Инструкции по установке и запуску**

Убедитесь, что у вас установлен .NET SDK.
Склонируйте репозиторий и перейдите в его директорию.
Запустите приложение с помощью команды dotnet run.
**Важные замечания**

Приложение предоставляет базовый интерфейс и не предполагает использование сторонних библиотек.
Обработка ошибок и исключений ввода пользователя не предусмотрена в данной версии приложения.