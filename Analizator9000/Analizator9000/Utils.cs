using System;

namespace Analizator9000
{
    /// <summary>
    /// Random utility class.
    /// </summary>
    class Utils
    {
        /// <summary>
        /// Provides a timestamped filename in uniform format.
        /// </summary>
        /// <param name="extension">Desired file extension.</param>
        /// <returns>Filename prefixed with program identificator, containing a timestamp for request.</returns>
        static public String getFilename(String extension)
        {
            return "an9k-" + DateTime.Now.ToString("yyyyMMddHHmmssFFF") + "." + extension;
        }
    }
}
