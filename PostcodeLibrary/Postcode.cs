using System.Text.RegularExpressions;

namespace PostcodeLibrary
{
    public class Postcode
    {
        private const string Pattern = "^([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9]?[A-Za-z])))) [0-9][A-Za-z]{2})$";

        public bool Test(string postcode)
        {
            if(string.IsNullOrEmpty(postcode)) return false;

            var regex = new Regex(Pattern);
            Match match = regex.Match(postcode);
            return match.Success;
        }
    }
}
