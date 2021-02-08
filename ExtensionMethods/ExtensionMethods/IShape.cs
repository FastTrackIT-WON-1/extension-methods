namespace ExtensionMethods
{
    public interface IShape
    {
        Point[] Points
        {
            get;
        }

        double GetArea();
    }
}
