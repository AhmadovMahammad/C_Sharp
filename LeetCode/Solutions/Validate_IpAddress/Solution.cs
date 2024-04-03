using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Validate_IpAddress
{
    [TestClass]
    public class ValidateIpAddress_Medium_468
    {
        [TestMethod]
        public void Solve()
        {
            var queryIp = "172.16.254.1";
            var result = ValidIPAddress(queryIp);
            result.Should().Be("IPv4");
        }
        [TestMethod]
        public void Solve2()
        {
            var queryIp = "2001:0db8:85a3:0:0:8A2E:0370:7334";
            var result = ValidIPAddress(queryIp);
            result.Should().Be("IPv6");
        }
        [TestMethod]
        public void Solve3()
        {
            var queryIp = "256.256.256.256";
            var result = ValidIPAddress(queryIp);
            result.Should().Be("Neither");
        }

        private readonly string _v4 = "IPv4";
        private readonly string _v6 = "IPv6";
        private readonly string _neither = "Neither";
        public string ValidIPAddress(string queryIP)
        {
            var formattedQuery = queryIP.ToLower();

            var response = formattedQuery.Contains('.')
              ? CheckV4(formattedQuery)
              : (formattedQuery.Contains(':') ? CheckV6(formattedQuery) : _neither);
            return response;
        }
        public string CheckV4(string queryIP)
        {
            //Base Rule : A valid IPv4 address is an IP in the form "x1.x2.x3.x4" where 0 <= x[i] <= 255
            //1) 256.256.256.256 should be : Neither
            //2) 172.16.254.1 should be : IPv4

            var sections = queryIP.Split(".");
            if (sections.Length != 4)
                return _neither;

            foreach (var section in sections)
            {
                // check each part's length, it may be like this 121..1.1
                if (section.Length == 0 || section.Length > 3 || (section.Length > 1 && section.StartsWith('0')))
                    return _neither;
                if (!int.TryParse(section, out int pureInteger) || pureInteger > 255)
                    return _neither;
            }
            return _v4;
        }
        public string CheckV6(string queryIP)
        {
            //Base Rule : A valid IPv6 address is an IP in the form "x1:x2:x3:x4:x5:x6:x7:x8" 
            //1) 1 <= x[i].Length <= 4
            //2) x[i] is a hexadecimal string which may contain digits, ...
            //lowercase English letter ('a' to 'f') and upper-case English letters ('A' to 'F').

            var sections = queryIP.Split(":");
            if (sections.Length != 8)
                return _neither;

            // letter > 102 expression, because in ASCII table, g starts from 102nd row
            foreach (var section in sections)
                if (section.Length == 0 || section.Length > 4 || section.Any(letter => letter > 102))
                    return _neither;
            return _v6;
        }
    }
}
