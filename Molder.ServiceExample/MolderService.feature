@WebService
Feature: Service

Scenario: GET 1
	Given я создаю json документ "output":
"""
{
    "data": {
        "id": 2,
        "email": "janet.weaver@reqres.in",
        "first_name": "Janet",
        "last_name": "Weaver",
        "avatar": "https://reqres.in/img/faces/2-image.jpg"
    },
    "support": {
        "url": "https://reqres.in/#support-heading",
        "text": "To keep ReqRes free, contributions towards server costs are appreciated!"
    }
}
"""
	When я вызываю веб-сервис "Get" по адресу "https://reqres.in/api/users/2" с методом "Get", используя параметры:
		| Name         | Value            | Style  |
		| Content-Type | application/json | HEADER |
	Then веб-сервис "Get" выполнился со статусом "200"
		And я сохраняю результат вызова веб-сервиса "Get" как json в переменную "result"
		And я убеждаюсь, что значение переменной "result.//" равно "{{output.//}}"

Scenario: GET 2
	Given я создаю json документ "output":
"""
{
}
"""
	When я вызываю веб-сервис "Get" по адресу "https://reqres.in/api/users/23" с методом "Get", используя параметры:
		| Name         | Value            | Style  |
		| Content-Type | application/json | HEADER |
	Then веб-сервис "Get" выполнился со статусом "404"
		And я сохраняю результат вызова веб-сервиса "Get" как json в переменную "result"
		And я убеждаюсь, что значение переменной "result.//" равно "{{output.//}}"


Scenario: POST
	Given я сохраняю текст в переменную "input":
"""
{
    "name": "morpheus",
    "job": "leader"
}
"""
	When я вызываю веб-сервис "Post" по адресу "https://reqres.in/api/users" с методом "Post", используя параметры:
		| Name         | Value            | Style  |
		| Content-Type | application/json | HEADER |
		| Body         | input          | BODY   |
	Then веб-сервис "Post" выполнился со статусом "Created"
		And я сохраняю результат вызова веб-сервиса "Post" как json в переменную "result"
		And write variable "result"

Scenario: DELETE
	When я вызываю веб-сервис "Delete" по адресу "https://reqres.in/api/users/2" с методом "Delete", используя параметры:
		| Name         | Value            | Style  |
		| Content-Type | application/json | HEADER |
	Then веб-сервис "Delete" выполнился со статусом "204"

Scenario: PUT
	Given я сохраняю текст в переменную "input":
	"""
	{
		"name": "morpheus",
		"job": "zion resident"
	}
	"""
	When я вызываю веб-сервис "Put" по адресу "https://reqres.in/api/users/2" с методом "Put", используя параметры:
		| Name         | Value            | Style  |
		| Content-Type | application/json | HEADER |
		| Body         | input			| BODY   |
	Then веб-сервис "Put" выполнился со статусом "200"
		And я сохраняю результат вызова веб-сервиса "Put" как json в переменную "result"
		And write variable "result"

Scenario: PUT
	Given я сохраняю текст в переменную "input":
	"""
	{
		"name": "morpheus",
		"job": "zion resident"
	}
	"""
	When я вызываю веб-сервис "Put" по адресу "https://reqres.in/api/users/2" с методом "Put", используя параметры:
		| Name         | Value            | Style  |
		| Content-Type | application/json | HEADER |
		| Body         | input			| BODY   |
	Then веб-сервис "Put" выполнился со статусом "200"
		And я сохраняю результат вызова веб-сервиса "Put" как json в переменную "result"