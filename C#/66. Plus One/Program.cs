public class Solution {
    public int[] PlusOne(int[] digits) {
        int n = digits.Length;
        
        // Идем с конца массива
        for (int i = n - 1; i >= 0; i--) {
            if (digits[i] < 9) {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        
        // Если все цифры были 9, создаем новый массив
        int[] newDigits = new int[n + 1];
        newDigits[0] = 1;
        return newDigits;
    }
}