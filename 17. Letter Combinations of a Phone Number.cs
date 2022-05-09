//直接一個switch收工，有點醜，不過能動。
public class Solution
{
    IList<string> L;
    string _digits = "";
    public IList<string> LetterCombinations(string digits)
    {
        _digits = digits;
        L = new List<string>();
        if (_digits.Length > 0)
        {
            F("", 0);
        }
        return L;
    }

    public void F(string S, int i)
    {
        if (i == _digits.Length)
        {
            L.Add(S);
            return;
        }
        switch (_digits[i])
        {
            case '2':
                i++;
                F(S + 'a', i);
                F(S + 'b', i);
                F(S + 'c', i);
                break;
            case '3':
                i++;
                F(S + 'd', i);
                F(S + 'e', i);
                F(S + 'f', i);
                break;
            case '4':
                i++;
                F(S + 'g', i);
                F(S + 'h', i);
                F(S + 'i', i);
                break;
            case '5':
                i++;
                F(S + 'j', i);
                F(S + 'k', i);
                F(S + 'l', i);
                break;
            case '6':
                i++;
                F(S + 'm', i);
                F(S + 'n', i);
                F(S + 'o', i);
                break;
            case '7':
                i++;
                F(S + 'p', i);
                F(S + 'q', i);
                F(S + 'r', i);
                F(S + 's', i);
                break;
            case '8':
                i++;
                F(S + 't', i);
                F(S + 'u', i);
                F(S + 'v', i);
                break;
            case '9':
                i++;
                F(S + 'w', i);
                F(S + 'x', i);
                F(S + 'y', i);
                F(S + 'z', i);
                break;
            default:
                break;
        }
        return;
    }
}