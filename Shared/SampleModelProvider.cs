namespace Shared;

public class SampleModelProvider
{
    private static int modelCounter;

    public static SampleModel GetModel()
    {
        return new SampleModel($"Name{modelCounter}", $"Image{modelCounter++}", modelCounter % 2 == 0);
    }
}