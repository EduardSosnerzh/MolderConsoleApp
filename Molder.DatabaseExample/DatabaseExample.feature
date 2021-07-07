@ignore
@SqlServer
Feature: DatabaseExamples
	Background: 
		Given я подключаюсь к БД MS SQL Server с названием "DataBase":
		| DataSource | InitialCatalog | UserID    | Password     |
		| {{SOURCE}} | {{DATABASE}}   | {{LOGIN}} | {{PASSWORD}} |

Scenario: SELECT
	Given я выполняю "SELECT" запрос в БД "DataBase" и сохраняю результат в переменную "result":
"""
SELECT * FROM ftTest
"""