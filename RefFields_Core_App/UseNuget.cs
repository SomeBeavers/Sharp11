using RefFields_nuget;

namespace RefFields_Core_App;

public class UseNuget
{
    public void Test(scoped ref StructFromNuget parameter) => parameter.MyRefField = 1;
}