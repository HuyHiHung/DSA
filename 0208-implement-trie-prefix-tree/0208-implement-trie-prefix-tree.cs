public class TrieNode {
    public Dictionary<char, TrieNode> children = new();
    public bool isEnd = false;
}

public class Trie {
    private TrieNode root;

    public Trie() {
        root = new TrieNode();
    }

    public void Insert(string word) {
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
        TrieNode curr = root;

        foreach (char c in word) {
            if (!curr.children.ContainsKey(c))
                return false;

            curr = curr.children[c];
        }

        return curr.isEnd;
    }

    public bool StartsWith(string prefix) {
        TrieNode curr = root;

        foreach (char c in prefix) {
            if (!curr.children.ContainsKey(c))
                return false;

            curr = curr.children[c];
        }

        return true;
    }
}