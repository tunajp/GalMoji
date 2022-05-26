namespace GalMoji;
public class Encoder
{
    private Table table;
    public Encoder() {
        table = new Table();
    }
    public string Encode(string text ,bool random = false) {
        string[] array = text.ToCharArray().Select(c => new string(c, 1)).ToArray();
        string temp = "";
        foreach(string c in array) {
            bool found = false;
            foreach(KeyValuePair<string, List<string>> item in table.mojiTable) {
                if (item.Key == c) {
                    int index = 0;
                    if (random) {
                        Random r = new System.Random();
                        index = r.Next(0, item.Value.Count);
                    }
                    temp += item.Value[index];
                    found = true;
                    break;
                }
            }
            if (!found) temp += c;
        }
        return temp;
    }

    public string WordConv(string text) {

        throw new NotImplementedException();

        // https://bosesound.blog.fc2.com/blog-category-3.html
        // http://news4wide.net/article/480042157.html
        // TODO:形態素解析(https://github.com/komutan/NMeCab)
        // TODO:ひらがな

        // replace
        /*
        if (text == @"ほんとう(に)") return "まぢ(で)";
        if (text == @"くわしく") return "kwsk";
        if (text == @"あいしてる") return "らぶぽよ";
        if (text == @"やばい") return "やばたん";
        if (text == @"つらい") return "つらたん";
        if (text == @"ありがとう") return "39";
        if (text == @"です") return "";
        if (text == @"します") return "";
        if (text == @"(おもい)ます") return "(おも)う";
        return "";
        */
    }
}
