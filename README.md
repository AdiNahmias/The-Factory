# The Factory


מטרת המשחק : לקחת את החבילה לנקודת הסיום. למשחק ב- itch.io לחץ כאן: [click here](https://m-h-a.itch.io/jumpup)

בכל שלב נצטרך על ידי מעבר מכשולים ועזרה במשאבים להגיע לחבילה ולקחת אותה לנקודת הסיום. נצטרך להעזר במשאבים כמו לעלות בסולמות, להשתמש בקופסאות כדי לקפוץ מהם לפלטפורמה גבוהה וכו.

מקשים : Left Arrow- שמאלה , Right Arrow- ימינה , Up Arrow - לעלות למעלה בסולם , Down Arrow - לרדת למטה בסולם , Space - לקפוץ ,     F - לתפוס בחבילה/לשחרר את החבילה.

קישורים ל scripts :


תפקיד המחקלה PlayerMovement זה הזזה של השחקן ופניה שלו שמאלה, ימינה, למעלה, קפיצה, וסיבוב השחקן כאשר פונה לכל צד.


PlayerMovement script - [click here](Assets/Scripts/PlayerMovement.cs)
##

תפקיד המחקלה LadderDetaction זה כשאר יש התנגשות של השחקן עם הסולם אז הוא יכול לעלות ולרדת בסולם.


Platform script - [click here](Assets/Scripts/Platform.cs)
##

תפקיד המחלקה CameraController זה לעקוב אחרי השחקן.


CameraFollow script - [click here](Assets/Scripts/CameraFollow.cs)
##


תקפיד המחלקה GrabController זה כאשר לוחצים על המקש F ליד האוביקט מסוג package אז אפשר להרים/לזרוק אותו כדי להגיע איתו לקו הסיום.


LevelGenerator script - [click here](Assets/Scripts/LevelGenerator.cs)
