# The Factory


מטרת המשחק : להמשיך לטפס למעלה ולא ליפול לתהום. למשחק ב- itch.io לחץ כאן: [click here](https://m-h-a.itch.io/jumpup)

מקשים : A- שמאלה , D- ימינה

קישורים ל scripts :


תפקיד המחקלה PlayerMovement זה הזזה של השחקן ופניה שלו שמאלה וימינה בהתאם למקשים.


PlayerMovement script - [click here](Assets/Scripts/PlayerMovement.cs)
##

תפקיד המחקלה Platfrom זה כשאר יש התנגשות של השחקן עם הפלטפורם אז הוא נתקע וממשיך לקפוץ לאותו גובה( בעצם כמו טרמפולינה).


Platform script - [click here](Assets/Scripts/Platform.cs)
##

תפקיד המחלקה CameraFollow זה לעקוב אחרי השחקן וכאשר הוא מתחיל לצאת מהפריים(מבחינת ציר ה-y) המצלמה עולה איתו.


CameraFollow script - [click here](Assets/Scripts/CameraFollow.cs)
##


תקפיד המחלקה LevelGenerator זה ליצור מספר פלטפורם במיקומים במסך בצורה רנדומלית על ציר ה-y וה-x לפי הפרמטרים שהגדרנו במחלקה.


LevelGenerator script - [click here](Assets/Scripts/LevelGenerator.cs)
