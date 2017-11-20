using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConTestApp
{
    public class RSA
    {
        public static void Main(String[] args)
        {
            //UnicodeEncoding ByteConverter = new UnicodeEncoding();

            //var csp = new RSACryptoServiceProvider();
            //var par = csp.ToXmlString(true);

            //string data = "this is a secret message";

            //byte[] dataToEnc = ByteConverter.GetBytes(data);
            //var crypted = csp.Encrypt(dataToEnc, true);

            //Console.WriteLine("Enc: @\"{0}\"", Convert.ToBase64String(crypted));

            //var decrypted = csp.Decrypt(crypted, true);
            //Console.WriteLine("Dec: @\"{0}\"", ByteConverter.GetString(decrypted));

            //Console.ReadLine();

            //var pwd = @"c9Vaowwgzy1UXLHrs4Wm9O1TKJ4I2dav7xmiP7iXw85TXDc8AYGOVddGOa5r4NBtK4UNE1QOVeRdYlOpbjFtHNRvsG31FgnoedtLYe1N3Idl0z5/DwP1lLU/zNFlEtm2/XOOhKuGF1076G0fl0CE7C/tyDjMp6X6GdFOT0WpyDk=";

            //var csp1 = new RSACryptoServiceProvider();
            //csp1.FromXmlString(par);

            //var dec1 = csp1.Decrypt(crypted, true);
            //Console.WriteLine("Another Dec: @\"{0}\"", ByteConverter.GetString(dec1));

            //Console.ReadLine();

            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            var pwd = @"DLmdIwGVKFpSo7igLzre/g9eShQcdncXJ+eW1QhprR7KGE8Xsl+A+l48aCcrJqLUaUqpiJ+D0uJMGYyezmgI7toCuOTwCx/+RDpK1yIqjjlBuAmVNbXqHuyWL7PJXxA8OvWLlIjHlnvm7oOY+JdJFRylbjwph6qTMzmwioEt/4s=";
            var xmlData = @"<RSAKeyValue><Modulus>z09m/ssyAnat8e/Obe9tSTuzoz/8Ok6uwxQp+TuvWA/joRRsI4YkLQbdsj7bEawqjgN1Ag2GLttiYN1rZ4VHO1NdUbXTCfDh43u6B9K2LtvGT56XP/4twIrR4UgmNgNdeomDR8HFv1eHDKiUAm7VlegBvbdlQqh2kDxZ7oPVfck=</Modulus><Exponent>AQAB</Exponent><P>1UUxF/zon+k3SW5Yd1z1th64faseFU7z+bZ5OMIUZytItH0gR+ogMleTYZU7OzLelDRDoxRLgIs9kX0TOp1mww==</P><Q>+NiC56nzzDEcF6mpfsxpNY+mAXc8ca/oNlDmNxWZn5Ke5DEnJ+NsULQsiZCl3BcmV54tRw7MJ1AKjUr3xX/4gw==</Q><DP>OPBNKCNck/z2xsMQGWYXL7VJ+jsqP/QhTQT7njyqp9S1h4J0kN6gE/Cvp3jpJGfzZswBVtO/SKVkHaiv7pFBcw==</DP><DQ>Su0+NSzqGIBs+f7+5wv7XcI79NMHIyAZJkmjl9BsKi0GpKTcKlmC4qXthxpDpopd5CHfdjbRZ8Dk/HgnNJN8qw==</DQ><InverseQ>1LsaCyhlunFZ0DN7bz6LeOZMpieOBlrtjAxj15M7qFPmDOr2rEcsU6HZX3wfDkFzxgpiC826z8jkPFu5117u6A==</InverseQ><D>kf2Qwo3FwgZhqKb/8FtT0ubAMo60yTrvx2FDzchCSvmli6IeJUYp46uaJBQvodpkfW3h0HhFrmnAdgZ3xIcPCWrUyfOoWMXQ46Jdx1Lxtt2VfrBwWcf8tcNaKOZzJ0C3/3qqBXe0GdeYnQoprEFCf++YP7Wsiyv6LmbkfhwcZSE=</D></RSAKeyValue>";

            var csp = new RSACryptoServiceProvider();
            csp.FromXmlString(xmlData);

            string data = "nilesh123";

            byte[] dataToEnc = ByteConverter.GetBytes(data);
            var crypted = csp.Encrypt(dataToEnc, true);
            var encrypted = Convert.ToBase64String(crypted);
            var password = csp.Decrypt(Convert.FromBase64String(pwd), true);
            var pass = ByteConverter.GetString(password);


            /////
            //UnicodeEncoding ByteConverter = new UnicodeEncoding();
            //var pwd = @"c9Vaowwgzy1UXLHrs4Wm9O1TKJ4I2dav7xmiP7iXw85TXDc8AYGOVddGOa5r4NBtK4UNE1QOVeRdYlOpbjFtHNRvsG31FgnoedtLYe1N3Idl0z5/DwP1lLU/zNFlEtm2/XOOhKuGF1076G0fl0CE7C/tyDjMp6X6GdFOT0WpyDk=";

            //RSAParameters param = new RSAParameters()
            //{
            //    D = ByteConverter.GetBytes(@"ZPMmplZFdVsEkFErrt7s8KZNxAv4vDeSmCi6yANtCE3egSVQ71IiW6wVPT07BadzCjR+TgkkrfTuDdLPM/csQVnD57Nifa4kDNY5qYCcUAdJ6lSF7qxFqgEKCCls6kVXS9u44Ny43+rZD0f1z2K+8bamaHHn8iL9EztJqC+jFJ0="),
            //    DP = ByteConverter.GetBytes(@"CjVn1l11LDl3XQsvcE6XacOuWnE926XpfxyYCKxv2qgD9sGh7HZqIl1aeiEebUCHVblCfA9N/xBbMZp6WFp7Ow=="),
            //    DQ = ByteConverter.GetBytes(@"aZBcOvAoEV5Kp6jfWPK0fTfrZckZHFRLMtHwrjOx0vK8iOG7wjE9g2Kj5zG42pcTlLaWzo+Xrc1Ep3wmAGTllw=="),
            //    Exponent = ByteConverter.GetBytes(@"AQAB"),
            //    InverseQ = ByteConverter.GetBytes(@"A0Cv4xJ9xpykp2VhuxGvDfROcmUkwtE24bPyxDTqhNmuE+kDAHUo/YlSg5Omo7+hFAtJ56RcdtK9WOP63kY+ig=="),
            //    Modulus = ByteConverter.GetBytes(@"3MoHTwZc7ks261B8hwplRMaRIvcqE85WEBtdGkodD99jenMYlaLxkZcUN1j2r9M9MVVlB2++crdSffPk9WJGhzRFXeVnIs+vHfGDCUuNEh02cg8tIw7ahne8dDYxis9yc4g2HbQSWj+V/5n6eHmAHoufM7SUz5wTUxSQ6hv3DBU="),
            //    P = ByteConverter.GetBytes(@"4QoUIS1W2x1T08me/5JyNdNn8X+5d8HBktKMHwoev6p2NQIJ/ysE+auDnXURryP1LA1zaaMCAyFYmhsImKe0Aw=="),
            //    Q = ByteConverter.GetBytes(@"+ypB4xmAodjV9pvZZDwp0l7u9imSEQ7bRYnCMm6dtF8gm9Lf9pqXej5uADg1uLccEypii1/xZylfDjfCLqBgBw=="),
            //};

            //var csp = new RSACryptoServiceProvider();
            //var test = csp.ToXmlString(true);
            //csp.ImportParameters(param);
            //var password = csp.Decrypt(Convert.FromBase64String(pwd), true);


            ///
        }
    }
}
