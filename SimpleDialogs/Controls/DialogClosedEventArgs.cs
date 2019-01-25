﻿using SimpleDialogs.Enumerators;

namespace SimpleDialogs.Controls
{
    public class DialogClosedEventArgs
    {
        public DialogButton Result { get; }

        public DialogClosedEventArgs(DialogButton result)
        {
            Result = result;
        }
    }
}