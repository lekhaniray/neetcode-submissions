public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach(char c in s){
            if (c == '(' || c == '{' || c == '['){
                stack.Push(c);
            }
            else{
                if(stack.Count == 0) return false;
                char pop = stack.Peek();
                if((c == ')' && pop == '(')
                || (c == ']' && pop == '[')
                || (c == '}' && pop == '{')){
                    stack.Pop();
                }
                else{
                    return false;
                }


            }

        }

        return stack.Count == 0;
            

        
    }
}
