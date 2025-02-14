using System;
namespace Щур_В_О_КПО_1;

public class Herbo : Animal
{
    public int KindnessLevel { get; set; }

    public override bool CanInteractWithVisitors()
    {
        return KindnessLevel > 5;
    }
}
