/*Опишите базу данных для школьного кабинета, в рамках которой можно фиксировать, кто и в какое время сидел за той или иной партой.

— Место ученика — это ряд, парта, вариант.
— В течение одного дня у разных классов бывает несколько уроков.
— Создайте минимум 3 таблицы: «Кабинет», «Ученик» и сводная таблица, где отображаются парты и ученики.
— Используйте поля «началоурока» и «конецурока» с типом данных TimeStamp.*/





--допустим, в кабинете 21 парта в три ряда
CREATE TABLE CLASSROOM
(
    place_in_classroom_id INTEGER(2) NOT NULL PRIMARY KEY, --первичный ключ таблицы, так же является порядковым номером места в классе
    rownumber INTEGER(1) NOT NULL, --номер ряда парт
    desk_number INTEGER(1) NOT NULL, --номер парты в ряду
    variant_number INTEGER(1) NOT NULL --вариант (1, 2)
);

INSERT INTO CLASSROOM VALUE (01, 1, 1, 1);
INSERT INTO CLASSROOM VALUE (02, 1, 1, 2);
INSERT INTO CLASSROOM VALUE (03, 1, 2, 1);
INSERT INTO CLASSROOM VALUE (04, 1, 2, 2);
INSERT INTO CLASSROOM VALUE (05, 1, 3, 1);
INSERT INTO CLASSROOM VALUE (06, 1, 3, 2);
INSERT INTO CLASSROOM VALUE (07, 1, 4, 1);
INSERT INTO CLASSROOM VALUE (08, 1, 4, 2);
INSERT INTO CLASSROOM VALUE (09, 1, 5, 1);
INSERT INTO CLASSROOM VALUE (10, 1, 5, 2);
INSERT INTO CLASSROOM VALUE (11, 1, 6, 1);
INSERT INTO CLASSROOM VALUE (12, 1, 6, 2);
INSERT INTO CLASSROOM VALUE (13, 1, 7, 1);
INSERT INTO CLASSROOM VALUE (14, 1, 7, 2);
INSERT INTO CLASSROOM VALUE (15, 2, 1, 1);
INSERT INTO CLASSROOM VALUE (16, 2, 1, 2);
INSERT INTO CLASSROOM VALUE (17, 2, 2, 1);
INSERT INTO CLASSROOM VALUE (18, 2, 2, 2);
INSERT INTO CLASSROOM VALUE (19, 2, 3, 1);
INSERT INTO CLASSROOM VALUE (20, 2, 3, 2);
INSERT INTO CLASSROOM VALUE (21, 2, 4, 1);
INSERT INTO CLASSROOM VALUE (22, 2, 4, 2);
INSERT INTO CLASSROOM VALUE (23, 2, 5, 1);
INSERT INTO CLASSROOM VALUE (24, 2, 5, 2);
INSERT INTO CLASSROOM VALUE (25, 2, 6, 1);
INSERT INTO CLASSROOM VALUE (26, 2, 6, 2);
INSERT INTO CLASSROOM VALUE (27, 2, 7, 1);
INSERT INTO CLASSROOM VALUE (28, 2, 7, 2);
INSERT INTO CLASSROOM VALUE (29, 3, 1, 1);
INSERT INTO CLASSROOM VALUE (30, 3, 1, 2);
INSERT INTO CLASSROOM VALUE (31, 3, 2, 1);
INSERT INTO CLASSROOM VALUE (32, 3, 2, 2);
INSERT INTO CLASSROOM VALUE (33, 3, 3, 1);
INSERT INTO CLASSROOM VALUE (35, 3, 4, 1);
INSERT INTO CLASSROOM VALUE (36, 3, 4, 2);
INSERT INTO CLASSROOM VALUE (37, 3, 5, 1);
INSERT INTO CLASSROOM VALUE (38, 3, 5, 2);
INSERT INTO CLASSROOM VALUE (39, 3, 6, 1);
INSERT INTO CLASSROOM VALUE (40, 3, 6, 2);
INSERT INTO CLASSROOM VALUE (41, 3, 7, 1);
INSERT INTO CLASSROOM VALUE (42, 3, 7, 2);

/*Допустим, в списке 15 учеников, в трёх группах по 5 человек, 
в перовой группе урок идёт 2010-05-10 14:00 - 2010-05-10 14:45, 
во второй 2010-05-10 15:00 - 2010-05-10 15:45 и третьей 2010-05-10 16:00 - 2010-05-10 16:45 
Создадим таблицу расписания для групп, время в формате TIMESTAMP*/


