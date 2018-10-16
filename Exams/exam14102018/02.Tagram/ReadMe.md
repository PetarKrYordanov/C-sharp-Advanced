# Tagram

You will receive **several input lines** in one of the following formats:

- &quot;{username} -\&gt; {tag} -\&gt; {likes}&quot;
- &quot;ban {username}&quot;

The **username**  **and**  **tag** are strings. **Likes** will be an integer number. You need to keep track of **every user**.

When you receive a **user** ,  a **tag** and **likes** , register the user if **he isn&#39;t present** , **otherwise**  **add** the tag and the likes. If the user has already used the tag just add the likes to it.

If you receive **&quot;ban {username}&quot;** and **the username exists** , remove him from the database.

You should end your program when you receive the command **&quot;end&quot;**. At that point you should print the users, **ordered by total likes in desecending order, then ordered by the tags&#39; count in ascending order**. **Foreach** player print their tag and likes.

## Input / Constraints

- The input comes in the form of commands in one of the formats specified above.
- Username and tag **will always be one word string, containing no whitespaces**.
- Likes will be an **integer** in the **range [0, 1000]**.
- There will be **no invalid** input lines.
- The programm ends when you receive the command **&quot;end&quot;**.

## Output

- The output format for each player is:

&quot;{username}&quot;

&quot;- {tag}: {likes}&quot;

## Examples

| **Input** | **Output** |
| --- | --- |
| Katty -\&gt; healthy -\&gt; 50Elvin -\&gt; food -\&gt; 20John -\&gt; music -\&gt; 30Katty -\&gt; fitness -\&gt; 100end | Katty- healthy: 50- fitness: 100John- music: 30Elvin- food: 20 |
| **Input** | **Output** |
| Monica -\&gt; music -\&gt; 100Monica -\&gt; dance -\&gt; 50John -\&gt; chill -\&gt; 200Santa -\&gt; angry -\&gt; 300ban SantaJoshua -\&gt; football -\&gt; 500end | Joshua- football: 500John- chill: 200Monica- music: 100- dance: 50 |