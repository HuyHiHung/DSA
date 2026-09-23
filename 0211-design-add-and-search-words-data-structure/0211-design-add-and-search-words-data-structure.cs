public class TrieNode {
    public Dictionary<char, TrieNode> children = new();
    public bool isEnd = false;
}

public class WordDictionary {
    private TrieNode root;

    public WordDictionary() {
        root = new TrieNode();
    }

    public void AddWord(string word) {
        TrieNode curr = root;

        foreach (char c in word) {
            if (!curr.children.ContainsKey(c)) {
                curr.children[c] = new TrieNode();
            }

            curr = curr.children[c];
        }

        curr.isEnd = true;
    }

    public bool Search(string word) {
        Queue<TrieNode> q = new();
        q.Enqueue(root);

        int i = 0;

        while (i < word.Length) {
            int currDepth = q.Count;

            if (currDepth == 0)
                return false;

            while (currDepth > 0) {
                TrieNode curr = q.Dequeue();

                if (word[i] == '.') {
                    foreach (var item in curr.children) {
                        q.Enqueue(item.Value);
                    }
                }
                else {
                    if (curr.children.ContainsKey(word[i])) {
                        q.Enqueue(curr.children[word[i]]);
                    }
                }

                currDepth--;
            }

            i++;
        }

        while (q.Count > 0) {
            if (q.Dequeue().isEnd)
                return true;
        }

        return false;
    }
}


            // if( c == '.'){
            //     foreach (var item in root.children)
            //     {
            //         s.Add(item.value);
            //     }
            // } else {
            //     foreach(var item in root.children){
            //         if(item.key == word[i]) {
            //             s.Add(item.value);
            //         }
            //     }
            // }