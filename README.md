# Итоги блока. Выбор специализации. IT-специалист

**Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.**

**Решение:**
1. Задаем массив строк . Даем ему название массив1.
2. При помощи цикла for, определяем количество элементов в массив1, в которых число символов меньше либо равно 3.
3. Создаем массив строк с названием массив2, размером соответствующим количеству элементов в массив1, в которых число символов меньше либо равно 3.
4. Запускаем цикл for, ограниченный длиной массив1 и в ходе цикла заполняем массив2 элементами массив1, в которых число символов меньше либо равно 3.
5. Выводим массив2 в консоль.