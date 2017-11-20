namespace _03.BarrackWars_ANewFactory.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class InjectAttribute : Attribute
    {
    }
}