# Öröklés gyakorló feladat

> Az előző gyakorló feladatra épül!

A **Dolgozó** osztály fizetés metódusa legyen _virtual_ maga az osztály pedig _abstract_!

Készítsen egy **alkalmazott** osztályt, ami a **Dolgozó**ból származik.

Készítsen egy _sealed_ **diák munkás** osztályt, ami szintén a dolgozóból származik, ez az osztály tartalmazzon egy **oktatási intézmény** tulajdonságot, és írja felül a **fizetés** metódust, úgy hogy csak a tényleges fizetés 97%-át adja vissza. Az oktatási intézmény a konstruktorban legyen beállítható és tartozzon hozzá tulajdonság is.

Készítsen egy **vezető** osztályt ez is a **Dolgozó**ból származik, ennek legyen egy **havi fix bér** adattagja, írja felül a **fizetés** metódust úgy, hogy a dolgozóban számolthoz hozzá adja a havi fix bért. A havi fix bérhez tartozzon csak olvasható tulajdonság és a konstruktorból lehessen beállítani.

Hozzon létre egy **főnök** osztályt is, ami a **vezető**ből származik.

Minden osztály írja felül a **ToString** metódust.
( _public override string ToString()_ )

Módosítsa a főprogramot úgy hogy minden osztály és metódus használva legyen.
