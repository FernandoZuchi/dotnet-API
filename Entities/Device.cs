namespace dotnet_C__API;

public abstract class Device
{
    protected bool IsConnected() => false;

    public abstract string GetBrand();

    public virtual string Hello()
    {
        return "Hello world";
    }
}