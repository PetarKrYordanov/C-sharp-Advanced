# Data Transfer

You will be given several lines of **messages containing data**. You have to **check for the validity of the lines**. A **valid** line should be in the format: **&quot;s:{sender};r:{receiver};m--&quot;{message} &quot;&quot;**

- **sender –** could contain **any ascii character except for &quot;;&quot;**
- **receiver –** could contain **any ascii character except for &quot;;&quot;**
- **message –** should contain **only letters and spaces**

In each valid message there is a **hidden size of data transfer.** The size of the data transfer is **calculated by the sum of all digits in the names of the sender and receiver**. After each valid message print a line in the format: &quot; **{senderName} says &quot;{currentMessage}&quot; to {recieverName}&quot;.** The **printed names should contain only letters and spaces**. Example: sender &quot;P@e$5sh#o Go^4sh5ov&quot; is **valid** and **matches** , but when printing his name, **we only print**&quot;Pesho Goshov&quot;.

At the end print a line in the format **&quot;Total data transferred: {totalData}MB&quot;**.

## Input / Constraints

- First line will be a number **n** in range [1, 100].
- The next **n** lines will be **strings**.

## Output

- Print each valid message in the format described above.
- Print the total amount of data transfer.

## Examples

| **Input** | **Output** |
| --- | --- |
| 3s:P5%es4#h@o;r:G3#o!!s2h#2o;m--&quot;Attack&quot;s:G3er%6g43i;r:Kak€$in2% re3p5ab3lic%an;m--&quot;I can sing&quot;s:BABAr:Ali;m-No cave for you | Pesho says &quot;Attack&quot; to GoshoGergi says &quot;I can sing&quot; to Kakin repablicanTotal data transferred: 45MB |
| 5s:B^%4i35454l#$l;r:Mo5l#$34l%y;m--&quot;Run&quot;s:Ray;r:To^^5m;m--&quot;Hidden Message&quot;bla;r:1234a;m--Hellos:M#$%$#^6767687654545e;r:Yo54$#@#u5;m--&quot;$$$&quot;s:M#$@545e;r:You241$@#23;m&quot;Hello&quot; | Bill says &quot;Run&quot; to MollyRay says &quot;Hidden Message&quot; to TomTotal data transferred: 42MB |