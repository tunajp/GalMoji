namespace UnitTest;
using GalMoji;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        bool result = false;
        Encoder enc = new Encoder();
        string text = enc.Encode("ギャル文字（ギャルもじ）とは、携帯電話のメールなどで文字を分解・変形させて文字を表現する遊び・手法。またそれらの文字そのものの呼称。 「へた文字」とも呼ばれる。");
        string gal = "≠″ｬ｣ﾚ文字（≠″ｬ｣ﾚм○ι″）ー⊂l￡、携帯電言舌＠乂─｣ﾚﾅょー⊂″τ″文字ぉ分解・変形､ﾅ世τ文字ぉ表王見￡ゑぇ方字ひ″・手シ去。маﾅﾆξяёяа＠文字ξ＠м○＠＠ロ乎禾尓。 「∧ﾅﾆ文字」ー⊂м○ロ乎ﾚよ″яёゑ。";
        if (text == gal) result = true;
        Assert.IsTrue(result, string.Format("ok"));

        text = enc.Encode("ギャル文字（ギャルもじ）とは、携帯電話のメールなどで文字を分解・変形させて文字を表現する遊び・手法。またそれらの文字そのものの呼称。 「へた文字」とも呼ばれる。", true);
        if (text != gal) result = true;
        Assert.IsTrue(result, string.Format("ok"));
    }
}