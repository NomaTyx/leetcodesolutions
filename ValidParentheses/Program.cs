//leetcode easy
//TIL what a stack is
bool IsValid(string s) {
    Stack<char> chars = new Stack<char>();

    foreach (char c in s) {
        switch(c) {
            default:
                chars.Push(c);
                break;
            case ')':
                if(chars.Count == 0) return false;
                if(chars.Peek() == '(') {
                    chars.Pop();
                } else {
                    chars.Push(c);
                }
                break;
            case '}':
                if(chars.Count == 0) return false;
                if(chars.Peek() == '{') {
                    chars.Pop();
                } else {
                    chars.Push(c);
                }
                break;
            case ']':
                if(chars.Count == 0) return false;
                if(chars.Peek() == '[') {
                    chars.Pop();
                } else {
                    chars.Push(c);
                }
                break;
        }
    }

    return chars.Count == 0;
}