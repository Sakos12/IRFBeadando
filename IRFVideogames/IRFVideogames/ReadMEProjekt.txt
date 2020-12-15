Solymossy Ákos - E7B5D6

Infrmatikai rendszerek beadandó leírás
Tételek: 1,C 2,C 3,A 4,E

Program lényege:

A programomat egy sajét magam által korábban felépített adatbázis fő táblájának alapjára készítettem.
Ez a főtábla Videójátékokat, és hozzájuk kötődő egyéb információkat tartalmaz (Eladási szám, kiadó, fejlesztő, megjelenési dátum, van-e többjátékos mód, IGN hírportál értékelése)

A táblát átkonvertáltam XML-be majd azt olvastam be, egy bindinglistbe, saját GameData osztály segítségével, és ezekkel az adatokkal dolgoztam.
Célja az adatok között való böngészés és információszerzés átadása, különböző keresztszűrési funkciókkal és listatörlési lehetőségekkel megtoldva.

Felépítése:

Alapvetően 3 Formból áll a program.
Form 1: a főoldal, melyen üdvözlő szöveg található, illetve két aznos osztályból származó gomb, mely a két másik form közül az egyiket-másikat hivatott előhozni.
Form2: Form 2 alapvetően a program azonnal kilistázza egy datagridviewba az XML adatait. A DGW melletti gombok pedig lehetőséget adnak az alapból teletöltött listából való törlése 
megjelenési dátum, értékelés, és többjátékosmód szerint. Ezeket a törlési funkciókat kombinálni is lehet, hogy jobban le lehessen szűrni az adatokat, illetve a legfelső gomb segítségével ezeket a változtatásokat visszavonhatjuk, és betölhetjük az összes adatot az XML-ből
A Form alján egy kezdőlap gombbal pedig vissza lehet menni a Form1-re.
Form3: Ezen a formon egy lista és egy textbox segítségével lehet leszűrni az adatokat. A textbox lehetőséget ad a név szerinti szűrésre (kezdőbetük szerint és számít a nagybetű!!!), a listában pedig 2000-2020ig az évszámokat kiválasztva lehet leszűrni az adott évben megjelent játékokra.
Természetesen ez a kettő is kombinálható! 
A Form alján egy kezdőlap gombbal pedig vissza lehet menni a Form1-re.