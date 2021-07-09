@SqlServer
Feature: DatabaseExamples
	Background: 
		Given я подключаюсь к БД MS SQL Server с названием "DataBase":
		| DataSource | InitialCatalog | UserID    | Password     |
		| {{SOURCE}} | {{DATABASE}}   | {{LOGIN}} | {{PASSWORD}} |


Scenario: SELECT *
		Given я выполняю "SELECT" запрос в БД "DataBase" и сохраняю результат в переменную "result":
		"""
		SELECT * FROM Book
		"""
		Then write variable "result[0][1]"

Scenario: SELECT WHERE
		Given я выполняю "SELECT" запрос в БД "DataBase" и сохраняю результат в переменную "result":
		"""
		SELECT NAME FROM Book WHERE NAME LIKE 'F%'
		"""
		Then write variable "result[0][0]"



Scenario: Create and Drop Table
	Given я выполняю запрос в БД "DataBase" с сохранением количества обработанных записей в переменную "tmp":
	"""
	CREATE TABLE TEST
	(
	ID INT NOT NULL,
	NAME NCHAR(10)
	)
	"""
	Given я выполняю "INSERT" запрос в БД "DataBase" и не сохраняю результат:
	"""
	INSERT INTO TEST(ID, NAME) VALUES (0,'qwerty')
	"""
	Then я выполняю "SELECT" запрос в БД "DataBase" и сохраняю результат в переменную "test":
	"""
	SELECT * FROM TEST
	"""
	Then write variable "test[0][1]"
	And я выполняю запрос в БД "DataBase" с сохранением количества обработанных записей в переменную "tmp":
	"""
	DROP TABLE TEST
	"""

Scenario: Create, Insert from Molder.Generator and Drop Table
	Given я сохраняю случайный набор цифр длиной 2 знаков в переменную "tmp1"
	Given я сохраняю случайный набор букв и цифр длиной 2 знаков в переменную "tmp2"
	Given я выполняю запрос в БД "DataBase" с сохранением количества обработанных записей в переменную "tmp":
	"""
	CREATE TABLE TEST
	(
	ID INT NOT NULL,
	NAME VARCHAR(20)
	)
	"""
	Given я выполняю "INSERT" запрос в БД "DataBase" и не сохраняю результат:
	"""
	INSERT INTO TEST(ID, NAME) VALUES ({{tmp1}},'{{tmp2}}')
	"""
	Then я выполняю "SELECT" запрос в БД "DataBase" и сохраняю результат в переменную "test":
	"""
	SELECT * FROM TEST
	"""
	Then write variable "test[0][0]"
	And write variable "tmp1"
	And я убеждаюсь, что значение переменной "test[0][0]" содержит "{{tmp1}}"
	Then write variable "test[0][1]"
	And write variable "tmp2"
	And я убеждаюсь, что значение переменной "test[0][1]" содержит "{{tmp2}}"
	Then я выполняю запрос в БД "DataBase" с сохранением количества обработанных записей в переменную "tmp":
	"""
	DROP TABLE TEST
	"""

Scenario: Create, Insert from Table and Drop Table
	Given я выполняю запрос в БД "DataBase" с сохранением количества обработанных записей в переменную "tmp":
	"""
	CREATE TABLE TEST
	(
	ID INT NOT NULL,
	NAME NCHAR(10)
	)
	"""
	Then я добавляю записи в таблицу "TEST" в БД "DataBase":
		|ID|NAME|
		|0|456asd|
		|5|rest1|
	Then я выполняю "SELECT" запрос в БД "DataBase" и сохраняю результат в переменную "test":
	"""
	SELECT * FROM TEST
	"""
	Then write variable "test[0][1]"
	Then write variable "test[1][1]"
	Then я убеждаюсь, что значение переменной "test[0][1]" содержит "456asd"
	Then я убеждаюсь, что значение переменной "test[1][1]" содержит "rest1"
	And я выполняю запрос в БД "DataBase" с сохранением количества обработанных записей в переменную "tmp":
	"""
	DROP TABLE TEST
	"""

@Values
Scenario: Create, Insert from appsetings and Drop Table
	Given я выполняю запрос в БД "DataBase" с сохранением количества обработанных записей в переменную "tmp":
	"""
	CREATE TABLE TEST
	(
	ID INT NOT NULL,
	NAME NCHAR(10)
	)
	"""
	Given я выполняю "INSERT" запрос в БД "DataBase" и не сохраняю результат:
	"""
	INSERT INTO TEST(ID, NAME) VALUES ({{Value1}},'{{Value2}}')
	"""
	Then я выполняю "SELECT" запрос в БД "DataBase" и сохраняю результат в переменную "test":
	"""
	SELECT * FROM TEST
	"""
	Then write variable "test[0][0]"
	And я убеждаюсь, что значение переменной "test[0][0]" содержит "{{Value1}}"
	Then write variable "test[0][1]"
	And я убеждаюсь, что значение переменной "test[0][1]" содержит "{{Value2}}"
	And я выполняю запрос в БД "DataBase" с сохранением количества обработанных записей в переменную "tmp":
	"""
	DROP TABLE TEST
	"""

Scenario: Create, Insert, Update and Drop Table
	Given я выполняю запрос в БД "DataBase" с сохранением количества обработанных записей в переменную "tmp":
	"""
	CREATE TABLE TEST
	(
	ID INT NOT NULL,
	NAME NCHAR(10)
	)
	"""
	Then я добавляю записи в таблицу "TEST" в БД "DataBase":
		|ID|NAME|
		|0|456asd|
		|5|rest1|
	Then я выполняю "SELECT" запрос в БД "DataBase" и сохраняю результат в переменную "test1":
	"""
	SELECT * FROM TEST
	"""
	Then write variable "test[0][1]"
	Then я выполняю "UPDATE" запрос в БД "DataBase" и не сохраняю результат:
	"""
	UPDATE TEST
	SET NAME = 'QWERTY'
	WHERE ID = 0
	"""
	Then я выполняю "SELECT" запрос в БД "DataBase" и сохраняю результат в переменную "test2":
	"""
	SELECT * FROM TEST
	WHERE ID=0
	"""
	Then я убеждаюсь, что значение переменной "test2[0][1]" равно "QWERTY    "
	And я выполняю запрос в БД "DataBase" с сохранением количества обработанных записей в переменную "tmp":
	"""
	DROP TABLE TEST
	"""

@ignore
Scenario: DropTable
	Given я выполняю запрос в БД "DataBase" с сохранением количества обработанных записей в переменную "tmp":
	"""
	DROP TABLE TEST
	"""
	