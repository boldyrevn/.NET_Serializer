abstract class Reader
{
    protected string path;
    public Reader(string path)
    {
        this.path = path;
    }
    public abstract List<TestResult> getCollection();
}