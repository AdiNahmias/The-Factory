# The Factory


מטרת המשחק : לקחת את החבילה לנקודת הסיום. 

למשחק ב- itch.io לחץ כאן: [click here](https://m-h-a.itch.io/factory2d)

בכל שלב נצטרך על ידי מעבר מכשולים ועזרה במשאבים להגיע לחבילה ולקחת אותה לנקודת הסיום. נצטרך להעזר במשאבים כמו לעלות בסולמות, להשתמש בקופסאות כדי לקפוץ מהם לפלטפורמה גבוהה וכו.

מקשים : Left Arrow- שמאלה , Right Arrow- ימינה , Up Arrow - לעלות למעלה בסולם , Down Arrow - לרדת למטה בסולם , Space - לקפוץ , F - לתפוס בחבילה/לשחרר את החבילה.

קישורים ל scripts : (הסברים של הקוד נמצאים בתוך הקוד עצמו)


תפקיד המחקלה PlayerMovement זה הזזה של השחקן ופניה שלו שמאלה, ימינה, למעלה, קפיצה, וסיבוב השחקן כאשר פונה לכל צד.


PlayerMovement script - [click here](Assets/Scripts/PlayerMovement.cs)
##

תפקיד המחקלה LadderDetaction זה כאשר יש התנגשות של השחקן עם הסולם(מזהה שהוא סולם על ידי זה שיש לו רכיב בשם Ladder שזה השם של הscript) אז הוא יכול לעלות ולרדת בסולם.


LadderDetaction script - [click here](Assets/Scripts/LadderDetaction.cs)
##

תפקיד המחלקה CameraController זה לעקוב אחרי השחקן.


CameraController script - [click here](Assets/Scripts/CameraController.cs)
##


תקפיד המחלקה GrabController זה כאשר לוחצים על המקש F ליד האוביקט מסוג package אז אפשר להרים/לזרוק אותו כדי להגיע איתו לקו הסיום.


GrabController script - [click here](Assets/Scripts/GrabController.cs)
##

תקפיד המחלקה Finish זה כאשר יש התנגשות של החבילה עם הדל סיום אז עוברים לשלב הבא.


Finish script - [click here](Assets/Scripts/Finish.cs)
