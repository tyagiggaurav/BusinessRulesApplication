using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRules.Rules
{

    public class CompositeRule
    {
        private readonly IRule[] rules;
        public CompositeRule(params IRule[] rules)
        {
            this.rules = rules;
        }

        public IReadOnlyCollection<ICommand> Handle(IProduct product)
        {
            var commands = new List<ICommand>();
            foreach (var rule in rules)
                commands.AddRange(rule.Handle(product));
            return commands;
        }
    }
}
