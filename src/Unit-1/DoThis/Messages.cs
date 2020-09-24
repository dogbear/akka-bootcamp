using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTail
{

    public class Messages
    {

        #region Neutral/system messages

        /// <summary>
        /// Marker class to continue processing.
        /// </summary>
        public class ContiunueProcessing { }

        #endregion

        #region Success messages

        public class InputSuccess
        {
            public string Reason { get; private set; }
            public InputSuccess(string reason)
            {
                Reason = reason;
            }
        }

        #endregion

        #region Error messages

        public class InputError
        {

            public string Reason { get; private set; }

            public InputError(string reason)
            {
                Reason = reason;
            }
        }

        public class NullInputError : InputError
        {
            public NullInputError(string reason) : base(reason) { }
        }

        public class ValidationError : InputError
        {
            public ValidationError(string reason) : base(reason) { }
        }
    }

    #endregion
}
