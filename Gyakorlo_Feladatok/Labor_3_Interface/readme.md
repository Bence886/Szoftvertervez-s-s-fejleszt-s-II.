# Interface & Event gyakorló feladat

> Az előző gyakorló feladatra épül!

Hozzon létre egy IMunkátVégez interface-t ami előír egy void Dolgozik metódust. Ezt az interface-t valósítsa meg az irodai dolgozó, a diákmunkás és a vezető osztály is, mindegyik írja ki a konzolra, hogy mit dolgozik (pl.: „Az irodában dolgozok!”)
A Főnök osztályban hozzon létre egy metódust MunkátOszt néven void visszatéréssel, ami a fent létrehozott interface típust várjon paraméterként. A metódus hívja meg a paraméterként kapott példány Dolgozik metódusát.
Készítsen egy delegáltat delegate void UjDolgozo (IMunkátVégez ujDolgozo);
A Cég osztályban legyen egy esemény a fenti delegálttal. A Cég osztályt egészítse ki egy főnök adattaggal ezt a konstruktorban várja, a konstruktorban iratkozzon fel a Főnökkel az eseményre.
A Cég osztály felvesz metódusát egészítse ki úgy hogyha az új dolgozó megvalósítja az IMunkátVégez interface-t akkor meghívja az eseményt paraméterként átadva az új dolgozót.
