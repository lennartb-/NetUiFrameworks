namespace Wpf
{
    public class SampleModelProvider
    {
        private static int modelCounter;

        public SampleModel GetModel()
        {
            return new SampleModel($"Name{modelCounter}",$"Image{modelCounter++}");
        }
    }
}