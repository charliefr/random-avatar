﻿using System;

namespace RandomAvator
{
    public class RandomAvatarException : Exception
    {
        public RandomAvatarException(Exception ex) : base("", ex)
        {

        }

        public RandomAvatarException(string message) : base(message)
        {

        }
    }
}
