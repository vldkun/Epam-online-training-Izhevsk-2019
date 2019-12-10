using System;

namespace Module09
{
    /// <summary>
    /// Izh-09-3. Framework Fundamentals
    /// </summary>
    public class Task3
    {
        /// <summary>
        /// Manipulating URL parameters. It able to add a parameter to an existing URL, but also to change a parameter if it already exists.
        /// </summary>
        /// <param name="url">An existing URL to change.</param>
        /// <param name="keyValueParameter">Parameter to add.</param>
        /// <returns>Returns changed URL.</returns>
        public static string AddOrChangeUrlParameter(string url, string keyValueParameter)
        {
            if (url.Contains("?"))
            {
                string[] param = keyValueParameter.Split('=');
                if (url.Contains(param[0]+"="))
                {
                    char[] splitOptions = {'&', '#', '=', '?'};
                    string[] urlSplit = url.Split(splitOptions);
                    var keyIndex = Array.IndexOf(urlSplit, param[0]);
                    return url.Replace(urlSplit[keyIndex] + "=" + urlSplit[keyIndex + 1], keyValueParameter);
                }

                if (url.Contains("#"))
                {
                    return url.Insert(url.IndexOf('#'), "&" + keyValueParameter);
                }

                return url + "&" + keyValueParameter;
            }

            if (url.Contains("#"))
            {
                var fragmentIndex = url.IndexOf('#');
                return url.Substring(0, fragmentIndex) + "?" + keyValueParameter + url.Substring(fragmentIndex);
            }

            return url + "?" + keyValueParameter;
        }
    }
}
