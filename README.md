Tema 1:
1.Am creat doua recorduri separate Book si Borrowed dupa care am creat o metoda care imi creeaza un obiect de tipul book , dupa un obiect de tipul Borrower iar cel de al treilea are toate atributele primului Borrower si in plus folosind with am adaugat in lista sa de books primul obiect

2.Am creat o clasa si folosind init ca si metoda la componentele clasei imi permite sa setez variabilele doar la initializare

3.La 3 codul este scris in fisierul program si cat timp citeste de la tastatura texte creeaza obiecte cu acel titlu si le adauga intr un list cat timp nu apare stop la final voi afisa toate obiectele din lista (doar titlul lor)

4.La 4 am o metoda in Book care folosind object pentru q (pot introduce orice tip de obiect) va face comparatia cu IS pentru a vedea tipul acestuia prin niste comparari simple si va arata atributele cerute la lista de books folosesc functia count pentru a numara cate is 

5.La 5 avem o lista predefinita de carti cu anii diferiti dupa care le adaug intr o lista filtrand cu functia lamda toate cartile care au anul mai mare de cat 2010 (c este o referinta la obiectul x din ordinea listei si toata aceasta functie anonima este echivalenta cu o metoda booleana)si le punem dupa care afisam printr-un for 

Tema 2

1 am creat recordul Book dupa care am creat clasele handlere separate pentru fiecare operatie create update delete get sort filter pagination fiecare handler primeste in constructor DbContextul si in metoda Handle face operatia corespunzatoare si returneaza Results corespunzator de exemplu Ok Created NoContent sau NotFound

2 in Program cs am configurat DbContextul folosind InMemoryDatabase si am inregistrat toate handlerele in serviciile DI apoi am creat endpointuri minimal api pentru fiecare handler folosind MapGet MapPost MapPut MapDelete si la get am pus si parametrii pentru filter sort si pagination

3 fiecare handler face validare simpla de exemplu pentru paginare verifica daca page si pageSize sunt mai mari ca 0 pentru create update verifica daca titlu author si year sunt valide pentru delete verifica daca obiectul exista daca nu returneaza Results NotFound

4 astfel toate endpointurile minimal api folosesc handlerele pentru logica CRUD filter sort pagination si toate validarea este tratata in handlere DbContextul tine datele din InMemoryDatabase iar structura proiectului este clara Entities Persistence Features Program cs
