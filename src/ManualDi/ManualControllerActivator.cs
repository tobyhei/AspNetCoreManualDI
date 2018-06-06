using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace ManualDi
{
    public class ManualControllerActivator : IControllerActivator
    {
        private readonly ImmutableDictionary<Type, object> controllers;

        public ManualControllerActivator(IEnumerable<object> controllers)
            => this.controllers = controllers.ToImmutableDictionary(c => c.GetType(), c => c);

        public object Create(ControllerContext context)
        {
            var controllerType = context.ActionDescriptor.ControllerTypeInfo.AsType();
            return controllers[controllerType];
        }

        public void Release(ControllerContext context, object controller)
        {
            // no op
        }
    }
}
