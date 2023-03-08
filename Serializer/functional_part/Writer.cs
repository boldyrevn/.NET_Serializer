abstract class Writer
{
    protected string path;
    public Writer(string path)
    {
        this.path = path;
    }
    public abstract void writeCollection(List<TestResult> list);
}
