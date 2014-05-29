﻿namespace SharpGo.Core.Ast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class IfNode : INode
    {
        private INode expression;
        private BlockNode block;

        public IfNode(INode expression, BlockNode block)
        {
            this.expression = expression;
            this.block = block;
        }

        public INode Expression { get { return this.expression; } }

        public BlockNode BlockNode { get { return this.block; } }
    }
}