public class Solution {

    public IList<string> LetterCombinations(string digits) {
        List<string> rs = new List<string>();
        int len = digits.Length;
        if(len==0) return rs;

        string[] phone =
        {
            "",     // 0
            "",     // 1
            "abc",  // 2
            "def",  // 3
            "ghi",  // 4
            "jkl",  // 5
            "mno",  // 6
            "pqrs", // 7
            "tuv",  // 8
            "wxyz"  // 9
        };

        StringBuilder curr = new StringBuilder();

        void backTrack(int index){
            if(index == len){
                rs.Add(curr.ToString());
                return;
            }
            // chuyen char ve int
            int digit = digits[index] - '0';
            string letters = phone[digit];

            foreach (char c in letters) {
                curr.Append(c);
                // tiep toi so tiep theo
                backTrack(index + 1);
                
                curr.Length--;

            }
        }

        backTrack(0);
        return rs;
    }
}