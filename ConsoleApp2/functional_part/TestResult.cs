[Serializable]
public class TestResult
{
    private string subject;
    private int result;
    private int score;
    public TestResult() { }
    public TestResult(string subject = "", int result = 0, int score = 1)
    {
        this.subject = subject;
        this.result = result;
        this.score = score;
    }
    public string Subject { get { return subject; } set { subject = value; } }
    public int Result { get { return result; } set { result = value; } }
    public int Score { get { return score; } set { score = value; } }
    public override string ToString()
    {
        return $"{Subject}, {Result}, {Score}";
    }
}