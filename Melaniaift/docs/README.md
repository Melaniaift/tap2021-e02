#Principiile SOLID #

##S Single Responsibility Principle ## 
Fiecare modul trebuie sa fie responsabil pentru un singur aspect legat de functionalitatea oferita. 
Fiecare functionalitate trebuie sa fie incapsulata in intregime de modulul responsabil. 


##O Open-Closed Principle  ##
O metoda sau o clasa trebuie sa fie usor de extins, dar greu de modificat. 
Extinderea este reprezentata de introducerea unei clase derivate, prin mostenire, asa cum am facut la Account.  


##L Liskov Substitution Principle ##
> If it looks like a duck, swims like a duck, and quacks like a duck, then it probably is a duck.
Obiectele unui sistem trebuie sa fie substituibile de catre instante ale unor subtipuri de obiecte, fara ca substitutia sa afecteze functionalitatile.


##I Interface Segregation Principle ##
Realizam clase mici cu nume sugestive, cat mai descriptive.
Interfetele trebuie să fie mici si specifice contextului de utilizare(nu mari sau generale). 


##D Dependency Inversion Principle ##
Modulele unui sistem software trebuie sa depinda de reprezentari abstracte (de exemplu interfete) si nu de implementari concrete.  
Daca codul ar depinde de implementari concrete testarea si reimplementarea ar fi dificila.
