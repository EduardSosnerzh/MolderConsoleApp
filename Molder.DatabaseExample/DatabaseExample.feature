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
		Then write variable "result[0]"



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
	INSERT INTO TEST(ID, NAME) VALUES (0,'aS12!')
	"""
	Then я выполняю "SELECT" запрос в БД "DataBase" и сохраняю результат в переменную "test":
	"""
	SELECT * FROM TEST
	"""
	Then write variable "test"
	And я выполняю запрос в БД "DataBase" с сохранением количества обработанных записей в переменную "tmp":
	"""
	DROP TABLE TEST
	"""

	Scenario: Create, Insert from Molder.Generator and Drop Table
	Given я выполняю запрос в БД "DataBase" с сохранением количества обработанных записей в переменную "tmp":
	"""
	CREATE TABLE TEST
	(
	ID INT NOT NULL,
	NAME VARCHAR(20)
	)
	"""
	Given я сохраняю случайный набор цифр длиной 2 знаков в переменную "tmp1"
	Given я сохраняю случайный набор букв и цифр длиной 2 знаков в переменную "tmp2"
	Given я выполняю "INSERT" запрос в БД "DataBase" и не сохраняю результат:
	"""
	INSERT INTO TEST(ID, NAME) VALUES ({{tmp1}},{{tmp2}})
	"""
	Then я выполняю "SELECT" запрос в БД "DataBase" и сохраняю результат в переменную "test":
	"""
	SELECT * FROM TEST
	"""
	Then write variable "test"
	And я выполняю запрос в БД "DataBase" с сохранением количества обработанных записей в переменную "tmp":
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
	Then write variable "test"
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
	