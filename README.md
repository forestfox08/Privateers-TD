# Sprint 0 - Game Design Document : Tower Defense
Naam: J.J.

Klas: SD2A

Datum: 09:50 08/09/2025

## 1. Titel en elevator pitch
Titel: Privateers TD

Elevator pitch, maximaal twee zinnen:
Beschrijf kort wat jouw game is en waarom het leuk is om te spelen.

Piraten Tower Defense game.

## 2. Wat maakt jouw tower defense uniek?
Beschrijf in één of twee zinnen wat jouw game onderscheidt van een standaard tower defense. Denk aan iets dat de speler op een nieuwe manier laat nadenken of spelen.

Fortifacations.

## 3. Schets van je level en UI
Maak een schets op papier of digitaal en voeg deze afbeelding toe aan je repository. Voeg in deze sectie de afbeelding in.

Je schets bevat minimaal:
1. Het pad waar de vijanden over lopen met beginpunt en eindpunt.
2. De plaatsen waar torens gebouwd kunnen worden.
3. De locatie van de basis of goal die verdedigd moet worden.
4. De UI onderdelen geld, wave teller, levens, startknop en pauzeknop.
5. Een legenda met symbolen of kleuren voor torens, vijanden, pad, basis en UI.

## 4. Torens
Toren 1 Musketeer, Medium-Long Range, 5 damage (5 sec cooldown), schiet een schot.

Toren 2 Blunderbuss, Medium-Close Range, 20 damage (10 sec cooldown) , schiet Pellets in een spread.

Toren 3 Cutlass, Close Range, 10 Damage (1 sec cooldown), schiet geen pellets maar swingt over een close range.

Toren 4 Canon, Long Range, 500 Damage (1 Min cooldown), Splash damage over een area, lange reload.

Toren 5 Builder, Geen Damage, Elke Ronde +2 Base HP (Base HP (200HP) Max. 3 Builders


## 5. Vijanden

Vijand 1 Pirate, Fast, 50 HP, niks speciaal, doet 5 damage aan je base

Vijand 2 Surgeon, Medium-Slow, 50 HP, Kan healen (0.5 HP per second), 10 damage aan je base

Vijand 3 Rolling Barrel , Medium-Fast, 250HP, 25 damage aan je base

Vijand 4 Sapper, Medium, 150HP, 50 Damage aan je base

Vijand 5 Explosive Cariage, Slow, 700HP, 200 Damage aan base

## 6. Gameplay loop
Beschrijf in drie tot vijf stappen wat de speler steeds doet.

1. Koop Towers

2. Start Ronde

3. Ronde speelt af, enemies volgen het pad, towers schieten naar enemies

4. krijg geld voor nieuwe torens, volgende ronde wordt moeilijker

5. Repeat

## 7. Progressie
Leg uit hoe het spel moeilijker wordt naarmate de waves doorgaan. Denk aan sterkere vijanden, kortere tussenpozen, hogere kosten of lagere beloningen.

Hoe hoger de rondes hoe meer enemies spawnen, per ronde 1.25x enemies, verhoog multiplier met 0.5x elke 10 rondes(rond enemy count af op hele nummers), begin met 5 enemies.

Break tussen rondes is 35 seconde (skippen is optioneel)



## 8. Risico’s en oplossingen volgens PIO
- Probleem 1:
- Impact:
- Oplossing:

- Probleem 2:
- Impact:
- Oplossing:


- Probleem 3:
- Impact:
- Oplossing:
  
## 9. Planning per sprint en mechanics
Schrijf per sprint welke mechanics jij oplevert in de build. Denk aan voorbeelden zoals vijandbeweging over een pad, torens plaatsen, doel kiezen en schieten, waves starten, UI voor geld en levens, upgrades, jouw unieke feature.

Sprint 1 mechanics:

Sprint 2 mechanics:

Sprint 3 mechanics:

Sprint 4 mechanics:

Sprint 5 mechanics:


## 10. Inspiratie
Noem een bestaande tower defense game die jou inspireert en wat je daarvan meeneemt of juist vermijdt.

Bloons TD

## 11. Technisch ontwerp mini

Lees dit korte voorbeeld en vul daarna jouw eigen keuzes in.

Voorbeeld ingevuld bij 11.1 Vijandbeweging over het pad
- Keuze:
Vijanden volgen punten A, B, C en daarna de goal.
- Risico:
Een vijand loopt een punt voorbij of blijft hangen.
- Oplossing:
Als de vijand dichtbij genoeg is kiest hij het volgende punt. Bij de goal gaat één leven omlaag en verdwijnt de vijand.
- Acceptatie:
Tien vijanden lopen van start naar de goal zonder vastlopers en verbruiken elk één leven.
Alle tien vijanden bereiken achtereenvolgens elk waypoint binnen één seconde na elkaar.

### 11.1 Vijandbeweging over het pad
- Keuze:
- Risico:
- Oplossing:
- Acceptatie:


### 11.2 Doel kiezen en schieten
- Keuze:
- Risico:
- Oplossing:
- Acceptatie:

### 11.3 Waves en spawnen
- Keuze:
- Risico:
- Oplossing:
- Acceptatie:

  
### 11.4 Economie en levens
- Keuze:
- Risico:
- Oplossing:
- Acceptatie:

### 11.5 UI basis
- Keuze:
- Risico:
- Oplossing:
- Acceptatie: