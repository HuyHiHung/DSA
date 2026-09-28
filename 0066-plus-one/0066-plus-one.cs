public class Solution {
    public int[] PlusOne(int[] digits) {
        int tailIndex = digits.Length - 1;
        int surplus = 0;
        for(;tailIndex >= 0; --tailIndex){
            int newDigit = digits[tailIndex] + 1;
            if(newDigit >= 10){
                digits[tailIndex] = newDigit % 10;
                surplus = 1;
            } else {
                digits[tailIndex] = newDigit;
                surplus = 0;
                break;
            }
        }
        if (surplus != 0)
        {
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }
        return digits;
    }
}