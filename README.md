# Логіка:

1)Incident -> 
-він не може бути створеним без наявного уже Account
-Коли ми вводимо неіснуюче ім'я Account вискакує 404 - validation

2)Account ->
-Не може бути створеним без створення Contact
-Згідно умови може існувати лише один Account з певним ім'ям - unique

3)Contact ->
Для наглядності усього функціоналу завантажив фотографію з усіма можливими випадками, зокрема:
-Якщо контакт вже у системі -> ми апдейтимо його та лінкуємо цей щойно створений контакт до акаунта, який також створюємо - (з умови Validation не дуже зрозуміло чи потрібно залінкувати контакт до вже існуючого чи до нового, саме тому я зробив так)

Загалом процес:
1.Створюємо новий контакт /api/Contacts/createContact(StepByStep)

Для прикладу:
{
  "firstName": "Vitaliy",
  "lastName": "Artemenko",
  "email": "VitaliyAtemenko@gmail.com"
}

2.Одразі після цього у нас створюється новий Account, що лінкується з Contact

3.Створюємо новий Incident, де мусимо вказати поле/поля AccountName.
AccountName може форумаватись двома випадками: 
-Автоматично беручи email контакту та забираючи закінчення @gmail.com (коли створюємо контакт)
-Згідно введеному значенню, коли використовуємо контроллер у Accounts
Також IncidentName - не потрібно вводити, воно генерується автоматично з імені/імен Account

Приклад процесу (1):
1)/api/Contacts/createContact(StepByStep)
{
  "firstName": "Alex",
  "lastName": "Kovals",
  "email": "AlexKovaks@gmail.com"
}
2)api/Incidents/createIncident(StepByStep)
{
  "incidentName": "string",
  "description": "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
  "accounts": [
    {
      "accountName": "AlexKovaks"
    }
  ]
}
Процес завершено

Приклад процесу (2)
1)api/Accounts/createAccount(Create Account with Contact)
{
  "accountName": "Svyatoslav15",
  "contacts": [
    {
      "firstName": "Svyat",
      "lastName": "Kushko",
      "email": "SvyatKush@gmail.com"
    },
    {
      "firstName": "Oleksandr",
      "lastName": "Kushko",
      "email": "AlexKushko@gmail.com"
    }
  ]
}
2)api/Accounts/createAccount(Create Account with Contact)
{
  "accountName": "VikaNadiya",
  "contacts": [
    {
      "firstName": "Viktoriya",
      "lastName": "Mishuna",
      "email": "VikaMishuna@gmail.com"
    },
    {
      "firstName": "Nadiya",
      "lastName": "Mishuna",
      "email": "NadyaMishuna@gmail.com"
    }
  ]
}
3)api/Incidents/createIncident(StepByStep)

{
  "incidentName": "string",
  "description": "This is test description",
  "accounts": [
    {
      "accountName": "Svyatoslav15"
    },
    {
      "accountName": "VikaNadiya"
    }
  ]
}
