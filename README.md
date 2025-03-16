# Helg algoritm - Jump Game


📌 Problemformulering – Jump Game

Du har en array av positiva heltal där varje element representerar hur långt du kan hoppa från den positionen.
Ditt mål är att avgöra om du kan nå det sista indexet från det första indexet.

✅ Regler:

Du börjar vid index 0 och får hoppa framåt baserat på värdet i arrayen.
Du kan hoppa mellan 1 och nums[i] steg där nums[i] är värdet på den aktuella positionen.
Bestäm om du kan nå slutet av listan.

🔍 Exempel

Input:  [2, 3, 1, 1, 4]
Output: true
(Förklaring: Hoppa 2 steg till index 2, hoppa 3 steg till sista index)
eller Jump 1 step from index 0 to 1, then 3 steps to the last index.


Input:  [3, 2, 1, 0, 4]
Output: false
(Förklaring: Du fastnar vid index 3 eftersom nums[3] = 0)
You will always arrive at index 3 no matter what. Its maximum jump length is 0, which makes it impossible to reach the last index.

Tips det finns 2 olika version att lösa detta :
-------------------------------------------------------------------------------------------
📝 Lösning 1 – Greedy Algorithm (Effektiv O(n))

⏳ Tidskomplexitet:
O(n) – Vi går igenom listan endast en gång, vilket gör denna lösning snabb och effektiv.

Greedy strategi:
Håll koll på det fjärran index du kan nå.
Iterera genom listan och uppdatera det längsta möjliga indexet du kan nå.
Om du vid någon punkt inte kan gå längre, returnera false.
-------------------------------------------------------------------------------------------
📝 Lösning 2 – Dynamisk Programmering (O(n²), Mindre Effektiv)
 
⏳ Tidskomplexitet:
O(n²) – Vi itererar igenom alla möjliga hopp, vilket gör denna metod långsammare än den greedy-metoden.

En brute-force metod använder rekursion eller dynamisk programmering för att simulera varje hoppmöjlighet.

🔸 Vi håller en array dp[] där dp[i] = true om vi kan nå index i.
🔸 För varje position i, kolla om du kan nå index j med ett hopp.
---------------------------------------------------------------------------------------------

👨‍💻 Utmaning: Kan du modifiera algoritmen för att också räkna minsta antal hopp som krävs för att nå slutet? 🤔

🚀 Lycka till med Jump Game! 🎮🔥
