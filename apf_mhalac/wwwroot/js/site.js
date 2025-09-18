//objekt --> json

const osoba = {
    meno: "Jan",
    vek: 25,
    mesto: "Bratislava"
};

const jsonString = JSON.stringify(osoba);

console.log(jsonString);

//json --> objekt --> objekt.meno

const jsonData = '{"meno":"Jan","vek":25,"mesto":"Bratislava"}';

const objekt = JSON.parse(jsonData);

console.log(objekt.meno);

//Uloha 1:

const jsonMartin = '{"meno":"Martin","vek":32,"mesto":"Kosice"}';

const martin = JSON.parse(jsonMartin);

console.log("Meno: " + martin.meno + "\n" + "Vek: " + martin.vek);

//Uloha 2:

const zoznamJson = '[{ "nazov": "Notebook", "cena": 899}, { "nazov": "Mys", "cena": 25}, { "nazov": "Klavesnica", "cena": 45} ]';

const zoznam = JSON.parse(zoznamJson);

console.log("Nazov: " + zoznam[0].nazov + "\n" + "Cena: " + zoznam[0].cena);

//Uloha 3:

const uloha3Json = '{"meno": "Jan", "oblubeneFilmy": ["Matrix", "Inception", "Interstellar"]}';

const uloha3 = JSON.parse(uloha3Json);

console.log("Oblubene filmy pouzivatela " + uloha3.meno + ":" + "\n" + uloha3.oblubeneFilmy[0] + "\n" + uloha3.oblubeneFilmy[1] + "\n" + uloha3.oblubeneFilmy[2]);

//Uloha 4:

const zamestnanci = '[{"meno": "Jan", "pozicia": "Manazer"}, {"meno": "Marta", "pozicia": "Programator"}, {"meno": "Richard", "pozicia": "Programator"}]';

const zamestnancizoz = JSON.parse(zamestnanci);

const programatori = zamestnancizoz.filter(z => z.pozicia === "Programator");

console.log("Programatori:");
programatori.forEach(p => console.log(p.meno));

//Uloha 5 (html 9):

//const knihy = '[{"nazov": "Harry Potter", "utor": "J.K. Rowlingova"}, {"nazov": "Pan Prstenov", "autor": "J.R.R. Tolkien"}, {"nazov": "1984", "autor": "George Orwell"}]';

//const knihyzoz = JSON.parse(knihy);

//API

//Uloha 1:

fetch('https://jsonplaceholder.typicode.com/users')
    .then(response => response.json())
    .then(data => console.log(data))
    .catch(error => console.error('Chyba:', error))

//Uloha 2:

fetch('https://jsonplaceholder.typicode.com/posts')
    .then(response => response.json())
    .then(data => console.log(data));

//Uloha 3:

fetch('https://jsonplaceholder.typicode.com/posts/1')
    .then(response => response.json())
    .then(data => console.log(data));

//Uloha 4:

fetch('https://api.thecatapi.com/v1/images/search')
    .then(res => res.json())
    .then(data => console.log('Macka:', data[0].url));

