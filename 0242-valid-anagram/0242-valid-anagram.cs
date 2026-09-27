public class Solution {
    public bool IsAnagram(string s, string t) {
        // Stack<char> stack = new();
        // foreach(char c in s){
        //     stack.Push(c);
        // }
        // foreach(char c in t){
        //     if(stack.Count == 0) return false;
        //     if(c != stack.Pop()) return false;
        // 
        // if(stack.Count != 0) return false;
        // return true;
        Dictionary<char,int> dic = new();
        foreach(char c in s){
            if(!dic.ContainsKey(c)){
                dic.Add(c,1);
            } else dic[c]++;
        }
        foreach(char c in t){
            if(!dic.ContainsKey(c)) return false;
            dic[c]--;
        }
        foreach(var i in dic){
            if(i.Value != 0) return false;
        }
        return true;
    }
}