CREATE TABLE SCHEDULE
(
    group_id INTEGER(1) NOT NULL PRIMARY KEY, --номер группы и одновременно первичный ключ
    start_of_lesson TIMESTAMP NOT NULL, --время начало урока в формате TIMESTAMP
    end_of_lesson TIMESTAMP NOT NULL  --время окончания урока в формате TIMESTAMP    
);

INSERT INTO SCHEDULE VALUE (1, 20100510140000, 20100510144500);
INSERT INTO SCHEDULE VALUE (2, 20100510150000, 20100510154500);
INSERT INTO SCHEDULE VALUE (3, 20100510160000, 20100510164500);

/* Создадим и заполним таблицу с учениками*/
CREATE TABLE STUDENTS
(
    student_id INTEGER(4) NOT NULL PRIMARY KEY, --первичный ключ ученика
    student_lastname VARCHAR(30) NOT NULL,  --фамилия ученика
    student_firstname VARCHAR(30) NOT NULL, --имя ученика
    group_number INTEGER(1) NOT NULL, --номер группы
    place_in_classroom_number INTEGER(2) NOT NULL, --порядковый номер места, который равен первичному ключу в таблице CLASSROOM, связующий ключ
    FOREIGN KEY (place_in_classroom_number) REFERENCES CLASSROOM (place_in_classroom_id), --назначение связующего ключа между таблицей STUDENTS и CLASSROOM
    FOREIGN KEY (group_number) REFERENCES SCHEDULE (group_id) --связующий ключ между таблицей SCHEDULE и STUDENTS
);

INSERT INTO STUDENTS VALUE (0001, 'Петухов', 'Артемий', 1, 03);
INSERT INTO STUDENTS VALUE (0002, 'Левина', 'Алёна', 1, 03);
INSERT INTO STUDENTS VALUE (0003, 'Гордеева', 'Алёна', 1, 01);
INSERT INTO STUDENTS VALUE (0004, 'Иванов', 'Семён', 1, 01);
INSERT INTO STUDENTS VALUE (0005, 'Ильина', 'Амина', 1, 15);
INSERT INTO STUDENTS VALUE (0006, 'Кулакова', 'Наталья', 2, 25);
INSERT INTO STUDENTS VALUE (0007, 'Львова', 'Полина', 2,  31);
INSERT INTO STUDENTS VALUE (0008, 'Муравьев', 'Владимир', 2, 42);
INSERT INTO STUDENTS VALUE (0009, 'Винокуров', 'Захар', 2, 33);
INSERT INTO STUDENTS VALUE (0010, 'Киреев', 'Михаил', 2, 28);
INSERT INTO STUDENTS VALUE (0011, 'Петров', 'Семён', 3, 17);
INSERT INTO STUDENTS VALUE (0012, 'Щербаков', 'Егор', 3, 01);
INSERT INTO STUDENTS VALUE (0013, 'Казаков', 'Иван', 3, 39);
INSERT INTO STUDENTS VALUE (0014, 'Макаров', 'Кирилл', 3, 40);
INSERT INTO STUDENTS VALUE (0015, 'Васильев', 'Константин', 3, 22);

/*при таком запросе получим сводную таблицу учеников, их места в классе (номер ряда, номер парты в ряду и вариант) и время начала и конца урока,
но много лишних колонок. Скриншот №1*/

SELECT * FROM CLASSROOM, STUDENTS, SCHEDULE
WHERE place_in_classroom_number = place_in_classroom_id 
AND group_number = group_id
/*аналогичного вывода можно добиться с помощью JOIN*/
SELECT * FROM STUDENTS 
LEFT JOIN CLASSROOM 
    ON(place_in_classroom_id = place_in_classroom_number) 
LEFT JOIN SCHEDULE 
    ON (group_id = group_number)

/*Расширенный запрос, для получения уже только нужной информации из таблиц Скриншот №2*/

SELECT student_firstname,
       student_lastname,
       group_number,
       start_of_lesson,
       end_of_lesson,
       rownumber,
       desk_number,
       variant_number
FROM CLASSROOM,
     STUDENTS,
     SCHEDULE
WHERE place_in_classroom_number = place_in_classroom_id 
AND group_number = group_id

/*Аналогичный результат можно получить с помощью JOIN*/

SELECT student_firstname,
       student_lastname,
       group_number,
       start_of_lesson,
       end_of_lesson,
       rownumber,
       desk_number,
       variant_number 
FROM STUDENTS 
    LEFT JOIN CLASSROOM 
        ON(place_in_classroom_id = place_in_classroom_number) 
    LEFT JOIN SCHEDULE 
        ON (group_id = group_number)