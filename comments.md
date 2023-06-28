Mitt program består av 2 delar; ett REST-API och en simpel web-app byggd i blazor, i syfte att testköra API:et. Denna webapp är enbart till för testkörning och är därför inte stylad
mycket, men detta hade enkelt kunnat ändras i framtiden. 

Jag har satt upp en sida var för de olika crud-operationerna, Add, Delete och Update, och även lagt till funktion för GetAll
för att kunna hämta alla gäster i systemet, och GetById för att kunna söka på en specifik gäst i systmet via dess Id.

API:et använder just nu en dictionary för att lagra gäster, men är byggt på ett sådant sätt att en databas hade enkelt kunnat läggas till I stället, för persistent storage



