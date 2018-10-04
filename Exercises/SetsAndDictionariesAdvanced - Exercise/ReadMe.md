## Problem 1.
# Exercises

# : Sets

# and Dictionaries Advanced

Problems for exercises and homework for the [&quot;C# Advanced&quot; course @ SoftUni](https://softuni.bg/courses/csharp-advanced).

You can check your solutions here: [https://judge.softuni.bg/Contests/1182/](https://judge.softuni.bg/Contests/1182/)

1. Problem 1.Unique Usernames

On the first line you will be given an integer **N**. On the next **N** lines you will receive one username per line. Write a simple program that reads from the console a sequence of **N** usernames and keeps a collection onlyof the unique ones. Print the collection on the console in order of insertion:

### Examples

| **Input** | **Output** |
| --- | --- |
| 6IvanIvanIvanSemoMastikataIvanHubaviq1234 | IvanSemoMastikataHubaviq1234 |

1. Problem 2.Sets of Elements

On the first line you are given the length of two sets **n** and **m**. On the next **n** + **m** lines there are **n** numbers that are in the first set and **m** numbers that are in the second one. Find all non-repeating elements that appear in both of them and print those from the **n** set.

Set with length n = 4: {1, **3** , **5** , 7}

Set with length m = 3: { **3** , 4, **5** }

Set that contains all repeating elements -\&gt; { **3** , **5** }

### Examples

| **Input** | **Output** |
| --- | --- |
| 4 31357345 | 3 5 |
| 2 21315 | 1 |

1. Problem 3.Periodic Table

You are given an **n** number of chemical compounds joined with space (&#39; &#39;). You need to keep track of all chemical elements used in the compounds and at the end print all unique ones in ascending order:

### Examples

| **Input** | **Output** |
| --- | --- |
| 4Ce OMo O CeEeMo | Ce Ee Mo O |
| 3Ge Ch O NeNb Mo TcO Ne | Ch Ge Mo Nb Ne O Tc |

1. Problem 4.Even Times

You are given a list of  **N**  integer numbers all but one of which appears an odd number of times. Write a program to find the one integer which appears an  **even number of times**.

### Examples

| **Input** | **Output** | **Input** | **Output** |
| --- | --- | --- | --- |
| 32-12 | 2 | 512315 | 1 |

1. Problem 5.Count Symbols

Write a program that reads some text from the console and counts the occurrences of each character in it. Print the results in **alphabetical** (lexicographical) order.

### Examples

| **Input** | **Output** | **Input** | **Output** |
| --- | --- | --- | --- |
| SoftUni rocks |  : 1 time/sS: 1 time/sU: 1 time/sc: 1 time/sf: 1 time/si: 1 time/sk: 1 time/sn: 1 time/so: 2 time/sr: 1 time/ss: 1 time/st: 1 time/s | Did you know Math.Round rounds to the nearest even integer? |  : 9 time/s.: 1 time/s?: 1 time/sD: 1 time/sM: 1 time/sR: 1 time/sa: 2 time/sd: 3 time/se: 7 time/sg: 1 time/sh: 2 time/si: 2 time/sk: 1 time/sn: 6 time/so: 5 time/sr: 3 time/ss: 2 time/st: 5 time/su: 3 time/sv: 1 time/sw: 1 time/sy: 1 time/s |

1. Problem 6.Wardrobe

You just bought a new wardrobe. The weird thing about it is that it came prepackaged with a big box of clothes (just like those refrigerators, which ship with free beer inside them)! So, you&#39;ll need to find something to wear.

### Input

On the first line of the input, you will receive **n** –  the **number of lines** of clothes, which came prepackaged for the wardrobe.

On the next **n** lines, you will receive the clothes for each color in the format:

- &quot; **{color} -\&gt; {item1},{item2},{item3}…**&quot;

If a color is added a **second** time, **add**** all items **from it and** count **the** duplicates**.

**Finally** , you will receive the **color** and **item** of the clothing, that you need to look for.

### Output

Go through all the **colors** of the clothes and print them in the following format:

| **{color}** clothes:\* **{item1}** - **{count}** \* **{item2}** - **{count}** \* **{item3}** - **{count}** …\* **{itemN}** - **{count}** |
| --- |

If the **color** lines up with the **clothing item** , print &quot;**(found!)**&quot; alongside the item. See the examples to better understand the output.

### Examples

| **Input** | **Output** |
| --- | --- |
| 4Blue -\&gt; dress,jeans,hatGold -\&gt; dress,t-shirt,boxersWhite -\&gt; briefs,tanktopBlue -\&gt; glovesBlue dress | Blue clothes:\* dress - 1 (found!)\* jeans - 1\* hat - 1\* gloves - 1Gold clothes:\* dress - 1\* t-shirt - 1\* boxers - 1White clothes:\* briefs - 1\* tanktop - 1 |

| **Input** | **Output** |
| --- | --- |
| 4Red -\&gt; hatRed -\&gt; dress,t-shirt,boxersWhite -\&gt; briefs,tanktopBlue -\&gt; glovesWhite tanktop | Red clothes:\* hat - 1\* dress - 1\* t-shirt - 1\* boxers - 1White clothes:\* briefs - 1\* tanktop - 1 (found!)Blue clothes:\* gloves - 1 |

| **Input** | **Output** |
| --- | --- |
| 5Blue -\&gt; shoesBlue -\&gt; shoes,shoes,shoesBlue -\&gt; shoes,shoesBlue -\&gt; shoesBlue -\&gt; shoes,shoesRed tanktop | Blue clothes:\* shoes - 9 |

1. Problem 7.\*The V-Logger

As you know vlogging (making short videos instead of written blogposts) is the new super trend among young people. You have always been very passionate about vloggers and their videos and now you decided to create a website, called &quot;The V-Logger&quot;, so to rank the most followed vloggers. Good thing that you are also a programmer, so you can easily track what vloggers do.

You need to implement functionality that allows **vloggers to register** in your website. Note that, every vlogger must have a **unique vloggername** , so to be recognizable by his followers.

**Vloggers** also like to **follow other vloggers** , so that they can see immediately when a new video is posted.

A vlogger **can follow**** as many other vloggers ****as he wants** , but he **cannot** follow **himself** or follow someone he is **already a follower** of.

### Input

The **input** will come as e sequence of strings, where each string will represent a **valid** command. The commands will be presented in the following format:

- &quot; **{vloggername}**&quot; **joined The V-Logger** – a vlogger got registered into your website.
  - Vloggernames **consist**** of only one word**.
  - If the **given**** vloggername **** is already taken ignore that command.**

- &quot; **{vloggername} followed {vloggername}**&quot; – The first vlogger followed the second vlogger.
  - If **any** of the **given vlogernames**** does not exist **in the log** ignore that command.**

- **&quot;**** Statistics ****&quot; -** Upon receiving this command you have to print a statistic about the registered vloggers in **&quot;The**** V-Logger&quot;.**

### Output

- On the first line you have to print **the total amount of vloggers** using &quot;The V-Logger&quot; in format:

**&quot;The V-Logger has a total of {registered vloggers} vloggers in its logs.&quot;**

- Then you have to find most famous vlogger (thevlogger with the most followers). He should be printed along with **his followers** , in the following format:

         &quot; **1.**  **{vlogger} : {followers} followers, {vloggers he is a follower of} following**

**         \*  ** {follower1}

 \*  {follower2} ... &quot;

-
  - If more than one vloggers have the same number of followers, you find **the one following less people**
  - The **followers** should be printed in **lexicographical order**.
  - If the vlogger has **no followers** , print only the **first line.**

- Last print **all other vloggers** , ordered by **number of followers (descending)** and **number of followings (ascending)** in the following format:

&quot; **{No}.**  **{vlogger} : {followers} followers, {vloggers he is a follower of} following****&quot;**

### Constraints

- There will be no invalid input.
- There will be no situation where two vloggers have equal amount of followers and equal amount of followings
- The subscribers will be strings.
- Allowed time/memory: **100ms/16MB**.

### Examples

| **Input** | **Output** |
| --- | --- |
| EmilConrad joined The V-LoggerVenomTheDoctor joined The V-LoggerSaffrona joined The V-LoggerSaffrona **followed** EmilConradSaffrona **followed** VenomTheDoctorEmilConrad **followed** VenomTheDoctorVenomTheDoctor **followed** VenomTheDoctorSaffrona **followed** EmilConradStatistics | The V-Logger has a total of 3 vloggers in its logs.1. VenomTheDoctor : 2 followers, 0 following\*  EmilConrad\*  Saffrona2. EmilConrad : 1 followers, 1 following3. Saffrona : 0 followers, 2 following                   |
| JennaMarbles joined The V-LoggerJennaMarbles followed ZoellaAmazingPhil joined The V-LoggerJennaMarbles followed AmazingPhilZoella joined The V-LoggerJennaMarbles followed ZoellaZoella followed AmazingPhilChristy followed ZoellaZoella followed ChristyJacksGap joined The V-LoggerJacksGap followed JennaMarblesPewDiePie joined The V-LoggerZoella joined The V-LoggerStatistics | The V-Logger has a total of 5 vloggers in its logs.1. AmazingPhil : 2 followers, 0 following\*  JennaMarbles\*  Zoella2. Zoella : 1 followers, 1 following3. JennaMarbles : 1 followers, 2 following4. PewDiePie : 0 followers, 0 following5. JacksGap : 0 followers, 1 following |

1. Problem 8.\*Ranking

Here comes the final and the most interesting part – the Final ranking of the candidate-interns. The final ranking is determined by the points of the interview tasks and from the exams in SoftUni. Here is your final task. You will receive some lines of input in the format **&quot;{contest}:{password for contest}&quot;** until you receive **&quot;end of contests&quot;**. Save that data because **you will need it later**. After that you will receive other type of inputs in format **&quot;{contest}=\&gt;{password}=\&gt;{username}=\&gt;{points}&quot;** until you receive **&quot;end of submissions&quot;**. Here is what you need to do.

- **** Check if the **contest is valid (if you received it in the first type of input)**
- **** Check if the **password is correct for the given contest**
- **** Save the user with the contest they take part in **(a user can take part in many contests)** and the points the user has in the given contest. If you receive the **same contest and the same user update the points only if the new ones are more than the older ones.**

At the end you have to print the info for the user with the **most points** in the format **&quot;Best candidate is {user} with total {total points} points.&quot;**. After that print **all students ordered by their names**. **For each user print each contest with the points in descending order**. See the examples.

### Input

- **** strings in format **&quot;{contest}:{password for contest}&quot;** until the **&quot;end of contests&quot;** command. There will be no case with two equal contests
- **** strings in format **&quot;{contest}=\&gt;{password}=\&gt;{username}=\&gt;{points}&quot;** until the **&quot;end of submissions&quot;** command.
- ****** There will be no case with 2 or more users with same total points!**

### Output

- **** On the first line print the best user in format **&quot;Best candidate is {user} with total {total points} points.&quot;.**
- **** Then print all students ordered as mentioned above in format:

**{user1 name}**

**#  {contest1} -\&gt; {points}**

**#  {contest2} -\&gt; {points}**

**{user2 name}**

**…**

### Constraints

- **** the strings may contain any ASCII character except from **(:, =, \&gt;)**
- **** the numbers will be in range **[0 - 10000]**
- **** second input is always valid

### Examples

| **Input** | **Output** |
| --- | --- |
| Part One Interview:successJs Fundamentals:PeshoC# Fundamentals:fundPassAlgorithms:funend of contestsC# Fundamentals=\&gt;fundPass=\&gt;Tanya=\&gt;350Algorithms=\&gt;fun=\&gt;Tanya=\&gt;380Part One Interview=\&gt;success=\&gt;Nikola=\&gt;120Java Basics Exam=\&gt;pesho=\&gt;Petkan=\&gt;400Part One Interview=\&gt;success=\&gt;Tanya=\&gt;220OOP Advanced=\&gt;password123=\&gt;BaiIvan=\&gt;231C# Fundamentals=\&gt;fundPass=\&gt;Tanya=\&gt;250C# Fundamentals=\&gt;fundPass=\&gt;Nikola=\&gt;200Js Fundamentals=\&gt;Pesho=\&gt;Tanya=\&gt;400end of submissions | Best candidate is Tanya with total 1350 points.Ranking: Nikola#  C# Fundamentals -\&gt; 200#  Part One Interview -\&gt; 120Tanya#  Js Fundamentals -\&gt; 400#  Algorithms -\&gt; 380#  C# Fundamentals -\&gt; 350#  Part One Interview -\&gt; 220 |
| Java Advanced:funpassPart Two Interview:successMath Concept:asdasdJava Web Basics:forrFend of contestsMath Concept=\&gt;ispass=\&gt;Monika=\&gt;290Java Advanced=\&gt;funpass=\&gt;Simona=\&gt;400Part Two Interview=\&gt;success=\&gt;Drago=\&gt;120Java Advanced=\&gt;funpass=\&gt;Petyr=\&gt;90Java Web Basics=\&gt;forrF=\&gt;Simona=\&gt;280Part Two Interview=\&gt;success=\&gt;Petyr=\&gt;0Math Concept=\&gt;asdasd=\&gt;Drago=\&gt;250Part Two Interview=\&gt;success=\&gt;Simona=\&gt;200end of submissions | Best candidate is Simona with total 880 points.Ranking: Drago#  Math Concept -\&gt; 250#  Part Two Interview -\&gt; 120Petyr#  Java Advanced -\&gt; 90#  Part Two Interview -\&gt; 0Simona#  Java Advanced -\&gt; 400#  Java Web Basics -\&gt; 280#  Part Two Interview -\&gt; 200 |