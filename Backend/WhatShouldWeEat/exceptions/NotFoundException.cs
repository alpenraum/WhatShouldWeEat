using System;

namespace WhatShouldWeEat.exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException()
        {
        }

        public NotFoundException(String x) : base(x)
        {
        }

        public NotFoundException(String x, Exception e) : base(x, e)
        {
        }
    }
}