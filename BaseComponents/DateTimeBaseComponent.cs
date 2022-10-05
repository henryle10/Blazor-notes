using System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components;
using System.Reflection;

namespace BlazorServerSide.BaseComponents
{
    public class DateTimeBaseComponent : ComponentBase
    {
        public DateTime dateTime { get; set; }
    }
}
