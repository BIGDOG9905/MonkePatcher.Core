﻿using System;

namespace MonkePatcher.Core.Modding
{
    public class InstallationException : Exception
    {
        public InstallationException(string message) : base(message) { }
        public InstallationException(string? message, Exception cause) : base(message, cause) { }
    }
}
