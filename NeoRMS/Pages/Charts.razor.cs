using Microsoft.AspNetCore.Components;

namespace NeoRMS.Pages
{
    public class ChartsBase: ComponentBase
    {

        protected string[] _datas = { "Positive", "Neutral", "Negative" };

        protected int[] _values = { 40, 20, 5 };

    }
}
