﻿using Castle.DynamicProxy;
using Demo.Library.Exceptions;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Library.Security.Hows
{
    public class Reading : IHow
    {
        private readonly IContainer _container;

        public Reading(IContainer container)
        {
            _container = container;
        }
        public String Description { get { return "Read"; } }
    }
}