 public static int Clamp(int value, int min, int max)
 {
     if (min > max)
     {
         throw new ArgumentException($"Недопустимый диапазон: {nameof(min)} ({min}) не может быть больше, чем {nameof(max)} ({max})");
     }

     if (value < min)
         return min;
     else if (value > max)
         return max;
     else
         return value;
 }
