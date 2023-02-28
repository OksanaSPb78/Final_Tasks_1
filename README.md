Итоговая проверочная работа.
1.Создать репозиторий на GitHub.
2.Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если 
вы выделяете её в отдельный метод)
3.Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4.Написать программу, решающую поставленную задачу
5.Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все 
залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Пример:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []

1. Создала новый репозиторий на GitHub
Клонировала ссылку созданного репозитория в VSCode https://github.com/OksanaSPb78/Final_Tasks
Инициализировала созданную папку
Создала файл README.md в рабочей папке и сделала commit
Создала файл .gitignore и сделала commit
2. Составила блок-схему решения алгоритма задачи
3. Алгоритм программы:

* Создаем массив строк, заданных с клавиатуры

* Создаем вспомогательную переменную *count = 0*, в которую будем помещать количество строк, 
длина которых 3 символа и меньше, как указано в условии задачи.

* Вычисляем количество строк, заданных по условию.

* В цикле *for* проходим по каждой строке массива. На каждом цикле сверяем длину строки.
Если условие задачи соблюдается,то увеличиваем  значение созданной переменной *count* и 
увеличиваем значение счётчика цикла *i*. Если условие не соблюдается,т.е. длина больше трёх,то 
увеличиваем только счётчик цикла *i*.

* Создаем массив результатов размером *count*.

* Формируем массив из строк, длина которых соответствует условию задачи.

* Снова в цикле *for* проходим по каждой строке и также сравниваем на каждом цикле  длину строки. 
Если длина меньше или равна трём, мы в текущий массив добавляем данную строку, 
уменьшаем значение переменной *count* и увеличиваем счётчик цикла *j*, 
Если условие не выполняется *else* тогда только инкрементируем (увеличиваем)
счётчик цикла *j*. 

* Выводим полученный массив строк в консоль.

